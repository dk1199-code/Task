using System;

namespace task11
{
    class Program
    {
        static void Main(string[] args)
        {
            string input1;
            input1=Console.ReadLine();
            char[] input2=input1.ToCharArray();
            for(int i=0;i<input1.Length-1;i++)
            { 
                for(int j=i+1;j<input1.Length;j++)
                {
                if(input2[i]>input2[j])
                {
                    char a;
                    a=input2[i];
                    input2[i] = input2[j];
                    input2[j]=a;
                }
                }
            }
            foreach (char ab in input2)
            {
                char c;
                c=ab;
                Console.WriteLine(c);                   
            }

        }
    }
}
