int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

void PrintData(string res, int[] arr)
{
    Console.WriteLine(res);
    PrintArr(arr);
}

int[] GenArr(int num,int numL, int numH)
{
    Random rnd = new Random();
    int[] arr = new int[num];
    for (int i = 0; i < 8; i++)
    {
        arr[i] = rnd.Next(numL, numH);
    }
    return arr;
}

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
int[] arr = GenArr(8,arrLow,arrHigth);

PrintData("Сгененрированный массив:",arr);


