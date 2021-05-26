using System;

namespace task9
{
    class Program
    {
        static void Main(string[] args)
        {
            string input1;
            string input2="aeiou";
            int l=0,a;
            input1=Console.ReadLine();
            for(int i=0;i<input1.Length;i++)
            {
                for(int j=0;j<input2.Length;j++)
                {
                    if(input1[i]==input2[j])
                    {
                        l++;

                    }
                }
            }
            a=input1.Length-l;
            Console.WriteLine("The number of voweles in the string is"+l);
            Console.WriteLine("The number of consonents in the string is"+a);
        }
    }
}
