Console.WriteLine("Boyunuzu şu şekilde giriniz: örn: 1.75");
double boy = Convert.ToDouble(Console.ReadLine()); //boyun karesi alınıyor
Console.WriteLine("Kilonuzu giriniz:");
double kilo = Convert.ToDouble(Console.ReadLine());
double endeks = kilo / (boy * boy);
Console.WriteLine(endeks);
if (endeks < 18.49)
    Console.WriteLine("İdeal kilonun altında");
else if (endeks > 18.49 && endeks < 25)
    Console.WriteLine("İdeal kilo");
else if (endeks > 25 && endeks < 30)
    Console.WriteLine("İdeal kilonun üzeri");
else if (endeks > 30)
    Console.WriteLine("İdeal kilonun çok üzeri");
else
    Console.WriteLine("Geçersiz değer girdiniz!");
