//метод считывает данные от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
 //выводит массив
void PrintData(string res, int[] arr)
{
    Console.WriteLine(res);
    PrintArr(arr);
}
 //генерирует массив по заданным параметрам:  верхней и нижней границе массива
int[] GenArr(int numL, int numH)
{
    Random rnd = new Random();
    int[] arr = new int[8];
    for (int i = 0; i < 8; i++)
    {
        arr[i] = rnd.Next(numL, numH);
    }
    return arr;
}
// фомирует запись массива
void PrintArr(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length-1; i++)
    {
        Console.Write(arr[i]+", ");
    }
    Console.WriteLine(arr[arr.Length-1]+"]");
}

int arrLow = ReadData("Введите нижнюю границу массива:");
int arrHigth = ReadData("Введите верхнюю границу массива:");
int[] arr = GenArr(arrLow,arrHigth);

PrintData("Сгененрированный массив:",arr);


