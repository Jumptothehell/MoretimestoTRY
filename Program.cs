using System;

namespace Tester
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] storenumber = new string [999999];
            int i = 0;
            bool WhenisEND = false;
            while (WhenisEND == false)
            {
                storenumber[i] = Console.ReadLine();
                if (storenumber[i] == "End")
                {
                    WhenisEND = true;
                }
                i++;
            }

            int lenghtofstorenumberonly = 0;
            for (int j = 1; j < storenumber.Length; j++)
            {
                if (storenumber[j] == "End")
                {
                    lenghtofstorenumberonly = j;
                }                    
            }

            double[] storenumberonly = new double[lenghtofstorenumberonly];
            for (int j = 0; j < lenghtofstorenumberonly; j++)
            {
                storenumberonly[j] = double.Parse(storenumber[j]);
            }

            double max = storenumberonly[0];
            double min = storenumberonly[0];
            double total = 0;


            bool InvalidMode = false;
            while (InvalidMode == false)
            {
                string Find = "0";
                Find = Console.ReadLine();
                for (int m = 0; m < storenumberonly.Length; m++)
                {
                    if (max < storenumberonly[m])
                    { max = storenumberonly[m]; }
                    if (min > storenumberonly[m])
                    { min = storenumberonly[m]; }
                    total += storenumberonly[m];
                }
                double mean = total / storenumberonly.Length;
                if (Find == "FindMax")
                {
                    Console.WriteLine(max);
                    InvalidMode = true;
                }
                else if (Find == "FindMim")
                {
                    Console.WriteLine(min);
                    InvalidMode = true;
                }
                else if (Find == "FindMean")
                {
                    Console.WriteLine(mean);
                    InvalidMode = true;
                }
                else
                {
                    Console.WriteLine("Invalid mode");
                }

            }
        }
    }
}
