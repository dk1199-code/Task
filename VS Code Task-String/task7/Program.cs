using System;

namespace task7
{
    class Program
    {
        static void Main(string[] args)
        {
            string input1;
            input1=Console.ReadLine();
            int a=0,b=0,c=0;
            for(int i=0;i<input1.Length;i++)
            {
                if((input1[i]>='a' && input1[i]<='z')||(input1[i]>='A' && input1[i]<='Z'))
                {
                    a++;
                }
                else if( (input1[i]>='0' && input1[i]<='9'))
                {
                    b++;
                }
                else{
                    c++;
                }
            }
            Console.WriteLine("The Alphabets in a string :"+a);
            Console.WriteLine("Total Numbers in a string :"+b);
            Console.WriteLine("The Special Characters in a string :"+c);
        }
    }
}
