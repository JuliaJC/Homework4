// Напишите программу, которая задаёт массив из N элементов 
//и выводит их на экран. Вывод сделать отдельным методом.
//5 -> [1, 2, 5, 7, 19]
//3 -> [6, 1, 33]

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

int [] numbers = new int [size];

for(int i = 0; i < numbers.Length; i++)
{
    numbers[i] = new Random().Next(0, 10);
}

WriteArray(numbers);

void WriteArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
    Console.Write(array[i] + " ");
    }
}
