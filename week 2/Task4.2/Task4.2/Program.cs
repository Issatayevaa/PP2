using System;
using System.IO;
namespace Task4
{
    class MainClass
    {
        static void Main(string[] args)
        {
            string path = "/Users/Queen/Desktop";//указываем адрес path
            string nameFile = "text.txt";//создаем файл в path

            string path1 = "/Users/Queen/Desktop/PP2";//указывем адрес path1

            StreamWriter sw = new StreamWriter(path + nameFile);//добавляем текстовый в path
            sw.WriteLine("AbCdEf");//добавляем текст в текствовый файл 
            sw.WriteLine("AbCdEf");

            sw.Close();

            File.Copy(path + nameFile, path1 = "\\" + nameFile);//копируем содержимое path и переносим в path1

            File.Delete(path + nameFile);//удаляем содержимое path

        }
    }
}



