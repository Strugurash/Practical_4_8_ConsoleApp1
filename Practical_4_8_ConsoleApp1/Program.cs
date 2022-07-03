using System;

namespace Practical_4_8_ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int summ=0;
            Console.Write(" Введите количество строк :");
            int line = int.Parse(Console.ReadLine());
            Console.Write(" Введите количество столбцов :");
            int column = int.Parse(Console.ReadLine());
            int[,] array = new int[line, column];
            Random rand = new Random();
            for (int i = 0; i < line; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    array[i, j] = rand.Next(100);
                    Console.Write($" {array[i , j]}");
                    summ=summ+array[i, j];
                }
                Console.WriteLine();
            }
            Console.WriteLine(" Сумма всех элементов : {0}",summ);
            Console.ReadLine();
        }
    }
}
