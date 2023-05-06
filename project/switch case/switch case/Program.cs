int sayi = Convert.ToInt16(Console.ReadLine());

switch (sayi)
{
    case 1:
        Console.WriteLine("Sayı 1'e eşittir.");
        break;
    case 2:
        Console.WriteLine("Sayı 2'ye eşittir.");
        break;
    case 3:
        Console.WriteLine("Sayı 3'e eşittir.");
        break;
    default:
        Console.WriteLine("Belirtilen koşullar sağlanmadı.");
        break;
}
Console.ReadLine();