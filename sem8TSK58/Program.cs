using System;




// метод перемножения двух матриц

static int[,] MatrixMultiplication(int[,] matrixA, int[,] matrixB)
    {       
        if ((matrixA.GetLength(0)-1) != (matrixB.GetLength(1)-1))
        {
            throw new Exception("Умножение невозможно! Количество столбцов первой матрицы не равно количеству строк второй матрицы.");
        }
        
        var matrixC = new int[matrixA.GetLength(1)-1, matrixB.GetLength(0)-1];

        for (var i = 0; i < matrixA.GetLength(1)-1; i++)
        {
            for (var j = 0; j < matrixB.GetLength(0)-1; j++)
            {
                matrixC[i, j] = 0;

                for (var k = 0; k < matrixA.GetLength(0)-1; k++)
                {
                    matrixC[i, j] += matrixA[i, k] * matrixB[k, j];
                }
            }
        }

        return matrixC;
    }


// метод считывает данные
 int ReadData(string line)
 {
     Console.Write(line);
     int number = int.Parse(Console.ReadLine() ?? "0");
     return number;
 }


// метод генерации двумерного массива

int[,] Fill2DArray(int countRow, int countColumn, int topBorder, int downBorder)
 {
     System.Random rand = new System.Random();
     int[,] array2D = new int[countRow, countColumn];

     for (int i = 0; i < countRow; i++)
     {
         for (int j = 0; j < countColumn; j++)
         {
             array2D[i, j] = rand.Next(topBorder, downBorder + 1);
         }
     }
     return array2D;
 }

 // метод вывода двумерного массива
 void Print2DArray(int[,] matrix)
 {
     for (int i = 0; i < matrix.GetLength(0); i++)
     {
         for (int j = 0; j < matrix.GetLength(1); j++)
         {
             Console.Write(matrix[i, j] + "  ");
         }
         Console.WriteLine();
     }
 }




//тело программы
int rowA= ReadData("Введите количество строк матрицы А ");
int columnA = ReadData("Введите количество столбцов матрицы А ");
int[,] arr2D_A = Fill2DArray(rowA, columnA, 0, 10);
int rowB= ReadData("Введите количество строк матрицы B ");
int columnB = ReadData("Введите количество столбцов матрицы B ");
int[,] arr2D_B = Fill2DArray(rowB, columnB, 0, 10);

Print2DArray(arr2D_A);
Console.WriteLine();
Print2DArray(arr2D_B);
Console.WriteLine();

Console.WriteLine("произведение двух матриц:");
int[,] arr2D_C=MatrixMultiplication(arr2D_A,arr2D_B);
Print2DArray(arr2D_C);










