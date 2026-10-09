// See https://aka.ms/new-console-template for more information

// Task09 Array utility class(method practice)

using System;
using System.Linq;

public class ArrayTool
{
    static void Main()
    {
        int[] arr = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

        int max = GetMax(arr);
        int min = GetMin(arr);
        double avg = GetAverage(arr);

        Console.WriteLine($"最大值：{max}");
        Console.WriteLine($"最小值：{min}");
        Console.WriteLine($"平均值：{avg:F2}");
    }
    
    static int GetMax(int[] nums)
    {
        int maxVal = nums[0];
        for (int i = 1; i < nums.Length; i++)
        {
            if(nums[i] > maxVal)
            {
                maxVal = nums[i];
            }
        }
        return maxVal;
    }

    static int GetMin(int[] nums)
    {
        int minVal = nums[0];
        for (int i = 1; i < nums.Length; i ++)
        {
            if(nums[i] < minVal)
            {
                minVal = nums[i];
            }
        }
        return minVal;
    }

    static double GetAverage(int[] nums)
    {
        int sum = 0;
        for(int i = 0; i < nums.Length; i++)
        {
            sum += nums[i];            
        }
        return (double)sum / nums.Length;
    }
}