using System;
using System.IO;
namespace Task3
{
    class MainClass
    {
        public static void printSpaces(int level)//вводим интовую переменную level
        {
            for(int i = 1;i <= level * 4; i++)//с помощью for создаем отступы 
            {
                Console.Write(" ");//отступ 
            }
        }
        public static void showDirectory(DirectoryInfo d,int level)//
        {
            DirectoryInfo[] arrayofDirectories = d.GetDirectories();
            FileInfo[] arrayofFiles = d.GetFiles();

            foreach(FileInfo f in arrayofFiles)//для каждого файла 
            {
                printSpaces(level);//делаем отступы
                Console.WriteLine(f.Name);//выводим имя файла
            }

            foreach(DirectoryInfo di in arrayofDirectories)//для каждой директории 
            {
                printSpaces(level);//делаем отступ 
                Console.WriteLine(di.Name);//выводим имя директории
                showDirectory(di, level + 1);
            }
        }
        static void Main(string[] args)
        {
            DirectoryInfo di = new DirectoryInfo("/Users/Queen/Desktop/PP2");//адрес директории

            showDirectory(di, 0);

            Console.ReadKey();

        }
    }
}
