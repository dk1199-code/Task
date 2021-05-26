using System;

namespace task5
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            int l=0;
            input=Console.ReadLine();
            for(int i=0;i<input.Length;i++)
            {
                
                if(input[i] ==' ' || input[i] =='\t')
                {
                    l++;

                }
            }
            Console.WriteLine(l);
        }
    }
}
