using System;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr=new int[20];
            int[] arr2=new int[20];
            int l=0;
            int n=Convert.ToInt32(Console.ReadLine());
            for(int i=0;i<n;i++)
            {
                arr[i]=Convert.ToInt32(Console.ReadLine());
            }
            for(int j=0;j<n;j++)
            {
                arr2[j]=arr[j];
                l++;
            }
            Console.WriteLine("The coopied array is");
            for(int k=0;k<l;k++)
            {
                Console.WriteLine(arr2[k]);

            }
        }
    }
}
