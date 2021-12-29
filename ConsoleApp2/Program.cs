using System;

namespace ConsoleApp2
{

    class kalkutor
    {
        string działanie = Console.ReadLine();
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
