Console.WriteLine("Введите число: ");
string stringNumber = Console.ReadLine();

int sum = 0;

for (int i = 0; i < stringNumber.Length; i++)
{
    string digit = Convert.ToString(stringNumber[i]);
    sum += Convert.ToInt32(digit);
}

Console.WriteLine("Сумма цифр в числе = "+ sum);