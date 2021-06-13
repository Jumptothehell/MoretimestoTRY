using System;

namespace Tester
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] numberinput09 = new int[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    numberinput09[i, j] = int.Parse(Console.ReadLine());
                }
            }
            int ifihaveanumberyet = int.Parse(Console.ReadLine());
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(numberinput09[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();

            int[,] newnumberintput19 = new int[3, 3];
            string Available = "0";

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    newnumberintput19[i, j] = numberinput09[i, j];
                    if (numberinput09[i, j] == ifihaveanumberyet)
                    {
                        Available = "The number is available";
                        Console.WriteLine(Available);
                    }
                    else if (numberinput09[i, j] == 0)
                    {
                        newnumberintput19[i, j] = ifihaveanumberyet;
                    }
                }
            }
            if (Available == "The number is available")
            {
                Console.ReadLine();  
            }
            else 
            {
                for (int m = 0; m < 3; m++)
                {
                    for (int n = 0; n < 3; n++)
                    {
                        Console.Write(newnumberintput19[m, n] + " ");
                    }
                    Console.WriteLine();
                }
            }
            
        }
    }
}
