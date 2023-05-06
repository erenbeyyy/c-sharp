Console.WriteLine("Boyunuzu şu şekilde giriniz: örn: 1.75");
double boy = Convert.ToDouble(Console.ReadLine().Replace(',', '.')); // virgül yerine nokta kullanımını desteklemek için düzenleme yapıldı
Console.WriteLine("Kilonuzu giriniz:");
double kilo = Convert.ToDouble(Console.ReadLine());

if (boy <= 0 || kilo <= 0) // boy veya kilo negatif veya sıfıra eşit ise hata mesajı verilir
{
    Console.WriteLine("Hatalı giriş yaptınız! Boy ve kilo geçerli bir sayı olmalıdır.");
}
else // boy ve kilo pozitif sayı ise endeks hesaplanır ve sonuç yazdırılır
{
    double endeks = kilo / (boy * boy);
    Console.WriteLine($"Beden Kitle Endeksiniz: {endeks:F2}"); // endeksin değeri 2 ondalık basamakla yazdırıldı

    if (endeks < 18.49)
        Console.WriteLine("İdeal kilonun altında.");
    else if (endeks > 18.49 && endeks < 25)
        Console.WriteLine("İdeal kilo.");
    else if (endeks > 25 && endeks < 30)
        Console.WriteLine("İdeal kilonun üzerinde.");
    else if (endeks > 30)
        Console.WriteLine("İdeal kilonun çok üzerinde.");
    else
        Console.WriteLine("Geçersiz değer girdiniz!");
}