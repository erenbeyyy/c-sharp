Console.WriteLine("Hoşgeldiniz!");
Console.WriteLine("ilk sayıyı giriniz!"); // ilk sayı alınıyor
int number1 = Convert.ToInt32(Console.ReadLine()); // buradaki değişkene eşitleniyor
Console.WriteLine("ikinci sayıyı giriniz");
int number2 = Convert.ToInt32(Console.ReadLine()); // buradaki değişkene eşitleniyor


Console.WriteLine("------------------------------");
Console.WriteLine("sayılarımız");
Console.WriteLine("ilk sayımız = " + number1);
Console.WriteLine("ikinci sayımız = " + number2);
Console.WriteLine("------------------------------");
Console.WriteLine("toplama işlemi = " + number1 + " + " + number2 + " = " + (number1 + number2));
Console.WriteLine("-----------------");
Console.WriteLine("çıkarma işlemi = " + number1 + " - " + number2 + " = " + (number1 - number2));
Console.WriteLine("-----------------");
Console.WriteLine("çarpma işlemi = " + number1 + " x " + number2 + " = " + number1 * number2);
Console.WriteLine("-----------------");
Console.WriteLine("bölme işlemi = " + number1 + " / " + number2 + " = " + number1 / number2);
Console.WriteLine("PROGRAM SONU");
Console.WriteLine("------------------------------");
Console.ReadKey();