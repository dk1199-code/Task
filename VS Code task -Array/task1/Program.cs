using System;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr=new int[20];
            int n=Convert.ToInt32(Console.ReadLine());
            for(int i=0;i<n;i++)
            {
                arr[i]=Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("The entered arrays are");
            for(int j=0;j<n;j++)
            {
                Console.WriteLine(arr[j]);
            }
        }
    }
}
