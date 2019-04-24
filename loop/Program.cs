using System;

namespace loop
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = 10;
            int[] numbers = new int[size];
            for (int i = 1; i <= size; i++)
            {
                numbers[i - 1] = i;
            }

            for (int i = 0; i < size; i++)
            {
                int anumber = numbers[i];
                if (anumber % 2 == 0)
                    
                {
                    
                    //Console.Write("even=" );
                    Console.WriteLine(anumber);
                    
                } 

                else
                   
                {
                    Console.Write("odd= ");
                    Console.WriteLine(anumber);
            
                }
            }
            Console.ReadKey();

        }
    }
}
