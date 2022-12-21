int res=0;

//метод считывает данные от пользователя
int ReadData(string msg) 
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

//метод выводит результат
void PrintData(string res)
{
    Console.WriteLine(res);
}

//метод считает количество положительных чисел
int CountPositiveNum(int N)
{
    
    while(N>0)
    {
        if(ReadData("введите число")>0)
        {
            res++;
        }
        N=N-1;
    }
    return res;
}

// программа:
int N = ReadData("Введите количество чисел: ");
CountPositiveNum(N);
PrintData($"Количество положительных чисел= "+ res );