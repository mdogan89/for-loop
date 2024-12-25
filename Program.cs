// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");



Console.WriteLine("Lütfen bir sayı giriniz");
int sayac = int.Parse(Console.ReadLine());
for (int i = 0; i <= sayac; i++)
{
    if(i%2 == 1) {  Console.WriteLine(i); }
}


int tekTop = 0;
int ciftTop = 0;

for (int i = 0;i <= 1000; i++)
{
    if (i%2 == 1) { tekTop += i; }
    else { ciftTop += i; }
}
Console.WriteLine("Tek toplam: " + tekTop);
Console.WriteLine("Cift toplam: " + ciftTop);

for (int i = 0;i<10 ; i++)
{
    if(i == 4)
    {
        break;
    }
    Console.WriteLine(i);
}
for (int i = 0; i < 10; i++)
{
    if (i == 4)
    {
        continue;
    }
    Console.WriteLine(i);
}
