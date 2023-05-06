Console.WriteLine("Vize-Final Not Ortalaması");
Console.Write("Vize Notunuzu Giriniz: ");
Int16 vize1 = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Vize Notunuz: " + vize1);
Console.WriteLine("vize yüzde notu: " + vize1 * 0.4);
Console.Write("Final Notunuzu Giriniz: ");
Int16 final1 = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Final notunuz: " + final1);
Console.WriteLine("Final Yüzde Notunuz: " + final1 * 0.6);
double vize2 = vize1 * 0.4;
double final2 = final1 * 0.6;
Console.WriteLine("vize yüzdeniz: " + vize2);
Console.WriteLine("final yüzdeniz: " + final2);
double basariNotu = vize2 + final2;
Console.WriteLine("başarı notunuz: " + basariNotu);
if (basariNotu >= 60)
{
    Console.WriteLine("geçti");
}
else if (basariNotu >= 50)
{
    Console.WriteLine("şartlı geçti");
}
else
{
    Console.WriteLine("kaldı");
}


Console.ReadKey();