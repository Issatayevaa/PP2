using System;
using System.IO;
namespace Task4
{
    class MainClass
    {
        static void Main(string[] args)
        {
            string path = "/Users/Queen/Desktop";//указываем адрес path
            string nameFile = "text.txt";//создаем в нем файл

            string path1 = "/Users/Queen/Desktop/PP2";//указываем адрес path1

            StreamWriter sw = new StreamWriter(path + nameFile);//вводим в path слово
            sw.WriteLine("AbCdEf");//выводим на экран
            sw.WriteLine("AbCdEf");

            sw.Close();

            File.Copy(path + nameFile, path1 = "\\" + nameFile);//копируем содержимое path и переносим в path1

            File.Delete(path + nameFile);//удаляем содержимое path

        }
    }
}



