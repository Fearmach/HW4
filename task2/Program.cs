// Написать программу, которая принимает на вход число и выдает сумму цифр в числе (452 - 11)

int InputNumber(string str)
 {
     int number;
     string text;
     while(true)
     {
         System.Console.WriteLine(str);
         text = Console.ReadLine();
         if (int.TryParse(text, out number))
         {
             break;
         }
         System.Console.WriteLine("Введено не корректное число, попробуйте еще раз!");
     }
     return number;
}

int number = ReadInt("Введите число: ");
int length = NumberLength(number);
SumNumbers(number, length);

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
int NumberLength(int a)
{
    int index = 0;
    while (a > 0)
    {
        a /= 10;
        index++;
    }
    return index;
}

void SumNumbers(int n, int len)
{
    int sum = 0;
    for (int i = 1; i <= length; i++)
    {
        sum += n % 10;
        n /= 10;
    }
    Console.WriteLine(sum);
}

