namespace LeetCodePractice.LinkedList;

public class LRUCache
{
    public int _capacity;
    public Dictionary<int, LinkedListNode<(int key, int value)>> _cache;
    public LinkedList<(int key, int value)> _leastRecentlyUsed; 

    public LRUCache(int capacity)
    {
        _cache = new Dictionary<int, LinkedListNode<(int key, int value)>>();
        _leastRecentlyUsed = new LinkedList<(int key, int value)>();
        _capacity = capacity;
    }
    
    public int Get(int key)
    {
        if (!_cache.ContainsKey(key)) return -1;
        
        _cache.TryGetValue(key, out var node);
        _leastRecentlyUsed.Remove(node);
        _leastRecentlyUsed.AddFirst(node);
        
        return node.Value.value;
    }
    
    public void Put(int key, int value) 
    {
        // if already exists then update the value
        if (_cache.TryGetValue(key, out var node))
        {
            _leastRecentlyUsed.Remove(node);
            node.Value = (key, value);
            _cache[key] = node;
            _leastRecentlyUsed.AddFirst(node);
        }
        // add it to the dictionary and put it at the end.
        // if capacity is full then evict lru
        else
        {
            if (_cache.Count == _capacity)
            {
                var lastNode = _leastRecentlyUsed.Last;
                _cache.Remove(lastNode.Value.key);
                _leastRecentlyUsed.RemoveLast();
            }
            var newNode = new LinkedListNode<(int key, int value)>((key, value));
            _cache.Add(key, newNode);
            _leastRecentlyUsed.AddFirst(newNode);
        }
    }
}