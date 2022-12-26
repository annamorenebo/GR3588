
//считываем данные от пользователя
 int ReadData(string line)
 {
     Console.Write(line);
     int number = int.Parse(Console.ReadLine() ?? "0");
     return number;
 }
//заполнем двумерный массив
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
             Console.Write(matrix[i, j] + "    ");
         }
         Console.WriteLine();
     }
 }
//метод вывода одномерного массива
void Print1DArr(float[] arr)
     {
         for (int i = 0; i < arr.Length - 1; i++)

         {

             Console.ForegroundColor = ConsoleColor.Red;
             Console.Write( "{0:F1}  ", arr[i]);
         }
         Console.WriteLine(" {0:F1}  " , arr[arr.Length - 1]);
     } 

// метод подсчета среднего арифметического в каждом столбце и создания из нах одномерного массива
float[] AvgRow(int[,] arr)
    {
        float[] avg=new float [arr.GetLength(1)];
        for(int j = 0; j < arr.GetLength(1); j++)
            {
            for(int i=0; i<arr.GetLength(0); i++)
                {
                avg[j]+=arr[i,j];
                }
            
                avg[j]=avg[j]/(arr.GetLength(0));
            }

        return avg;
    }


//тело программы

int row = ReadData("Введите количество строк ");
int column = ReadData("Введите количество столбцов ");
int[,] arr2D = Fill2DArray(row, column, 0, 9);
Print2DArray(arr2D);
Print1DArr(AvgRow(arr2D));

