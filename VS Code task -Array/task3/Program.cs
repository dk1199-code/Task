using System;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
             int[] arr=new int[20];
             int sum=0;
            int n=Convert.ToInt32(Console.ReadLine());
            for(int i=0;i<n;i++)
            {
                arr[i]=Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("The sum of the array are");
            for(int j=0;j<n;j++)
            {
                sum +=arr[j];
            }
            Console.WriteLine(sum);
        }
    }
}
