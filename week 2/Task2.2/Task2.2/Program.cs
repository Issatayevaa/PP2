using System;
using System.IO;
namespace Task2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("/Users/Queen/Desktop/input.rtf");//считываем содержимое с файла
            string s = sr.ReadLine();//считываем строку
            bool isTrue;//создаем   bool равный true
            string[] input = s.Split(' ');// разделяем строку на пробел
            StreamWriter sw = new StreamWriter("/Users/Queen/Desktop/output.rtf");//вписываем данные в файл

            for(int i = 0; i < input.Length; i++)//пробегаемся по длине файла
            {
                int current = int.Parse(input[i]);//вводим переменную и переводим ее в int
                isTrue = true;
                for(int j = 2; j <= Math.Sqrt(current); j++)//проверяем числа на prime 
                {
                    if(current % j == 0)
                    {
                        isTrue = false;
                        break;
                    }
                }

                if(isTrue && current != 1)
                {
                    sw.Write(current + " ");//выводим простые числа через пробел 
                }
            }
            Console.ReadKey();
        }
    }
}
