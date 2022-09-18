// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
/*
int [,] CreatRandom2dArray()
{
    Console.Write("Input number of rows ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input  number of colomns ");
    int colums = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input min possible value ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input max possible value ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

        int[,] newArray = new int[rows, colums];

    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < colums; j++)
        {
            newArray[i,j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return newArray;
}

void Show2dArray(int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

void ArrangeArray(int [,] array)
{
Console.WriteLine("Sorted array is: ");
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      for (int m = 0; m < array.GetLength(1) - 1; m++)
      {
        if (array[i, m] < array[i, m + 1])
        {
          int temp = array[i, m + 1];
          array[i, m + 1] = array[i, m];
          array[i, m] = temp;
        }
      }
    }
  }
}

int[,] newArray = CreatRandom2dArray();
Show2dArray(newArray);
ArrangeArray(newArray);
Show2dArray(newArray);
*/
//____________________________________________________________________________________________________________________
// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
/*
int [,] CreatRandom2dArray()
{
    Console.Write("Input number of rows ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input  number of colomns ");
    int colums = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input min possible value ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input max possible value ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

        int[,] newArray = new int[rows, colums];

    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < colums; j++)
        {
            newArray[i,j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return newArray;
}

void Show2dArray(int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

void FindMinSumArray(int [,] array)
{
    int minsum = Int32.MaxValue;
    int indexLine = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum = sum + array[i, j];        
        }
            if (sum < minsum)
            {
            minsum = sum;
            indexLine++;
            }
    }
    Console.WriteLine($"The row with min element sum is {indexLine}");
}

int[,] newArray = CreatRandom2dArray();
Show2dArray(newArray);
FindMinSumArray(newArray);
//_________________________________________________________________________________________________________________
*/
// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
//Произведением двух матриц есть матрица, у которой столько строк, 
//сколько их у левого сомножителя, и столько столбцов, сколько их у правого сомножителя. 
/*
int [,] CreatRandomMatrix(int rows, int columns, int minValue, int maxValue)
{
    int[,] newArray = new int[rows, columns];

    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            newArray[i,j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return newArray;
}

void Show2dArray(int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

void MultiplyArray(int[,] firstMartrix, int[,] secomdMartrix, int[,] resultMatrix)
{
  for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < firstMartrix.GetLength(1); k++)
      {
        sum += firstMartrix[i,k] * secomdMartrix[k,j];
      }
      resultMatrix[i,j] = sum;
    }
  }
}

Console.Write("Input the numbers of rows of first matrix ");
int rows1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the numbers of columns of first matrix ");
int columns1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the numbers of rows of second matrix ");
int rows2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the numbers of columns of second matrix ");
int columns2 = Convert.ToInt32(Console.ReadLine());
if(columns1 != rows2) Console.WriteLine($"This matrix can't be multiply, cose numbers of COLUMNS of FIRST matrix have to be equal with nombers of ROW of SECOND mantrix");
Console.Write("Input min possible value ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value ");
int maxValue = Convert.ToInt32(Console.ReadLine());
int[,] resultArray = new int[rows1,columns2];

int[,] FirstArray = CreatRandomMatrix(rows1, columns1, minValue, maxValue);
int[,] SecondArray = CreatRandomMatrix(rows2, columns2, minValue, maxValue);
Show2dArray(FirstArray);
Show2dArray(SecondArray);
MultiplyArray(FirstArray, SecondArray, resultArray);
Console.WriteLine("The result of multiplaing of frst and second matrix is follow: ");
Console.WriteLine();
Show2dArray(resultArray);
*/
//_______________________________________________________________________________________________________________________
// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
/*
int[,,] CreatRandom3dArray()
{
    Console.Write("Input number of length ");
    int length = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input  number of height ");
    int height = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input  number of depth ");
    int depth = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input min possible value ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input max possible value ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,,] newArray = new int[length, height, depth];

    for (int i = 0; i < length; i++)
    {
        for (int j = 0; j < height; j++)
        {
            for (int k = 0; k < depth; k++)
            {
                newArray[i, j, k] = new Random().Next(minValue, maxValue + 1);
                
            }
        }
    }
    return newArray;
}

void Show3dArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                 
                 Console.WriteLine($"{array[i, j, k]} ({i},{j},{k}) ");
            }
        }
        Console.WriteLine();
    }
}

int[,,] newArray = CreatRandom3dArray();
Show3dArray(newArray);
*/
//_______________________________________________________________________________________________________________________
// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
/*
int [,] CreatSpiralArray()
{
    Console.Write("Input number of rows and columns ");
    int size = Convert.ToInt32(Console.ReadLine());
    
    int[,] newArray = new int[size, size];
    int count = 1;
    int i = 0;
    int j = 0;

    while (count <= newArray.GetLength(0) * newArray.GetLength(1))
    {
    newArray[i, j] = count;
    count++;
    if (i <= j + 1 && i + j < newArray.GetLength(1) - 1)
        j++;
    else if (i < j && i + j >= newArray.GetLength(0) - 1)
        i++;
    else if (i >= j && i + j > newArray.GetLength(1) - 1)
        j--;
    else
        i--;
    }
    return newArray;
}

void ShowSpiralArray(int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
           Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] myArray = CreatSpiralArray();
ShowSpiralArray(myArray);
*/