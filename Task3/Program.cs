Console.WriteLine("Проверка числа на четность");
Console.Write("Введите целое число: ");
int userInput = int.Parse(Console.ReadLine() ?? "");

if (userInput%2 == 0)
{
    Console.WriteLine($"Введенное число {userInput} является четным числом.");
}
else
{
    Console.WriteLine($"Введенное число {userInput} является нечетным числом");
}