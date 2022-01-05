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
                string cs;
                
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
                    znaki[where] = "0";
                    a = Convert.ToInt32(liczby[where]);
                    liczby[where] = "0";
                    where += 1;
                    b = Convert.ToInt32(liczby[where]);
                    liczby[where] = "0";
                    c = a + b;
                    for(int x = 0;x<=lenght2-(where+1);x++)
                    {
                        //Console.WriteLine(znaki[x]);
                    }
                    //Console.WriteLine(c);
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
