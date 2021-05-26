using System;

namespace task8
{
    class Program
    {
        static void Main(string[] args)
        {
            string input1;
            char[] input2=new char[50];
            int l=0;
            input1=Console.ReadLine();
            for(int i=0;i<input1.Length;i++)
            {
                char a=input1[i];
                input2[i]=a;
                l++;
            }
            Console.Write("The chracters cooped is :");
            for(int j=0;j<=l;j++)
            {
                Console.Write(input2[j]);

            }
            Console.WriteLine(" ");
            Console.WriteLine("The numbers of characters coopierd : " + l);  
        }
    }
}
