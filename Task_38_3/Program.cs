//Задача 38:
//Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива. 
//Не использовать готовые методы Min и Max
//
//[3 7 22 2 78] -> 76


//Ввод параметров массива

Console.Write("Введите количество элементов в массиве: ");

int arrayLength = InputInt();

Console.Write("Введите наименьшее значение диапазона элементов массива: ");

int zeroIndex = InputInt();

Console.Write("Введите наибольшее значение диапазона элементов массива: ");

int pastIndex = InputInt();


if(zeroIndex >= pastIndex || arrayLength < 2)
{
	Console.Write("Диапазон значений элементов массива задан некорректно!");
}


int[] array = GenerateArray(arrayLength, zeroIndex, pastIndex);

Console.WriteLine("Наш массив выглядит следующим образом:");

PrintArray(array);

int minimalNumberInArray = GetMinimalNumberInArray(array);

int maximalNumberInArray = GetMaximalNumberInArray(array);

int result = maximalNumberInArray - minimalNumberInArray;

Console.WriteLine($"Разница между максимальным и минимальным элементами массива равна {result}.");




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


int[] GenerateArray(int arrayLength, int zeroIndex, int pastIndex)
{
    Random random = new Random();

    int[] array = new int[arrayLength];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(zeroIndex, pastIndex + 1);
    }
    return array;
}


//Метод печати массива

void PrintArray(int[] array)
{
    Console.WriteLine($"[{string.Join(", ", array)}]");
}


//Метод нахождения минимального элемента массива:

int GetMinimalNumberInArray (int[] array)
{
    int minNumber = array[0];

    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < minNumber)
        {
            minNumber = array[i];
        }
    }
    return minNumber;
}



//Метод нахождения максимального элемента массива:

int GetMaximalNumberInArray (int[] array)
{
    int maxNumber = array[0];

    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > maxNumber)
        {
            maxNumber = array[i];
        }
    }
    return maxNumber;
}
