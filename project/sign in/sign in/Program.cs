string dogruKullaniciAdi = "admin";
string dogruSifre = "1234";

while (true)
{
    Console.WriteLine("--------Admin Panele Hoşgeldiniz--------");
    Console.WriteLine("Kullanıcı Adınızı Giriniz:");
    string alinanK = Console.ReadLine(); // kullanıcı adı terminalden alınır
    Console.WriteLine("Şifreyi Giriniz:");
    string alinanSifre = Console.ReadLine(); // şifre terminalden alınır
    Console.WriteLine("--------------------------------");

    if (alinanK == dogruKullaniciAdi && alinanSifre == dogruSifre)
    {
        Console.WriteLine("Kullanıcı bilgileriniz doğru, sisteme girişinize izin verilmiştir!");
        break;
    }
    else
    {
        Console.WriteLine("Kullanıcı adı veya şifre yanlış. Lütfen tekrar deneyin.");
    }
}
Console.ReadKey();