namespace LeetCodePractice.Recursion;

public class SearchSuggestion
{
    public SearchSuggestion()
    {
        SuggestedProducts(["mobile", "mouse", "moneypot", "monitor", "mousepad"], "mouse");
    }
    public IList<IList<string>> SuggestedProducts(string[] products, string searchWord) {
        Array.Sort(products); // Sort the products lexicographically
        List<IList<string>> result = new List<IList<string>>();
        string prefix = "";

        foreach (char c in searchWord) {
            prefix += c;
            List<string> suggestions = new List<string>();

            // Use binary search to find the starting index of products with the current prefix
            int left = 0;
            int right = products.Length - 1;
            int startIndex = -1;

            while (left <= right) {
                int mid = left + (right - left) / 2;
                if (products[mid].StartsWith(prefix)) {
                    startIndex = mid;
                    right = mid - 1; // Try to find an even earlier occurrence
                } else if (products[mid].CompareTo(prefix) < 0) {
                    left = mid + 1;
                } else {
                    right = mid - 1;
                }
            }

            // Collect the top 3 suggestions starting from the found index
            if (startIndex != -1) {
                for (int i = startIndex; i < Math.Min(startIndex + 3, products.Length); i++) {
                    if (products[i].StartsWith(prefix)) {
                        suggestions.Add(products[i]);
                    } else {
                        break; // Optimization: If a product doesn't start with the prefix, no subsequent ones will either (due to sorting)
                    }
                }
            }
            result.Add(suggestions);
        }
        return result;
    }
}