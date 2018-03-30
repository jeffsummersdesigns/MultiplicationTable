using System;

namespace MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Create a multiplication table out of your inputs.");
            Console.WriteLine();
            Console.WriteLine("Please enter a number(up to two digits) for the rows of the table.");
            int row = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine();
            Console.WriteLine("Please enter a number(up to two digits) for the columns of the table.");
            int col = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            int[,] table = new int[row, col];

            // for each element in the first array dimension...
            for (int i = 1; i <= table.GetLength(0); ++i)
            {
                // iterate over each element in the second array dimension
                for (int j = 1; j <= table.GetLength(1); ++j)
                {
                    // remember that array indices start at 0!
                    table[i - 1, j - 1] = i * j;
                    if (table[i - 1, j - 1] < 10)
                        Console.Out.Write("|  " + table[i - 1, j - 1]);
                    else if (table[i - 1, j - 1] > 9 && table[i - 1, j - 1] < 100)
                        Console.Out.Write("| " + table[i - 1, j - 1]);
                    else
                        Console.Out.Write("|" + table[i - 1, j - 1]);
                }
                Console.Out.Write("|"); // after last number on line
                Console.Out.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
