Console.WriteLine("***** Atama ve İşlemli Atama");

int x = 3;
int y = 4;
y = y+2;
Console.WriteLine(y);

y+=2;
y/=1;
Console.WriteLine(y);

x*=2;
Console.WriteLine(x);

Console.WriteLine("****Mantıksal Operatörler****");
// || && !
bool IsSuccess = true;
bool IsCompleted = false;

if(IsSuccess && IsCompleted)
Console.WriteLine("Perfect!");

if(IsSuccess || IsCompleted)
Console.WriteLine("Great!!");

if(IsSuccess && !IsCompleted)
Console.WriteLine("Fine");

Console.WriteLine("**** İlişkisel Operatörler ****");
// <, >, <=, >=,  ==, !=
int a = 3;
int b = 4;
bool sonuc = a < b;
Console.WriteLine(sonuc);

sonuc a > b;
Console.WriteLine(sonuc);

sonuc a >= b;
Console.WriteLine(sonuc);

sonuc a <= b;
Console.WriteLine(sonuc);

sonuc a == b;
Console.WriteLine(sonuc);

sonuc a != b;
Console.WriteLine(sonuc);

Console.WriteLine("**** Aritmetik Operatörler****");
// / , * , + , - 
int sayi1 = 10;
int sayi2 = 5;
int sonuc1 = sayi1 / sayi2;
Console.WriteLine(sonuc1);

sonuc1 = sayi2 + sayi1;
Console.WriteLine(sonuc1);

sonuc1 = sayi1 * sayi2;
Console.WriteLine(sonuc1);

sonuc1 = sayi2 - sayi2;
Console.WriteLine(sonuc1);
sonuc1= sayi2++;

// % : Mod alır
int sonuc2 = 20%3;
Console.WriteLine(sonuc2);







