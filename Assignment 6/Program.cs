using System.ComponentModel.DataAnnotations;

namespace Assignment_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 1 Explain the difference between passing (Reference type parameters) by value and by reference then write a suitable c# example.
            //the main diffrence between passing (Reference type parameters) by value and by reference that 
            //in passing by value you pass the value of the argument only while in passing by reference the 
            //argument it self is being passed 
            //Ex by value
            //static int sumValue(int[] arr)
            //{
            //    int sum = 0;
            //    arr = new int[] { 2, 4, 6 };
            //    for (int i = 0; i < arr.Length; i++)
            //    {
            //        sum += arr[i];
            //    }
            //    return sum;
            //}

            //int[] ar = { 1, 2, 3 };
            //Console.WriteLine( sumValue(ar));
            //foreach (int arr in ar) 
            //    Console.WriteLine(arr);
            //Ex by reference
            //static int sumValue(ref int[] arr)
            //{
            //    int sum = 0;
            //    arr = new int[] { 2, 4, 6 };
            //    for (int i = 0; i < arr.Length; i++)
            //    {
            //        sum += arr[i];
            //    }
            //    return sum;
            //}

            //int[] ar = { 1, 2, 3 };
            //Console.WriteLine(sumValue(ref ar));
            //foreach (int arr in ar)
            //    Console.WriteLine(arr);
            #endregion

            #region Question 2 Write a c# Function that accept 4 parameters from user and return result of summation and subtracting of two numbers
            //static void SumSub(int x, int y, out int sum,out int sub)
            //{
            //sum = x+y;
            //sub = x - y;
            //}
            //Console.Write("Enter the first number: ");
            //int.TryParse(Console.ReadLine(), out int a);
            //Console.Write("Enter the second number: ");
            //int.TryParse(Console.ReadLine(), out int b);
            //SumSub(b, a, out int sum,out int sub);
            //Console.WriteLine($"the summation of the two numbers: {sum}");
            //Console.WriteLine($"the subtracting of the two numbers: {sub}");
            #endregion

            #region Question 3 Create a function named MinMaxArray, to return the minimum and maximum values stored in an array, using reference parameters
            //static void MinMaxArray(ref int[] array,ref int max,ref int min)
            //{
            //    max = array[0];
            //    min = array[0];
            //    for (int i = 1; i < array.Length; i++)
            //    {
            //        if (array[i] > max)
            //        {
            //            max = array[i];
            //        }
            //        if (array[i] < min)
            //        {
            //            min = array[i];
            //        }
            //    }
            //}

            //int[] ints = { 34, 234, 12, -11, -132, 135, 97 };
            //int max=0, min=0;
            //MinMaxArray(ref ints, ref max, ref min);
            //Console.WriteLine($"the max element in the array is : {max}");
            //Console.WriteLine($"the min element in the array is : {min}");
            #endregion


        }
    }
}
