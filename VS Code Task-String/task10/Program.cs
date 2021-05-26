using System;

namespace task10
{
    class Program
    {
        public static void Main(string[] args)
        {
            string input1;
            int a=0;
            char c='a';
            input1=Console.ReadLine();
            for(int i=0;i<input1.Length;i++)
            {

                 char input=input1[i];
                 int l=0;
                for(int j=0;j<input1.Length;j++)
                {
                    if(input==input1[j])
                    {
                        l++;
                    }
                }
                if(l>=a)
                {
                    a=l;
                    c=input;
                }

            }
            Console.WriteLine("The most repeted word is :"+c);
            Console.WriteLine("The number of times word repeated is :"+a);

        }
    }
}
