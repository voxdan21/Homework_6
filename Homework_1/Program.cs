// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

//ввод цифр и запись их в массив
int[] InputNumbers(int quantityNumber)
{
    int[] massiveNumbers = new int[quantityNumber];
    for (int i = 0; i < quantityNumber; i++)
    {
        Console.Write($"Введи {i + 1} число: ");
        massiveNumbers[i] = Convert.ToInt32(Console.ReadLine());
    }
    return massiveNumbers;
}

//вывод массива
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i == array.Length - 1)
        {
            Console.Write($"{array[i]}");
        }
        else
        {
            Console.Write($"{array[i]}, ");
        }
    }
}

int NumbersMorethanZero(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    return count;
}


try
{
    Console.Write($"Введи число М(количество чисел): ");
    int x = Convert.ToInt32(Console.ReadLine());
    int[] Numbers = InputNumbers(x);
    Console.Write($"Наш массив: ");
    PrintArray(Numbers);
    int result = NumbersMorethanZero(Numbers);
    Console.WriteLine("");
    Console.WriteLine($"Ввведено чисел больше 0 : {result} ");
}
catch
{
    Console.Write("Ошибка: не верно введены данные.");
}