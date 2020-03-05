using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Niezbednik
{
    class niezbednik
    {
        public static int Silnia(int n)
        {
            int result = 1;
            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }

        public static int Silownia(int n)
        {
            int wynik = 0;
            try
            {
                checked
                {
                    int result = 1;
                    for (int i = 1; i <= n; i++)
                    {
                        result *= i;
                    } wynik = result;
                }
            }
            catch (System.OverflowException)
            {
                Console.WriteLine("Za duza wartosc silni");
            }
            return wynik;

        }

        public static int wieksza(int a, int b)
        {
            if (a>b){
                return a;
            }
            else{
                return b;
            }
        }
        public static int zamien(ref int a, ref int b)
        {
            int zbiornik1 = a;
            int zbiornik2 = b;
            a = zbiornik2;
            b = zbiornik1;
            Console.WriteLine("a = {0}   b= {1}", a, b);
            return 0;
        }

        public static bool Sil(int n, out int wyn)
        {
            bool ok = true;
            wyn = 1;
            try
            {
                checked
                {
                    for (int i = 2; i <= n; i++)
                    {
                        wyn *= i;
                    }
                }
            }
            catch (Exception)
            {
                ok = false;
                wyn = 0;
            }
            return ok;
        }
    }
    
       
   
}
