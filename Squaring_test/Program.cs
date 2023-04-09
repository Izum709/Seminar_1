Console.WriteLine("введи число для проверки");
int squaringNumber = int.Parse(Console.ReadLine());
Console.WriteLine("введи проверяемое число число ");
int number = int.Parse(Console.ReadLine());
if (squaringNumber == number *number)
{
    Console.WriteLine("Тыж мщй програмист! Молодец!");
}
else 
{
    Console.WriteLine("Попробуй еще раз, лошара!");
}