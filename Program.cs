// 57. Написать программу, упорядочивания по убыванию элементы каждой строки двумерной массива.
int[,] FillArray(int m, int n)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
    return array;
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}
int[,] array1 = FillArray(5, 5);
PrintArray(array1);

int[,] OrderArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            int min = j;
            for (int k = 0; k < array.GetLength(1); k++)
            {
                if (array[i, k] < array[i, min])
                {
                    min = k;
                }
                int temp = array[i, j];
                array[i, j] = array[i, min];
                array[i, min] = temp;
            }
        }
    }
    return array;
}
Console.WriteLine();
//array1 = OrderArray(array1);
//PrintArray(array1);
// 58. Написать программу, которая в двумерном массиве заменяет строки на столбцы или сообщить
void Zamena(int[,] array)
{
    // int k = array.GetLength(0);
    // int n = array.GetLength(1);
    // int[,] matrix = new int[n, k];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = i; j < array.GetLength(1); j++)
        {
            int temp = array[i,j];
            array[i,j] =  array[j,i];
            array[j,i] = temp;
            // Console.Write(matrix[j, i] + " ");
        }
        // Console.WriteLine();
    }
    //return array;
}
Console.WriteLine();
Zamena(array1);
PrintArray(array1);




// 59. В прямоугольной матрице найти строку с наименьшей суммой элементов.

int FindMinLine(int[,] array)
{
    int result = 100;
    int index = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            int sum = 0;
            sum = sum + array[i, j];
            if (sum < result)
            {
                index = i;
                result = sum;
            }

        }
    }
    return index+1;
}
//Console.WriteLine(FindMinLine(array1));
// 60. Составить частотный словарь элементов двумерного массива
