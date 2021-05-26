using System;

namespace task6
{
    class Program
    {
        static void Main(string[] args)
        {
            string input1,input2;
            input1=Console.ReadLine();
            input2=Console.ReadLine();
            int length1,length2;
            length1=input1.Length;
            length2=input2.Length;
            if(length1==length2)
            {
                Console.WriteLine("The entered srings are equal");
            }
            else
            {
                Console.WriteLine("The entered string is not equal");
            }
       }
    }
}
