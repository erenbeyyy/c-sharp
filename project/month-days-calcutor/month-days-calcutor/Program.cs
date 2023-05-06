using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Lütfen bir ay numarası girin (1-12): ");
        int ay = int.Parse(Console.ReadLine());

        switch (ay)
        {
            case 1:
                Console.WriteLine("Ocak 31 gün.");
                break;
            case 2:
                Console.WriteLine("Şubat yıla bağlı olarak 28 ya da 29 gün çeker.");
                break;
            case 3:
                Console.WriteLine("Mart 31 gün.");
                break;
            case 4:
                Console.WriteLine("Nisan 30 gün.");
                break;
            case 5:
                Console.WriteLine("Mayıs 31 gün.");
                break;
            case 6:
                Console.WriteLine("Haziran 30 gün.");
                break;
            case 7:
                Console.WriteLine("Temmuz 31 gün.");
                break;
            case 8:
                Console.WriteLine("Ağustos 31 gün.");
                break;
            case 9:
                Console.WriteLine("Eylül 30 gün.");
                break;
            case 10:
                Console.WriteLine("Ekim 31 gün.");
                break;
            case 11:
                Console.WriteLine("Kasım 30 gün.");
                break;
            case 12:
                Console.WriteLine("Aralık 31 gün.");
                break;
            default:
                Console.WriteLine("Geçersiz ay numarası.");
                break;
        }
    }
}