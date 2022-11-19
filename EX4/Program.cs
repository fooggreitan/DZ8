// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Например, задан массив размером 2 x 2 x 2.
// Результат:
// 66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
// 34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)

int[] CreateRndArray(int rowss, int columnss, int size)
{
    int[] array = new int[rowss * columnss * size];
    var rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(1, 10);
        if (i >= 1)
        {
            for (int j = 0; j < i; j++)
            {
                while (array[i] == array[j])
                {
                    array[i] = rnd.Next(20, 30);
                }
            }
        }
    }
    return array;
}

int[,,] CreateMatrixRndInt(int rowss, int columnss, int size)
{
    var matrix = new int[rowss, columnss, size];
    int[] array = CreateRndArray(rowss, columnss, size);

    int count = 0;

    var rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int z = 0; z < matrix.GetLength(2); z++)
            {
                matrix[i,j,z] = array[count];
                count++;
            }
        }
    }
    return matrix;
}

void PrintMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int z = 0; z < matrix.GetLength(2); z++)
            {
                if (z < matrix.GetLength(2) - 1) Console.Write($"{matrix[i, j, z],3} {(i, j, z)}");
                else Console.Write($"{matrix[i, j, z],4} {(i, j, z)}");
            }
        }
        Console.WriteLine("");

    }
}

int[,,] createMatrixRndInt = CreateMatrixRndInt(2, 2, 2);

PrintMatrix(createMatrixRndInt);