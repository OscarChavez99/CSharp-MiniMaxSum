class Result
{
    /*
     * Complete the 'miniMaxSum' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void miniMaxSum(List<int> arr)
    {
        // Guard clause
        if (arr == null || arr.Count == 0) return;

        /* Initialize minElement to the maximum possible value 
         * so we can compare downward
         */
        long minElement = long.MaxValue;

        /* Initialize maxElement to the minimum possible value 
         * so we can compare upward
         */
        long maxElement = long.MinValue;
        long totalSum = 0;

        foreach (int number in arr)
        {
            // Add every number regardless of the condition
            totalSum += number;

            if (number < minElement)
            {
                minElement = number;
            }
            if (number > maxElement)
            {
                maxElement = number;
            }
        }

        // Subtract the maximum and minimum elements to get min and max sums
        long minSum = totalSum - maxElement;
        long maxSum = totalSum - minElement;

        Console.Write($"{minSum} {maxSum}");
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.miniMaxSum(arr);
    }
}