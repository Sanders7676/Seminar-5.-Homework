//Задача 34:
//Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//
//[345, 897, 568, 234] -> 2




Console.Write("Введите количество элементов в массиве: ");

int arrayLength = InputInt();

int[] initialArray = GenerateArray(arrayLength);

Console.WriteLine("Наш массив выглядит следующим образом:");

PrintArray(initialArray);

int quantityEvenNumbers = GetQuantityEvenNumbersInArray(initialArray);

Console.WriteLine($"Сумма четных элементов в массиве равна {quantityEvenNumbers}.");


// Метод для приема чисел, вводимых через консоль

int InputInt()
{
    bool isNum = int.TryParse(Console.ReadLine(), out int num);
    if (isNum)
    {
        return num;
    }
    else
    {
        Console.WriteLine("Введено некорректное значение.");
        return -1;
    }
}


// Метод формирования массива


int[] GenerateArray(int arrayLength)
{
    Random random = new Random();

    int[] array = new int[arrayLength];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(100, 1000);
    }
    return array;
}



// Метод подсчета количества четных элементов в массиве


int GetQuantityEvenNumbersInArray(int[] array)
{
    int quantity = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            quantity += array[i];
        }
    }
    return quantity;
}



//Метод печати массива

void PrintArray(int[] array)
{
    Console.WriteLine($"[{string.Join(", ", initialArray)}]");
}
