class Solution
{
    static void countApplesAndOranges(int s, int t, int a, int b, int[] apples, int[] oranges) {
        var houseRange = new Dictionary<int, int>();
        
        for (var i = s; i <= t; i++)
        {
            houseRange.Add(i, i);
        }
        
        int applesCount = 0;
        for (var i = 0; i < apples.Length; i++)
        {
            if (houseRange.ContainsKey(apples[i] + a))
            {
                applesCount++;
            }
        }
            
        int orangesCount = 0;
        for (var i = 0; i < oranges.Length; i++)
        {
            if (houseRange.ContainsKey(oranges[i] + b))
            {
                orangesCount++;
            }
        }   
        
        Console.WriteLine(applesCount);
        Console.WriteLine(orangesCount);

    }
}