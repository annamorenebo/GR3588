

//метод читает данные от пользователя
int ReadData(string msg)

{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine()??"0");
}
int coordX=ReadData("введите координату х");
int coordY=ReadData("введите координату Y");

// метод определяет четверть

void PrintQuoterTest()
{
    if(coordX>0&&coordY>0) Console.WriteLine("quote 1");
    if(coordX>0&&coordY<0) Console.WriteLine("quote 2");
    if(coordX<0&&coordY<0) Console.WriteLine("quote 3");
    if(coordX<0&&coordY>0) Console.WriteLine("quote 4");}

PrintQuoterTest();

