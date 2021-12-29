using System;

namespace ConsoleApp2
{

    class kalkutor
    {
        public string wyrażenie = Console.ReadLine();
        string działanie = "";
        string[] liczby = new string[] {"nie ma tego" };
        
     

        

        public void literacja()
        {
            string liczba = "";
            int lenght = wyrażenie.Length;
            for (int i = 0; i<lenght; i++)
            {
                string letter = wyrażenie[i].ToString();
                if (letter == "+" | letter == "-" | letter == "*" | letter == "/" )
                {
                    int licznik = 0;
                    liczby[licznik] = liczba;
                    liczba = "";
                    licznik += 1;
                }
                else
                {
                    liczba += letter;
                }
                //Console.Write(letter);
                
            }
            int ll = liczby.Length;
            liczby[ll+1] = liczba;


            Console.Write(liczby);
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

        public override string ToString()
        {
            return liczby.ToString();
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
