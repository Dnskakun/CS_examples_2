Console.Write("Введите первое целое число: ");
string a = Console.ReadLine() ?? "";
Console.Write("Введите второе целое число: ");
string b = Console.ReadLine() ?? "";

if (int.Parse(a)>int.Parse(b)) //как лучше сделать: добавить две переменные (например, int number1 = int.Parse(a)) или можно сделать сразу в условии цикла метод Parse?
{
    Console.Write($"max={a}, min={b}");
}
else
{
    Console.Write($"max={b}, min={a}");
}