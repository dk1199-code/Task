using System;

namespace task6
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
            Console.WriteLine("The unique elements in the array are:");
            for(int j=0;j<n;j++)
            {
                if(arr[j]>0)
                {
                for(int k=j+1;k<n;k++)
                {
                    if(arr[j]==arr[k])
                    {
                        arr[j]=0;
                        arr[k]=0;                    }
                }
                }
                
            }
            for(int c=0;c<n;c++)
            {
                if(arr[c]>0)
                {
                    Console.WriteLine(arr[c]);
                }
            }
            
        }
    }
}
