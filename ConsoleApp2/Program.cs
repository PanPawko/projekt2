using System;
using System.Collections.Generic;

namespace ConsoleApp2
{

    class Kalkutor
    {
        public string wyrażenie = Console.ReadLine();
        
        List<string> liczby = new List<string>();
        List<string> znaki = new List<string>();
        
        public Kalkutor()
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
                    znaki.Add(letter);
                    liczby.Add(liczba);
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
            liczby.Add(liczba);
            //Console.WriteLine(ll);

            /*foreach (string i in liczby)
            {
                Console.WriteLine(i);
            }
            foreach (string i in znaki)
            {
                Console.WriteLine(i);
            }*/

        }
        public void liczenie()
        {
            //int lenght = wyrażenie.Length;
            int lenght2 = znaki.Count;
            
            for(int i = 0;i<lenght2; i++)
            {
                int where;
                int a;
                int b;
                int c;
                string cs;
                string przesuwanie;
                string usuwanie = "0";


                where = znaki.BinarySearch("*");
                
                //Console.WriteLine(where);
                if (where >= 0)
                {
                    znaki.RemoveAt(where);


                    a = Convert.ToInt32(liczby[where]);
                    liczby.RemoveAt(where);

                    b = Convert.ToInt32(liczby[where]);
                    liczby.RemoveAt(where);

                    c = a * b;

                    cs = c.ToString();
                    liczby.Insert(where, cs);
                    //Console.WriteLine(liczby[0]);
                }


                where = znaki.BinarySearch("/");

                //Console.WriteLine(where);
                if (where >= 0)
                {
                    znaki.RemoveAt(where);


                    a = Convert.ToInt32(liczby[where]);
                    liczby.RemoveAt(where);

                    b = Convert.ToInt32(liczby[where]);
                    liczby.RemoveAt(where);

                    c = a / b;

                    cs = c.ToString();
                    liczby.Insert(where, cs);
                    //Console.WriteLine(liczby[0]);
                }

                where = znaki.BinarySearch("+");

                //Console.WriteLine(where);
                if (where >= 0)
                {
                    
                    znaki.RemoveAt(where);
                    

                    a = Convert.ToInt32(liczby[where]);
                    liczby.RemoveAt(where);
                    
                    b = Convert.ToInt32(liczby[where]);
                    liczby.RemoveAt(where);
                   
                    c = a + b;
                   
                    cs = c.ToString();
                    liczby.Insert(where, cs); 
                    //Console.WriteLine(liczby[0]);

                }


                where = znaki.BinarySearch("-");

                //Console.WriteLine(where);
                if (where >= 0)
                {
                    znaki.RemoveAt(where);


                    a = Convert.ToInt32(liczby[where]);
                    liczby.RemoveAt(where);

                    b = Convert.ToInt32(liczby[where]);
                    liczby.RemoveAt(where);

                    c = a - b;

                    cs = c.ToString();
                    liczby.Insert(where, cs);
                    //Console.WriteLine(liczby[0]);
                }

            }

            
        }

        public void wypisywanie()
        {
            Console.WriteLine(liczby[0]);
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
            Kalkutor siema = new Kalkutor();
            siema.literacja();
            siema.liczenie();
            siema.wypisywanie();
        }
    }
}
