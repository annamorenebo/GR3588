//метод считывает введенные значение
int ReadData(string msg)
{
    Console.Write(msg + ": ");
    return int.Parse(Console.ReadLine()??"0");
}

// метод вычисляет расстояние
double CalculateLenght(double x1, double y1, double x2, double y2)
{
    return Math.Sqrt((x1-x2)*(x1-x2)+(y1-y2)*(y1-y2));
}

void PrintData(String msg, double res)
{
    Console.WriteLine(msg + res.ToString("######.##"));
}

int coordX1=ReadData("введите координаты точки x1");
int coordY1=ReadData("введите координаты точки y1");
int coordX2=ReadData("введите координаты точки x2");
int coordY2=ReadData("введите координаты точки y2");

PrintData("dist=", CalculateLenght(coordX1, coordY1, coordX2, coordY2 ));
