using System;

namespace FiguryIntefejsy
{
    class Program
    {
        static void Main(string[] args)
        {


            string nazwa;
            Figura[] s = { new Okrag(), new Prostokat(), new Okrag(), new Szesciokat(), new Elipsa() };
            int k = 0;
            int n;
            while (k == 0)
            {
                Console.WriteLine("*****************************************************************************************************");
                Console.WriteLine("Wybierz swoja figure:\n 1. Okrag \n 2. Prostokat \n 3. Trojkat \n 4. Szesciokat \n 5. Elipsa \n Aby zakonczyc program wcisnij 0 \n");
                float wybor = float.Parse(Console.ReadLine());
                switch (wybor)
                {
                    case 0:
                        k++;
                        break;
                    case 1:
                        nazwa = "Okrag";
                        n = 0;
                        if (s[n] is IWierzch)
                        {
                            Console.WriteLine("-> wierzcholki: {0}", ((IWierzch)s[n]).Wierzcholki);
                        }
                        else
                        {
                            Console.WriteLine("-> {0} nie ma wierzcholkow!", s[n].nazwa);
                        }
                        break;
                    case 2:
                        nazwa = "Kwadrat";
                        n = 1;
                        if (s[n] is IWierzch)
                        {
                            Console.WriteLine("-> wierzcholki: {0}", ((IWierzch)s[n]).Wierzcholki);
                        }
                        else
                        {
                            Console.WriteLine("-> {0} nie ma wierzcholkow!", s[n].nazwa);
                        }
                        break;
                    case 3:
                        nazwa = "Trojkat";
                        n = 2;
                        if (s[n] is IWierzch)
                        {
                            Console.WriteLine("-> wierzcholki: {0}", ((IWierzch)s[n]).Wierzcholki);
                        }
                        else
                        {
                            Console.WriteLine("-> {0} nie ma wierzcholkow!", s[n].nazwa);
                        }
                        break;
                    case 4:
                        nazwa = "Szesciokat";
                        n = 3;
                        if (s[n] is IWierzch)
                        {
                            Console.WriteLine("-> wierzcholki: {0}", ((IWierzch)s[n]).Wierzcholki);
                        }
                        else
                        {
                            Console.WriteLine("-> {0} nie ma wierzcholkow!", s[n].nazwa);
                        }
                        break;
                    case 5:
                        nazwa = "Elipsa";
                        n = 4;
                        if (s[n] is IWierzch)
                        {
                            Console.WriteLine("-> wierzcholki: {0}", ((IWierzch)s[n]).Wierzcholki);
                        }
                        else
                        {
                            Console.WriteLine("-> {0} nie ma wierzcholkow!", s[n].nazwa);
                        }
                        break;
                    default:
                        break;
                }

            }
        }

        public interface IWierzch
        {
            byte Wierzcholki { get;}
        }
        abstract public class Figura
        {
            public string nazwa;               
        }

        class Okrag : Figura
        {
            public Okrag() { }
            
        }
        class Prostokat : Figura, IWierzch
        {

            public byte Wierzcholki
            {
                get { return 4; }
            }

        }
        class Trojkat : Figura, IWierzch
        {

            public byte Wierzcholki
            {
                get { return 3; }
            }

        }
        class Szesciokat : Figura, IWierzch
        {


            public byte Wierzcholki
            {
                get { return 6; }
            }
        }
        class Elipsa : Figura
        {


           
        }

    }
}

//Wnioski 
/*
 * 
 * Interfejs może nam służyć do wyświetlania/pobierania danych do i z roznych klas, ktore sa np pochodnymi tej samej bądź różnych klas i nie mamy za bardzo innej opcji 
 * żeby je ze sobą porownac
 * tworzymy jeden interfejs i mozemy go 'podpiac' do kazdej klasy i pochodnej przez co mamy mniej linijek kodu do napisania
 * Na co moge ponarzekać to w sumie to że trzeba wtedy w kazdej klasie zaimplementować wartość zwracaną do tego interfejsu
 * 
 */