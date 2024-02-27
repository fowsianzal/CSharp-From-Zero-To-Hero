using System;


namespace BootCamp.Chapter1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of elements in the array");
            int n= Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            Console.WriteLine("Enter the elements of the array");
            for(int i=0;i<n;i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            ArrayOperations.Sort(arr);
            Console.WriteLine("The sorted array is:");
            for(int i=0;i<n;i++)
            {
                Console.WriteLine(arr[i]);
            }
            ArrayOperations.Reverse(arr);
            Console.WriteLine("The reversed array is:" );
            for(int i=0;i<n;i++)
            {
                Console.WriteLine(arr[i]);
            }
            int[] arr2=ArrayOperations.RemoveLast(arr);
            Console.WriteLine("The array after removing the last element is:");
            for(int i=0;i<arr2.Length;i++)
            {
                Console.WriteLine(arr2[i]);
            }
            int[] arr3=ArrayOperations.RemoveFirst(arr2);
            Console.WriteLine("The array after removing the first element is:");
            for(int i=0;i<arr3.Length;i++)
            {
                Console.WriteLine(arr3[i]);
            }
            int[] arr1=ArrayOperations.RemoveAt(arr3,2);
            Console.WriteLine("The array after removing the element at index 2 is:");
            for(int i=0;i<arr1.Length;i++)
            {
                Console.WriteLine(arr1[i]);
            }
            int[] arr4=ArrayOperations.InsertLast(arr1, 5);
            Console.WriteLine("The array after inserting 5 at the end is:");
            for (int i = 0; i < arr4.Length; i++)
            {
                Console.WriteLine(arr4[i]);
            }
            int[] arr5=ArrayOperations.InsertFirst(arr4, 5);

            Console.WriteLine("The array after inserting 5 at the beginning is:");
            for (int i = 0; i < arr5.Length; i++)
            {
                Console.WriteLine(arr5[i]);
            }
            int[] arr6=ArrayOperations.InsertAt(arr5, 5, 2);
            Console.WriteLine("The array after inserting 5 at index 2 is:");
            for (int i = 0; i < arr6.Length; i++)
            {
                Console.WriteLine(arr6[i]);
            }
        }
    }
}
