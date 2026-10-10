// See https://aka.ms/new-console-template for more information

// Task10 array reversal

using System;

public class ArrayReverse
{
    static void Main()
    {
        int[] arr = { 1, 2, 3, 4 };
        Console.WriteLine("反转前数组：");
        PrintArray(arr);

        ReverseArray(arr);

        Console.WriteLine("反转后数组：");
        PrintArray(arr);
    }

    static void ReverseArray(int[] nums)
    {
        int left = 0;
        int right = nums.Length - 1;
        while(left < right)
        {
            int temp = nums[left];
            nums[left] = nums[right];
            nums[right] = temp;

            left ++;
            right --;
        }
    }

    static void PrintArray(int[] nums)
    {
        for(int i = 0; i < nums.Length; i ++)
        {
            Console.Write(nums[i] + " ");
        }
        Console.WriteLine();
    }
}