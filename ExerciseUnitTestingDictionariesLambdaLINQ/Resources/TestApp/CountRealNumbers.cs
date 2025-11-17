using System.Collections.Generic;
using System.Text;

namespace TestApp;

public class CountRealNumbers
{
    public static string Count(int[] nums)
    {
        
        //[2, 5, 2, 1, 8, 5]
        SortedDictionary<int, int> count = new();

        foreach (int num in nums)
        {
            count.TryAdd(num, 0);
            count[num]++;
        }

        //Key - числото
        //Value - брой повторения
        //1 -> 1
        //2 -> 2
        //5 -> 2
        //8 -> 1

        StringBuilder sb = new();
        foreach (KeyValuePair<int, int> pair in count)
        {
            sb.AppendLine($"{pair.Key} -> {pair.Value}");
        }

        return sb.ToString().Trim();
    }
}
