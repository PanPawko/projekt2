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
                    znaki[where] = "0";
                    a = Convert.ToInt32(liczby[where]);
                    liczby[where] = "0";
                    where += 1;
                    b = Convert.ToInt32(liczby[where]);
                    liczby[where] = "0";
                    c = a * b;
                    //Console.WriteLine(c);
                    where -= 1;
                    cs = c.ToString();
                    liczby[where] = cs;
                }
                

                 where = znaki.BinarySearch("/");

                //Console.WriteLine(where);
                if (where >= 0)
                {
                    znaki[where] = "0";
                    a = Convert.ToInt32(liczby[where]);
                    liczby[where] = "0";
                    where += 1;
                    b = Convert.ToInt32(liczby[where]);
                    liczby[where] = "0";
                    c = a / b;
                    //Console.WriteLine(c);
                    where -= 1;
                    cs = c.ToString();
                    liczby[where] = cs;
                }

                where = znaki.BinarySearch("+");

                //Console.WriteLine(where);
                if (where >= 0)
                {
                    int d = where+1;
                    int e;
                    znaki.RemoveAt(where);
                    a = Convert.ToInt32(liczby[where]);
                    liczby.RemoveAt(where);
                    where += 1;
                    b = Convert.ToInt32(liczby[where]);
                    liczby.RemoveAt(where);
                    e = where+1;
                    c = a + b;
                    /*for (int x = 0; x < lenght2 - 1; x++)
                    {

                        przesuwanie = znaki[d];
                        znaki[d] = usuwanie;
                        d -= 1;
                        znaki[d] = przesuwanie;
                        d += 2;

                        //Console.WriteLine(znaki[x]);
                    }
                    for (int x = 0; x < lenght - 3; x++)
                    {

                        przesuwanie = liczby[e];

                        //liczby[e] = usuwanie;
                        e -= 1;
                        znaki[e] = przesuwanie;
                        e += 2;

                        Console.WriteLine(liczby[x]);
                    }*/
                    //Console.WriteLine(c);
                    where -= 1;
                    cs = c.ToString();
                    liczby.Insert(where, cs); 
                    Console.WriteLine(liczby[0]);

                }


                where = znaki.BinarySearch("-");

                //Console.WriteLine(where);
                if (where >= 0)
                {
                    znaki[where] = "0";
                    
                    a = Convert.ToInt32(liczby[where]);
                    liczby[where] = "0";
                    where += 1;
                    b = Convert.ToInt32(liczby[where]);
                    liczby[where] = "0";
                    c = a - b;
                    //Console.WriteLine(c);
                    where -= 1;
                    cs = c.ToString();
                    liczby[where] = cs;
                }
                
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
            Kalkutor siema = new Kalkutor();
            siema.literacja();
            siema.liczenie();
        }
    }
}
