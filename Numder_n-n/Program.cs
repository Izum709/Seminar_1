
Console.WriteLine("Введите число ");
int a = int.Parse(Console.ReadLine());
int min = -a;
while (min <= a)
{
    Console.Write($"{min} ");
    min++;
}

