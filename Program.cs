//Test
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Voltage_Reader
    {
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = new int[72];
            Random Volt = new Random();
            for (int i = 0; i < n.Length; i++)
                n[i] = Volt.Next(40);

            Console.Write("Hour\t\tVoltage\t\tHistogram\n");
            for (int i = 0; i < n.Length; i++)
            {
                Console.Write("\n  " + (i + 1) + "\t\t  " + n[i] + "\t\t  ");
                for (int j = 0; j < n[i]; j++)
                {
                    Console.Write("*");
                }
            }

            double sum = 0;
            for (int i = 0; i < n.Length; i++)
                sum = sum + n[i];
            double mean = sum / 72;
            Console.Write("\n\n Mean = " + mean);
            double mean1 = mean * 0.9;
            double mean2 = mean * 1.1;
            Console.Write("\n\n Hours vary from mean by more than 10% :\n");
            for (int i = 0; i < n.Length; i++)
            {
                if (n[i] < mean1 || n[i] > mean2)
                    Console.Write((i + 1) + "\t");
            }
            double mean3 = mean * 0.15;
            double x;
            Console.Write("\n\n Hours where change is more than 15% :\n");
            for (int i = 0; i < n.Length-1; i++)
            {
                        x = (n[i + 1] - n[i]);
                    x = Math.Abs(x);
                    if (x > mean3)
                        Console.Write(i + 1 + "," + (i + 2) + "\t");
            }

            Console.WriteLine();
            Console.ReadKey();

        }
    }
}
