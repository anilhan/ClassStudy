using System;

namespace ClassStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Yapılacak İşlemi Seçin(topla,cikar,carp,bol) ");
            string islem = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Birinci Sayıyı girin = ");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("İkinci Sayıyı Girin = ");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            if (islem == "topla")
            {
                Console.WriteLine("Sayıların toplamı = " + topla(sayi1, sayi2));
            }

            else if(islem == "cikar")
            {
                Console.WriteLine("Sayıların Farkı = " + cikar(sayi1, sayi2));
            }

            else if(islem == "carp")
            {
                Console.WriteLine("Sayılar Çarpımı = " + carp(sayi1, sayi2));
            }
            else if(islem == "bol")
            {
                if (sayi2 == 0)
                {
                    Console.WriteLine("Bölen 0 olamaz");
                }
                else
                {
                    Console.WriteLine("Sayıların Bölümü = " + (bol(sayi1, sayi2)));
                }

            }
        }

        static int topla(int a, int b)
        {
            return a + b;
        }
        static int cikar(int a, int b)
        {
            return a - b;
        }
        static int carp(int a, int b)
        {
            return a * b;
        }
        static int bol(int a, int b)
        {
            return a / b;
        }
    }
}
