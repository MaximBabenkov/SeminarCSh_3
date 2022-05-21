// Найти произведение чисел от 1 до a
Console.Write("Enter your number: ");
int a = int.Parse(Console.ReadLine()??"0");
int prod = 1;
for (int i=1;i<=a;i++)
{
    prod = prod*i;    
}
Console.Write($"The product of numbers from 1 to {a}: {prod}");
