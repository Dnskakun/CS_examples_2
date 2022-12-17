Console.WriteLine("Программа, показывающая все четные числа, находящиеся до введенного числа");
Console.Write("Введите целое положительное число больше или равное 2: ");
int userInput = int.Parse(Console.ReadLine() ?? "");

int count = 1;

Console.Write($"Все четные числа до числа {userInput}: ");

while (count < userInput - 1)
{
    if (count%2 == 0)
    {
        Console.Write($"{count}, ");
    }
    count++;
}
while (count <= userInput)
    {
      if (count%2 == 0)
      {
        Console.WriteLine($"{count}.");
      }
      count++;
    }
    
if (userInput < 2)
{
    Console.WriteLine("вы ввели число меньше 2, попробуйте заново.");
}