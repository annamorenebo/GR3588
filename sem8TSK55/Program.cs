//считываем данные от пользователя
 int ReadData(string line)
 {
     Console.Write(line);
     int number = int.Parse(Console.ReadLine() ?? "0");
     return number;
 }

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

bool TTest(int[,] arr)
    {
        if(arr.GetLength(0)==arr.GetLength(1))
        {
            return true;
        }
        else
        {
            Console.WriteLine("невозможно поменять столбцы и строки местами");
            return false;
        }
    }



void TUpdate2DArray(int[,] arr)
{
    int temp=0;
     for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = i+1; j < arr.GetLength(1); j++)
        {
            temp = arr[i,j];
            arr[i,j]=arr[j,i];
            arr[j,i]=temp;
        }
    }
}



int row = ReadData("Введите количество строк ");
int column = ReadData("Введите количество столбцов ");
int[,] arr2D = Fill2DArray(row, column, 0, 9);
Print2DArray(arr2D);
Console.WriteLine();
if (TTest(arr2D)) TUpdate2DArray(arr2D);
Print2DArray(arr2D);
