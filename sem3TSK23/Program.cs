// метод считывает данные от пользователя
int ReadData(string msg)
{
    Console.Write(msg + ": ");
    return int.Parse(Console.ReadLine()??"0");
}
//метод выстраивает таблицу
string LineBilder(int N, int pow)
{
    string line = "|";

    for(int i=1; i<=N; i++)
    {
        line += String.Format("{0,6} |", Math.Pow(i, pow));
    }

    return line;
}
// выстраивает горизонтальную линию
string SepBuilder(int N)
{
    return "+" + new String('-', N * 8 - 1) + "+";
}
// метод выводит данные
void PrintData(String msg, string res)
{
    Console.WriteLine(msg + res);
}

int numberN = ReadData("Введите число N");
PrintData("", SepBuilder(numberN));
PrintData("", LineBilder(numberN, 1));
PrintData("", SepBuilder(numberN));
PrintData("", LineBilder(numberN, 3));
PrintData("", SepBuilder(numberN));

