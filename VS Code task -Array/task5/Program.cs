using System;

namespace task5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr=new int[20];
            int l=0;
            int n=Convert.ToInt32(Console.ReadLine());
            for(int i=0;i<n;i++)
            {
                arr[i]=Convert.ToInt32(Console.ReadLine());
            }
            for(int j=0;j<n;j++)
            {
                for(int k=j+1;k<n;k++)
                {
                    if(a==0)
                    {
                    if(arr[k]==arr[j])
                    {
                        
                        a=a+1;
                        l++;
                    }
                    }
                }
                           
            }
            Console.WriteLine("The number of duplicate elements are : "+l);
        }
    }
}
