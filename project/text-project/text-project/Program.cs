int ilkSayi;
int ikinciSayi;
Console.Write("ilk sayıyı giriniz: ");
ilkSayi = Convert.ToInt16(Console.ReadLine());
Console.Write("İkinci sayıyı giriniz: ");
ikinciSayi = Convert.ToInt16(Console.ReadLine());
if (ilkSayi < ikinciSayi)
{
    Console.WriteLine("ilk sayı ikinci sayıdan küçük, program artarak devam edecek");
    for (int i = ilkSayi ; i < ikinciSayi; i += 2)
    {
        if (i%2==0)
        {
            Console.WriteLine(i);
        }
    }
}
else if(ilkSayi>ikinciSayi)
{
    Console.WriteLine("ilk sayı ikinci sayıdan küçük değil, program azalarak devam edecek");
    for (int x = ilkSayi -1 ; x > ikinciSayi; x -= 2)
    {
        if (x % 2 == 0)
        {
            Console.WriteLine(x);
        }
    }
}
