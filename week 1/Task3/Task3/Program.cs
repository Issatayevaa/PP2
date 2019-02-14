using System;

namespace Task3
{
    class MainClass
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); // Считываем с консоля string и перевододим его в int

            string s = Console.ReadLine(); //считываем с консоля в string
            string[] firstarray = s.Split(' '); // разделяем нашу строку
            string[] secondarray = new string[2 * n]; // создаем массив который по размеру в 2 раза больше первого

            int cnt = -1; // создаем счетчик 

            for(int i = 0; i < firstarray.Length; i++)//пробегаемся по длине  первого массива
            {
                cnt++;//увеличиваем счетчик,тем самым создавая нулевой элемент в массиве
                secondarray[cnt] = firstarray[i];//нулевой элемент второго массива равень нулевому элементу первого массива
                cnt++;// увеличиваем счетчик
                secondarray[cnt] = firstarray[i];// первый элемент второго массива равен нулевому элементу первого массива
                // дальше идет повторение цикла
            }
            for(int i = 0; i < secondarray.Length; i++)// пробегаемся по длине второго массива
            {
                Console.Write(secondarray[i] + " ");//выводим все жлементы второго массива через пробел 

            }

            Console.ReadKey();//это для того,чтобы программа не закрылась сама по себе 
        }
    }
}
