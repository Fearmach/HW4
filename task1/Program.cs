// Написать цикл, который принимает на вход два числа (А, B) и возводит число А в натуральную степень B ( 3, 5 - 243(3(5)), 2, 4 - 16) 

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


int A = InputNumber("Введите 1 число: ");
int B = InputNumber("Введите 2 число: ");

System.Console.WriteLine($"{Math.Pow(A,B)}");

