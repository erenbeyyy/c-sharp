// Kullanıcıdan istenecek Fibonacci sayıları adedi
Console.Write("Kaç tane Fibonacci sayısı hesaplamak istersiniz? ");

// Kullanıcının girdiği sayıyı n değişkeninde sakla
int n = Convert.ToInt32(Console.ReadLine());

// İlk iki Fibonacci sayısı
int a = 0;
int b = 1;

// n adet Fibonacci sayısını hesapla ve ekrana yazdır
for (int i = 0; i < n; i++)
{
    // i. Fibonacci sayısını ekrana yazdır
    Console.Write(a + " ");

    // a değişkenine b değişkeninin değerini ata
    int temp = a;
    a = b;

    // b değişkenine önceki iki sayının toplamını ata
    b = temp + b;
}

// Programın kapanması için bekleme yap
Console.ReadLine();