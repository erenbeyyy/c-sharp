using System;

namespace BasicCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hoşgeldiniz mesajı
            Console.WriteLine("Hoşgeldiniz!");
            // İlk sayıyı isteme
            Console.WriteLine("İlk sayıyı giriniz:");
            int number1 = Convert.ToInt32(Console.ReadLine());
            // İkinci sayıyı isteme
            Console.WriteLine("İkinci sayıyı giriniz:");
            int number2 = Convert.ToInt32(Console.ReadLine());
            // Sayıların arasına çizgi çekme
            Console.WriteLine("------------------------------");
            // Girdiğiniz sayılar mesajı
            Console.WriteLine("Girdiğiniz sayılar:");
            Console.WriteLine("İlk sayınız = " + number1);
            Console.WriteLine("İkinci sayınız = " + number2);
            // Sayıların arasına çizgi çekme
            Console.WriteLine("------------------------------");
            // Matematiksel işlem başlığı
            Console.WriteLine("//////////////////////////////");
            // Toplama işlemi
            Console.WriteLine("Toplama işlemi = " + number1 + " + " + number2 + " = " + (number1 + number2));
            // Sayıların arasına çizgi çekme
            Console.WriteLine("------------------------------");
            // Çıkarma işlemi
            Console.WriteLine("Çıkarma işlemi = " + number1 + " - " + number2 + " = " + (number1 - number2));
            // Sayıların arasına çizgi çekme
            Console.WriteLine("------------------------------");
            // Çarpma işlemi
            Console.WriteLine("Çarpma işlemi = " + number1 + " x " + number2 + " = " + number1 * number2);
            // Sayıların arasına çizgi çekme
            Console.WriteLine("------------------------------");
            // Bölme işlemi
            if (number2 != 0)
            {
                Console.WriteLine("Bölme işlemi = " + number1 + " / " + number2 + " = " + (number1 / (double)number2));
            }
            else
            {
                Console.WriteLine("Bir sayı sıfıra bölünemez!");
            }
            // Sayıların arasına çizgi çekme
            Console.WriteLine("------------------------------");
            // Programın sonu mesajı
            Console.WriteLine("PROGRAM SONU");
            // Matematiksel işlem başlığı
            Console.WriteLine("//////////////////////////////");
            // Kullanıcının herhangi bir tuşa basmasını bekler
            Console.ReadKey();
        }
    }
}