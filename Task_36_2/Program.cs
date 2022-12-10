//Задача 36:
//Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных индексах.
//
//[3, 7, 23, 12] -> 19
//
//[-4, -6, 89, 6] -> 0



int[] array = GenerateArray(-10, 10, 12);

PrintArray(array);

int SumOfElementsWithOddIndex = GetSumOfElementsWithOddIndex(array);

Console.WriteLine($"Сумма элементов массива, имеющих нечетный индекс, равна {SumOfElementsWithOddIndex}.");


// Метод формирования массива

int[] GenerateArray(int min, int max, int length)
{
    Random random = new Random();

    int[] array = new int[length];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(min, max + 1);
    }

    return array;
}


// Метод подсчета суммы элементов массива с нечетным индексом

int GetSumOfElementsWithOddIndex(int[] array)
{
    int sum = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)
        {
            sum += array[i];
        }
    }
    return sum;
}


//Метод печати массива

void PrintArray(int[] array)
{
    Console.WriteLine($"[{string.Join(", ", array)}]");
}
