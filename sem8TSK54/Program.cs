
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
             Console.Write(matrix[i, j] + "  ");
         }
         Console.WriteLine();
     }
 }



//сортировка пузырьком по строкам
void BubbleSort(int[,] array)
 {  for (int k = 0; k < array.GetLength(0); k++)
    {
        for (int i = 1; i < array.GetLength(1); i++)
        {
            for(int j=0; j<array.GetLength(1)-1; j++)
                if( array[k,j+1]>array[k,j] )
                {   
                    int temp = array[k,j];
                    array[k,j] = array[k,j+1];
                    array[k,j+1] = temp;
                }
        }
    }
 }



int row = ReadData("Введите количество строк ");
int column = ReadData("Введите количество столбцов ");
int[,] arr2D = Fill2DArray(row, column, 0, 100);
Print2DArray(arr2D);
Console.WriteLine();
Console.WriteLine( "массив, отсортированный по убыванию:");
Console.WriteLine();
BubbleSort(arr2D);
Print2DArray(arr2D);




