//int i = 1;
//while (i != 100)
//{
//    if (i % 5 == 0 && i % 3 == 0)
//        Console.WriteLine("fizz buzz");
//    else if (i % 3 == 0)
//        Console.WriteLine("buzz");
//    else if (i % 5 == 0)
//        Console.WriteLine("fizz");
//    else
//        Console.WriteLine(i);
//    i++;
//}


//int sayi1 = 12;
//int sayi2 = 4;
//double ondalik1 = 4.00;
//string text1 = "HackerRank ";
//string text2 = "is  the best place to learn and practice coding!";
//Console.WriteLine(sayi1 + sayi2);
////Convert.ToDouble( Console.WriteLine(ondalik1 + ondalik1);
//Console.WriteLine(text1 + text2);

// Declare second integer, double, and String variables.
string s = "yazı";
int i = 12;
double d = 4.0;
int i2 = 0;
double d2 = 0.0;
string s2 = "";

// Read and save an integer, double, and String to your variables.
i2 = Convert.ToInt32(Console.ReadLine());
d2 = Convert.ToDouble(Console.ReadLine());
s2 = Console.ReadLine();

// Print the sum of both integer variables on a new line.
Console.WriteLine(i + i2);

// Print the sum of both double variables on a new line.
Console.WriteLine($"{(d + d2):F1}");

// Concatenate and print the String variables on a new line
// The 's' variable above should be printed first.
Console.WriteLine(s + s2);
