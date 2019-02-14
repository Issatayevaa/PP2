using System;

namespace Task4
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());//конвентируем string в int
            string[,] doublearray = new string[n, n];//создаем двумерный массив n x n
            string pattern = "[*]";//создаем переменную,которая равна [*]

            for(int i = 0; i < n; i++)//с помощью for создаем место в массиве 
            {
                for(int j = 0;j <= i; j++)
                {
                    doublearray[i, j] = pattern;//с помощью for  заполняем массив pattern

                }
            }
            for(int i = 0; i < n; i++)
            {
                for(int j = 0;j < n; j++)
                {
                    Console.Write(doublearray[i, j]);//выводим на экран двумерный массив

                }
                Console.WriteLine();//действует,как кнопка ввода

            }
            Console.ReadKey();//это для того,чтобы консоль не закрылся 
        }
    }
}
