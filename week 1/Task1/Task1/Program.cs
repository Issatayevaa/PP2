using System;

namespace Task1
{
    class MainClass
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());// считываем с консоля string и переводим в int

            string s = Console.ReadLine();//считываем с консоля string
            string[] input = s.Split(' ');//разделяем нашу строку на пробел
            for(int i =0; i < input.Length; i++)//пробегаемся по длине массива
            {
                int current = int.Parse(input[i]);//ввожу пременную и перевожу ее в int
                bool isPrime = true;//предполагаем,что bool is true
                for(int j = 2; j <= Math.Sqrt(current); j++)//проверяю числа на prime
                {
                    if(current % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if(isPrime && current != 1)
                {
                    Console.Write(current + " ");//вывожу простые числа через пробел
                }
            }
            Console.ReadKey();//это,чтобы программа не закрылась
        }
    }
}
