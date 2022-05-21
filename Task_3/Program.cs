// Определить количество цифр в числе
Console.Write("Enter your number: ");
int a = int.Parse(Console.ReadLine()??"0");
int i = 0;
while (a>0)
{
    a=a/10;
    i++;
}
Console.Write($"The quantity of digits: {i}");
