using System;

namespace Task2
{
    class Student

    {
        private int id = 0;//создаю интовую переменную id
        public string name = "";//созаю стринговую прееменную name
        public int yearofstudy = 0;//создаю интовую переменную yearofstudy

        //public Student() { }

        public Student(string n, int id)//создаем конструктор Student
        {
            name = n;//присвоила name-y n
            this.id = id;//присвоила  this.id id
        }
        public int getId()//т.к. id private,вызвала функцию getId,чтобы получить id
        {
            return this.id;//эта функция возвращает this.id
        }
        public void incrementYearOfStudy()//вызываю функцию incrementYearOfStudy
        {
            this.yearofstudy++;//увеличиваем год обучения
        }
    }
    class MainClass
    {


        static void Main(string[] args)
        {
            Student s = new Student("a", 1);//
            Console.WriteLine(s.getId());
            s.getId();
            s.incrementYearOfStudy();
            Console.WriteLine(s.yearofstudy);//выводит год обучния на экран

            Console.ReadKey();//чтобы,консоль не закрывался
        }
    }
}












