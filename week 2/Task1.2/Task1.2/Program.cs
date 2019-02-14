using System;

namespace Task1
{
    class MainClass
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(@"C:\\1.rtf");
            string s = sr.ReadLine();
            bool isTrue;
            while (s != null)
            {
                isTrue = true;
                for (int i = 0; i <= s.Length / 2; i++)
                {
                    if (s[i] != s[s.Length - i - 1])
                    {
                        isTrue = false;
                        break;
                    }
                }
                if (isTrue)
                {
                    Console.WriteLine("YES");
                }
                else
                {
                    Console.WriteLine("NO");
                }
                s = sr.ReadLine();
            }
            sr.Close();

           // Console.Writeline(s);
            Console.ReadKey();
        }
    }
}
