using System;

namespace NotOrtalamasiHesaplama
{
    class Program
    {
        static void Main(string[] args)
        {
            // Kullanıcıya Vize notunu sormak için kullanılır.
            Console.Write("Vize Notunuzu Giriniz: ");

            // Kullanıcının girdiği Vize notunu Int16 tipine dönüştürür.
            Int16 vize1 = Convert.ToInt16(Console.ReadLine());

            // Kullanıcının girdiği Vize notunu ekrana yazdırır.
            Console.WriteLine("Vize Notunuz: " + vize1);

            // Vize notunun yüzde 40'ını hesaplar ve ekrana yazdırır.
            Console.WriteLine("Vize yüzde notu: " + vize1 * 0.4);

            // Kullanıcıya Final notunu sormak için kullanılır.
            Console.Write("Final Notunuzu Giriniz: ");

            // Kullanıcının girdiği Final notunu Int16 tipine dönüştürür.
            Int16 final1 = Convert.ToInt16(Console.ReadLine());

            // Kullanıcının girdiği Final notunu ekrana yazdırır.
            Console.WriteLine("Final notunuz: " + final1);

            // Final notunun yüzde 60'ını hesaplar ve ekrana yazdırır.
            Console.WriteLine("Final Yüzde Notunuz: " + final1 * 0.6);

            // Vize notunun yüzde 40'ını hesaplar ve ekrana yazdırır.
            double vize2 = vize1 * 0.4;
            Console.WriteLine("Vize yüzdeniz: " + vize2);

            // Final notunun yüzde 60'ını hesaplar ve ekrana yazdırır.
            double final2 = final1 * 0.6;
            Console.WriteLine("Final yüzdeniz: " + final2);

            // Vize ve Final notlarının ortalamasını hesaplar.
            double basariNotu = vize2 + final2;

            // Başarı notunu ekrana yazdırır.
            Console.WriteLine("Başarı notunuz: " + basariNotu);

            // Başarı notu 60'dan büyükse "Geçti", 50'den büyükse "Şartlı Geçti", aksi halde "Kaldı" yazdırır.
            if (basariNotu >= 60)
            {
                Console.WriteLine("Geçti");
            }
            else if (basariNotu >= 50)
            {
                Console.WriteLine("Şartlı Geçti");
            }
            else
            {
                Console.WriteLine("Kaldı");
            }

            // Kullanıcının bir tuşa basmasını bekler ve programı sonlandırır.
            Console.ReadKey();
        }
    }
}
