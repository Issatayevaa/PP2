using System;
using System.IO;

namespace Task1
{
    class MainClass
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("/Users/Queen/Desktop/one.rtf");//считываем информацию с файла
            string s = sr.ReadLine();//считываем полностью строку
            bool isTrue;// создаем bool равный true
            while (s != null)//пока слово не равно 0
            {
                isTrue = true;//функция работает 
                for (int i = 0; i <= s.Length / 2; i++)// пробегаемся по длине слова 
                {
                    if (s[i] != s[s.Length - i - 1])//если буквы с двух сторон не соотвествуют друг другу
                    {
                        isTrue = false;// то слово не является полиндромом 
                        break;
                    }
                }
                if (isTrue)// если слово - полиндром
                {
                    Console.WriteLine("YES");// выводим на экран ДА
                }
                else//если слово - не полиндром 
                {
                    Console.WriteLine("NO");// выводим НЕТ
                }
                s = sr.ReadLine();// считываем всю строку
            }
            sr.Close();//

            Console.WriteLine(s);//выводим слово
            Console.ReadKey();//чтобы консоль не закрывался 
        }
    }
}
