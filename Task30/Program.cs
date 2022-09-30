// Выводит массив из 8 элементов заполненный 0 и 1
// в случайном порядке


int [] arr = new int [8];

for (int i=0; i<arr.Length; i++)
{
    arr[i] = new Random().Next(0,2);
    Console.WriteLine(arr[i]);
}

