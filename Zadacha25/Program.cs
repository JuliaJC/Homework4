/*Напишите цикл, который принимает на вход два числа (A и B) 
и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

Console.WriteLine("Введите число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());

int result = 1;

for(int i = 0; i < numberB; i++)
{ 
    result *= numberA; 
}

Console.WriteLine(numberA + " в степени " + numberB + " = " + result);


/*int[] numbers = {3, 4, 5, 6, 8};
for (int i = 0; i < numbers.Length; i++)
{
    Console.Write(numbers[i] + " ");
}*/

/*int[] numbers = {3, 4, 5, 6, 8};
numbers[0] = 90;
Console.Write(numbers[0]);*/

//int[] numbers = new int[5] {3, 4, 5, 6, 8};

/*Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int sum = 0;

for (int i = 1; i <= number; i++)
{
    sum += i;
}

Console.WriteLine($"Сумма равна {sum}");*/



