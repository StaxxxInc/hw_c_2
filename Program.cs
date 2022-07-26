//Написать программу, которая на вход принимает два числа
//и выдает какое число больше

//Пользователь вводит 2 числа a и b
Console.Write("Введите a ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите b ");
int b = Convert.ToInt32(Console.ReadLine());

//сравниваем 2 часла
    if (a > b)
    {
    Console.WriteLine($"Больше a");
    }

    else
    {
    Console.WriteLine($"Больше b ");
    }

