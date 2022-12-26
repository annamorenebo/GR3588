//метод считывает данные от пользователя
 int ReadData(string line)
 {
     Console.Write(line);
     int number = int.Parse(Console.ReadLine() ?? "0");
     return number;
 }
// метод заполняет двумерный массив
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

// метод для вывода двумерного массива
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
//метод поиска нужного элемента по индексу
int SerchElement(int[,]arr,int x, int y)
{
    int elem=-1;
    if ((x<arr.GetLength(0)) && (y<arr.GetLength(1) ))
        {
             elem=arr[x,y];
        }
    else 
    Console.WriteLine("такого элемента нет");

    return elem;
}


//выводит результат
void PrintData(string msg, dynamic value)
{
    Console.WriteLine(msg + value.ToString());
}

//тело программы
int row = ReadData("Введите количество строк ");
int column = ReadData("Введите количество столбцов ");
int[,] arr2D = Fill2DArray(row, column, 0, 9);

int x = ReadData("Введите номер строки ");
int y = ReadData("Введите номер столбца ");
int elem =SerchElement(arr2D,x-1,y-1);//учитываем индексацию элементов массива с 0
Print2DArray(arr2D);
PrintData(" элемент с указанным индексом : ", elem);