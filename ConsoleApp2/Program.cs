using System;

namespace ConsoleApp2
{

    class kalkutor
    {
        public string wyrażenie = Console.ReadLine();
        
        string[] liczby = new string[8];
        string[] znaki = new string[7];
        
        public kalkutor()
        {
           
        }

        

        public void literacja()
        {
            string liczba = "";
            int lenght = wyrażenie.Length;
            int licznik = 0;
            for (int i = 0; i<lenght; i++)
            {
                string letter = wyrażenie[i].ToString();
                if (letter == "+" | letter == "-" | letter == "*" | letter == "/" )
                {
                    znaki[licznik] = letter;
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
            //int ll = liczby.Length;
            liczby[licznik] = liczba;
            //Console.WriteLine(ll);

            foreach (string i in liczby)
            {
                Console.WriteLine(i);
            }
            foreach (string i in znaki)
            {
                Console.WriteLine(i);
            }

        }
        public void liczenie()
        {
            int lenght2 = znaki.Length;
            for(int i = 0;i<lenght2; i++)
            {
                int where;
                int a;
                int b;
                int c;

                 where = Array.IndexOf(znaki, "*");
                //Console.WriteLine(where);
                a = Convert.ToInt32(liczby[where]);
                where += 1;
                b = Convert.ToInt32(liczby[where]);
                c = b * a;
                

                 where = Array.IndexOf(znaki, "/");
                //Console.WriteLine(where);
                a = Convert.ToInt32(liczby[where]);
                where += 1;
                b = Convert.ToInt32(liczby[where]);
                
                where = Array.IndexOf(znaki, "+");
                //Console.WriteLine(where);
                a = Convert.ToInt32(liczby[where]);
                where += 1;
                b = Convert.ToInt32(liczby[where]);
                
                where = Array.IndexOf(znaki, "-");
                //Console.WriteLine(where);
                a = Convert.ToInt32(liczby[where]);
                where += 1;
                b = Convert.ToInt32(liczby[where]);
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
            Console.WriteLine("W tym kalkulatorze można używać tylko liczb całkowitych (max 8) i działań \'+\' \'-\' \'*\' \'/\'");
            kalkutor siema = new kalkutor();
            siema.literacja();
            siema.liczenie();
        }
    }
}
