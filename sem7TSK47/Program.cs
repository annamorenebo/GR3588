//метод считывает данные от пользователя
int ReadData(string line)
 {
     Console.Write(line);
     int number = int.Parse(Console.ReadLine() ?? "0");
     return number;
 }

 // Универсальный метод генерации и заполнение двумерного массива
 double[,] Fill2DArray(int countRow, int countColumn, int topBorder, int downBorder)
 {
     System.Random rand = new System.Random();
     double[,] array2D = new double[countRow, countColumn];

     for (int i = 0; i < countRow; i++)
     {
         for (int j = 0; j < countColumn; j++)
         {
             array2D[i, j] = rand.NextDouble()*10;  
         }
     }
     return array2D;
 }


// метод для печати двумерного массива
 void Print2DArray(double[,] matrix)
 {
     for (int i = 0; i < matrix.GetLength(0); i++)
     {
         for (int j = 0; j < matrix.GetLength(1); j++)
         {
            
             Console.Write("{0:F2} " , matrix[i, j] );
             Console.Write("    ");
             Console.ResetColor(); 
         }
         Console.WriteLine();
     }
 }

//тело программы
int row = ReadData("Введите количество строк ");
int column = ReadData("Введите количество столбцов ");
double[,] arr2D = Fill2DArray(row, column, 0, 10);
Print2DArray(arr2D);