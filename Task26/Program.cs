// Принимает число и выдает кол-во цифр в числе

Console.Clear();
Console.WriteLine("Type a number ");
int num = int.Parse(Console.ReadLine());

string A = Convert.ToString(num);

Console.WriteLine(A.Length);