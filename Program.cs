string name = Console.ReadLine();
Console.WriteLine("Привет, " + name);

int age = int.Parse(Console.ReadLine());
Console.WriteLine(2024 - age);

//

string name1 = Console.ReadLine();
int phone = int.Parse(Console.ReadLine());
Console.WriteLine("Контакт сохранён." + '\n' + name1 + " - " + phone);

int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
if (a > b)
{
    Console.WriteLine(a);
}
else
{
    Console.WriteLine(b);
}

//

int num = int.Parse(Console.ReadLine());
Console.WriteLine((num / 100) % 10);
Console.WriteLine((num / 10) % 10);
Console.WriteLine(num % 10);