using System;

namespace basariNotu
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Vize Notunuzu Giriniz (0-100 aralığında): ");
                int vize = Convert.ToInt32(Console.ReadLine());

                if (vize < 0 || vize > 100)
                {
                    throw new Exception("Girilen değer 0-100 aralığında değil!");
                }

                Console.Write("Final Notunuzu Giriniz (0-100 aralığında): ");
                int final = Convert.ToInt32(Console.ReadLine());

                if (final < 0 || final > 100)
                {
                    throw new Exception("Girilen değer 0-100 aralığında değil!");
                }

                double ortalama = (vize * 0.4) + (final * 0.6);
                Console.WriteLine("Ortalamanız: " + ortalama);

                if (ortalama >= 60)
                {
                    Console.WriteLine("Tebrikler, dersi başarıyla geçtiniz!");
                }
                else if (ortalama >= 50)
                {
                    Console.WriteLine("Dersi şartlı olarak geçtiniz.");
                }
                else
                {
                    Console.WriteLine("Dersi maalesef geçemediniz.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata: " + ex.Message);
            }

            Console.WriteLine("Programı kapatmak için bir tuşa basın...");
            Console.ReadKey();
        }
    }
}