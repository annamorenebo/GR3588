List<int> numList; 
 // считываем данные от пользователя
int ReadData(string line)
{
     Console.Write(line);
     int number = int.Parse(Console.ReadLine() ?? "0");
     return number;
}

// метод заполняет массив уникальными  двузначными числами
int[,,] Fill3DArray(int countX, int countY, int countZ)
 {
     
     int[,,] array3D = new int[countX, countY,countZ];

     for (int i = 0; i < countX; i++)
     {
         for (int j = 0; j < countY; j++)
         {
            for (int k = 0; k < countY; k++)
            {
                array3D[i, j, k] = GenNum(numList);
            }
            
         }
     }
     return array3D;
 }

void Print3DArray(int[,,] matrix)
 {
     for (int i = 0; i < matrix.GetLength(0); i++)
     {
         for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for(int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write("[{0},{1},{2}]: {3}  ", i, j, k, matrix[i, j, k]);
            }
        Console.WriteLine();
        }
    Console.WriteLine();
    }
 }

//вынимаем случайный элемент массива
int GenNum(List<int> num)
{
    int index=new Random().Next(0,num.Count);
    int outNum=num[index];
    num.RemoveAt(index);
    return outNum;

}

int X = ReadData("Введите значение измерения Х ");
int Y = ReadData("Введите значение измерения Y ");
int Z = ReadData("Введите значение измерения Х ");

numList = new List<int>();

for (int i=10; i < 100; i++)
    numList.Add(i);

int[,,] arr3D = Fill3DArray(X, Y, Z);
Print3DArray(arr3D);
