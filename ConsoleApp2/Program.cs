using System;

namespace ConsoleApp2
{

    class kalkutor
    {
        public string wyrażenie = Console.ReadLine();
        string działanie = "";
        
        int a = 0;
        int b = 0;
        int c = 0;

        

        public void literacja()
        {
            int lenght = wyrażenie.Length;
            for (int i = 0; i<lenght; i++)
            {
                Console.Write(wyrażenie[i]);
            }
        }
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
            siema.literacja();
        }
    }
}
