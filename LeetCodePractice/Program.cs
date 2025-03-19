using System.Text.Json;
using LeetCodePractice.Domain;
using LeetCodePractice.LinkedList;
using LeetCodePractice.Recursion;
using LeetCodePractice.Stack;
using LeetCodePractice.StringManipulations;

public class Program
{
    public static void Main()
    {
        Program program = new Program();
        program.StringManip();
    }

    public void StringManip()
    {
        var s = "aaaabbbbcccc";
        var t = "abcabcabcabc";
        PermutationOfString permutationOfString = new PermutationOfString();
        var result = permutationOfString.IsPermutation(s, t);
        // Console.WriteLine($"Are the strings {s} & {t} permutations of each other: {result}");

        s = "abc";
        t = "pqr";
        MergeStringAlternate mergeStringAlternate = new MergeStringAlternate();
        var newResult = mergeStringAlternate.MergeAlternately(s, t);
        
        
        //Console.WriteLine($"{s} & {t} Result: {newResult}");

        MaxCandies maxCandies = new MaxCandies();
        int[] candies = new[] { 2, 3, 5, 1, 3 };
        var listResult = JsonSerializer.Serialize(maxCandies.KidsWithCandies(candies, 3));
        // Console.WriteLine($"Max Candies {listResult}");

        AdjacentFlowers adjacentFlowers = new AdjacentFlowers();
        int[] input = new[] { 1 };
        var adjacentFlowersResult = adjacentFlowers.CanPlaceFlowers(input, 0);
        // Console.WriteLine(adjacentFlowersResult);

        ReverseVowelsClass reverseVowelsClass = new ReverseVowelsClass();
        var reverserResult = reverseVowelsClass.ReverseVowels("IceCreAm");
        //Console.WriteLine($"Original IceCreAm and Reversed {reverserResult}");

        ReverseWords reverseWords = new ReverseWords();
        var reserveWordResult = reverseWords.ReverseWordsFunction("a good   example");
        //Console.WriteLine($"The reverse words are {reserveWordResult}");

        ProductOfArraySelf productOfArraySelf = new ProductOfArraySelf();
        productOfArraySelf.ProductExceptSelf(new[] { 2, 3, 4, 5, 6 });

        IncreasingTripletProblem increasingTripletProblem = new IncreasingTripletProblem();
        var incResult = increasingTripletProblem.IncreasingTriplet(new[] { 20, 100, 10, 12, 5, 13 });
        // Console.WriteLine($"Increasing Triplet Subsequence {incResult}");

        // StringCompression stringCompression = new StringCompression();
        // stringCompression.Compress(new[] { 'a', 'a', 'b', 'b', 'c', 'c', 'c' ,'c', 'c', 'c' });

        MoveZero moveZero = new MoveZero();
        //moveZero.MoveZeroesInPlace(new []{0,1,0,3,12});

        Subsequence subsequence = new Subsequence();
        var subResult = subsequence.IsSubsequence("", "ahbgdc");
        // Console.WriteLine($"IsSubsequence {subResult}");

        Container container = new Container();
        var containerVol = container.MaxArea(new[] {1,8,6,2,5,4,8,3,7});
        //Console.WriteLine($"MaxArea is {containerVol}");

        MaxAverageSubArray averageSubArray = new MaxAverageSubArray();
        averageSubArray.FindMaxAverage(new[] { 5 }, 1);

        HighestAltitude highestAltitude = new HighestAltitude();
        var highAttResult = highestAltitude.LargestAltitude(new[] { -4,-3,-2,-1,4,3,2 });
        //Console.WriteLine($"HighestAltitude {highAttResult}");

        StarFromString starFromString = new StarFromString();
        var starResults = starFromString.RemoveStars("leet***cod*e");
        //Console.WriteLine($"StarFromString {starResults}");

        AsteroidCollisionProb asteroidCollisionProb = new AsteroidCollisionProb();
        asteroidCollisionProb.AsteroidCollision([10,2,-5]);

        ArrayZeroMinOperations arrayZeroMinOperations = new ArrayZeroMinOperations();
        arrayZeroMinOperations.MinimumOperations([1, 5, 0, 3, 5]);
        
        
        #region Add to Linked List
        Node head = new Node(1);
        AddToList addListMethod = new AddToList();
        addListMethod.AddNodeLast(head, 2);
        addListMethod.AddNodeLast(head, 3);
        addListMethod.AddNodeLast(head, 4);
        addListMethod.AddNodeLast(head, 5);
        addListMethod.AddNodeLast(head, 6);
        addListMethod.AddNodeLast(head, 7);
        DeepCopy copy = new DeepCopy();
        copy.CopyRandomList(head);
        // PrintLinkedList.ConsolePrintLinkedList(head);

        #endregion
    }

    public void LinkedListFunctions()
    {
        Node head = new Node(1);

        #region Add to Linked List
        AddToList addListMethod = new AddToList();
        addListMethod.AddNodeLast(head, 2);
        addListMethod.AddNodeLast(head, 3);
        addListMethod.AddNodeLast(head, 4);
        addListMethod.AddNodeLast(head, 5);
        addListMethod.AddNodeLast(head, 6);
        addListMethod.AddNodeLast(head, 7);
        // PrintLinkedList.ConsolePrintLinkedList(head);
        #endregion

        #region Remove element from Linked List
        RemoveFromList removeFromList = new RemoveFromList();
        var modified = removeFromList.RemoveNodeDataFromList(head, 3);
        // PrintLinkedList.ConsolePrintLinkedList(modified);
        modified = removeFromList.RemoveNodeDataFromList(modified, 1);
        // PrintLinkedList.ConsolePrintLinkedList(modified);
        modified = removeFromList.RemoveNodeDataFromList(modified, 6);
        // PrintLinkedList.ConsolePrintLinkedList(modified);
        modified = removeFromList.RemoveNodeDataFromList(modified, 7);
        // PrintLinkedList.ConsolePrintLinkedList(modified);
        #endregion

        #region RemoveDuplicateLinkedListElement
        Node value = new Node(10);
        addListMethod.AddNodeLast(value, 11);
        addListMethod.AddNodeLast(value, 12);
        addListMethod.AddNodeLast(value, 13);
        addListMethod.AddNodeLast(value, 14);
        addListMethod.AddNodeLast(value, 12);
        addListMethod.AddNodeLast(value, 15);
        addListMethod.AddNodeLast(value, 16);
        addListMethod.AddNodeLast(value, 17);
        RemoveDuplicate removeDuplicate = new RemoveDuplicate();
        // PrintLinkedList.ConsolePrintLinkedList(value);
        removeDuplicate.RemoveDuplicateNode(value);
        // PrintLinkedList.ConsolePrintLinkedList(value);
        #endregion

        #region KthElement

        value = new Node(10);
        addListMethod.AddNodeLast(value, 11);
        addListMethod.AddNodeLast(value, 12);
        addListMethod.AddNodeLast(value, 13);
        addListMethod.AddNodeLast(value, 14);
        addListMethod.AddNodeLast(value, 15);
        addListMethod.AddNodeLast(value, 16);
        addListMethod.AddNodeLast(value, 17);
        PrintLinkedList.ConsolePrintLinkedList(value);
        PrintKthElementFromLast PrintKthElementFromLast = new PrintKthElementFromLast();
        PrintKthElementFromLast.Print(value, 3);

        #endregion
        
    }
}