using System;

namespace ConsoleApp2
{

    class kalkutor
    {
        string wyrażenie = Console.ReadLine();
        string działanie = "";
        int a = 0;
        int b = 0;
        int c = 0;

        void liczenie()
        {

            if(działanie=="+")
            {

            }
            else if (działanie == "-")
            {

            }
            else if (działanie == "*")
            {

            }
            else if (działanie == "/")
            {

            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("W tym kalkulatorze można używać tylko liczb całkowitych i działań \'+\' \'-\' \'*\' \'/\'");
            kalkutor siema = new kalkutor();

        }
    }
}
