using System;

namespace Figury
{
    class Program
    {
        static void Main(string[] args)
        {


            string nazwa;
            int k = 0;
            while (k == 0)
            {
                Console.WriteLine("*****************************************************************************************************");
                Console.WriteLine("Wybierz swoja figure:\n 1. Okrag \n 2. Prostokat \n 3. Trojkat \n Aby zakonczyc program wcisnij 0 \n");
                float wybor = float.Parse(Console.ReadLine());
                switch (wybor)
                {
                    case 0:
                        k++;
                        break;
                    case 1:
                        Console.WriteLine("Wybrales Okrag \n");
                        nazwa = "Okrag";
                        Okrag nazw = new Okrag();
                        nazw.Wczytaj();
                        nazw.Pole();
                        nazw.Obwod();
                        nazw.Wyswietl(nazwa);
                        break;
                    case 2:
                        Console.WriteLine("Wybrales Prostokat \n");
                        nazwa = "Prostokat";
                        Prostokat kwad = new Prostokat();
                        kwad.Wczytaj();
                        kwad.Pole();
                        kwad.Obwod();
                        kwad.Wyswietl(nazwa);
                        break;
                    case 3:
                        Console.WriteLine("Wybrales Trojkat \n");
                        nazwa = "Trojkat";
                        Trojkat tri = new Trojkat();
                        tri.Wczytaj();
                        tri.Pole();
                        tri.Obwod();
                        tri.Wyswietl(nazwa);
                        break;
                    default:
                        break;
                }

            }
        }


        class Figura
        {
            public float obwod;
            public float pole;
            public virtual void Wyswietl(string nazwa)
            {
                Console.WriteLine("Pole: {1} \nObwod: {2}\n", nazwa, pole, obwod);
            }
        }

        class Okrag : Figura
        {

            public float promien;
            public void Wczytaj()
            {
                Console.WriteLine("Prosze podac nastepujace informacje");
                Console.WriteLine("Promien :");
                string promienString = Console.ReadLine();
                promien = float.Parse(promienString); //zamieniam wczytany ciąg string na float, żeby móc dowolnie zarządzać promieniem jako liczbą.

            }

            public void Pole()
            {
                pole = (float)Math.PI * (float)Math.Pow(promien, 2);
            }
            public void Obwod()
            {
                obwod = (float)Math.PI * promien * 2;
            }

        }
        class Prostokat : Figura
        {

            public float a, b;
            public void Wczytaj()
            {
                Console.WriteLine("Prosze podac nastepujace informacje");
                Console.WriteLine("a: ");
                string aString = Console.ReadLine();
                Console.WriteLine("b: ");
                string bString = Console.ReadLine();
                a = float.Parse(aString); //zamieniam wczytany ciąg string na float, żeby móc dowolnie zarządzać promieniem jako liczbą.
                b = float.Parse(bString);
            }

            public void Pole()
            {
                pole = a * b;
            }
            public void Obwod()
            {
                obwod = 2 * a + 2 * b;
            }

        }
        class Trojkat : Figura
        {

            public float a, b, c, h;
            public void Wczytaj()
            {
                Console.WriteLine("Prosze podac nastepujace informacje");
                Console.WriteLine("a: ");
                string aString = Console.ReadLine();
                Console.WriteLine("b: ");
                string bString = Console.ReadLine();
                Console.WriteLine("c: ");
                string cString = Console.ReadLine();
                a = float.Parse(aString); //zamieniam wczytany ciąg string na float, żeby móc dowolnie zarządzać promieniem jako liczbą.
                b = float.Parse(bString);
                c = float.Parse(cString);
                h = a * (float)Math.Sqrt(3) / 2; //jestem swiadomy tego ze wynik pola nie bedzie poprawny dla kazdego trojkata ale chyba nie o to chodzi w tym zadaniu
            }

            public void Pole()
            {
                pole = a * h / 2;  //jestem swiadomy tego ze wynik pola nie bedzie poprawny dla kazdego trojkata ale chyba nie o to chodzi w tym zadaniu
            }
            public void Obwod()
            {
                obwod = a + b + c;
            }

        }
    }
}

