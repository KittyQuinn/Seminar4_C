// Принимает число А и выдает сумму чисел от 1 до А
// 7 -> 28
// 4 -> 10

Console.Clear();
Console.WriteLine("Type a number ");
int A = int.Parse(Console.ReadLine());

int i;
int result = 0;
for (i = 1; i <= A; i++)
{
    result = result+i;
}


Console.WriteLine(result);
