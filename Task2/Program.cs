Console.Write("Введите первое целое число: ");
int userInput1 = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите второе целое число: ");
int userInput2 = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите третье целое число: ");
int userInput3 = int.Parse(Console.ReadLine() ?? "");

int max = userInput1;

if(userInput2 > max)
{
    max = userInput2;
}
else
{
    if(userInput3 > max)
    {
        max = userInput3;
    }
}

Console.WriteLine($"Максимальным из введенных чисел является число {max}");
