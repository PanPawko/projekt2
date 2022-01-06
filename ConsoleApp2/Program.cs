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

        void wypełnianie()
        {
            for(int i = 0;i<liczby.Length; i++)
            {
                liczby[i] = "0";
            }

            for (int i = 0; i < znaki.Length; i++)
            {
                znaki[i] = "0";
            }
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
            int lenght = wyrażenie.Length;
            int lenght2 = znaki.Length;

            for(int i = 0;i<lenght2; i++)
            {
                int where;
                int a;
                int b;
                int c;
                string cs;
                string przesuwanie;
                string usuwanie = "0";


                 where = Array.IndexOf(znaki, "*");
                
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
                

                 where = Array.IndexOf(znaki, "/");
                
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

                where = Array.IndexOf(znaki, "+");
                
                //Console.WriteLine(where);
                if (where >= 0)
                {
                    int d = where;
                    int e;
                    znaki[where] = "0";
                    a = Convert.ToInt32(liczby[where]);
                    liczby[where] = "0";
                    where += 1;
                    b = Convert.ToInt32(liczby[where]);
                    liczby[where] = "0";
                    e = where+1;
                    c = a + b;
                    for(int x = 0;x<lenght2-1;x++)
                    {
                        d += 1;
                        przesuwanie = znaki[d];
                        znaki[d] = usuwanie;
                        where -= 1;
                        znaki[d] = przesuwanie;
                        where += 2;

                        Console.WriteLine(znaki[x]);
                    }
                    for(int x = 0;x<lenght-3; x++)
                    {
                        
                        przesuwanie = liczby[e];
                        liczby[e] = usuwanie;
                        e -= 1;
                        znaki[e] = przesuwanie;
                        e += 2;

                        Console.WriteLine(liczby[x]);
                    }
                    Console.WriteLine(c);
                    where -= 1;
                    cs = c.ToString();
                    liczby[where] = cs;
                }
                
                
                where = Array.IndexOf(znaki, "-");
                
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
            kalkutor siema = new kalkutor();
            siema.literacja();
            siema.liczenie();
        }
    }
}
