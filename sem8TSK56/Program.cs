
 int ReadData(string line)
 {
     Console.Write(line);
     int number = int.Parse(Console.ReadLine() ?? "0");
     return number;
 }


//выводит результат
void PrintData( dynamic value, string msg)
{
    Console.WriteLine( value.ToString()+ msg);
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

//метод находит строку с минимальной суммой
int Minrow(int[,] arr)
{   int minRow=int.MaxValue;
    int minIndex= -1;
    for (int i = 0; i < arr.GetLength(0); i++)
    {   
        for (int j = 0; j < arr.GetLength(1); j++)
         {  
            int summ=0;
            summ+=arr[i,j]++;
            if(minRow>summ)
            {
                minRow=summ;
                minIndex=i+1;
            }
         }
    }
   
    return minIndex;
}

//тело программы
int row = ReadData("Введите количество строк ");
int column = ReadData("Введите количество столбцов ");
int[,] arr2D = Fill2DArray(row, column, 0, 100);
Print2DArray(arr2D);
Console.WriteLine();
int minIndex=Minrow(arr2D);
PrintData(minIndex,"-я строка с минимальной суммой");








