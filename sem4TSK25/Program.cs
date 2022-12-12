//метод считывает данные от пользователя
int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine()??"0");
}
//  считывает оператор
string? ReadDataOper(string msg)
{
    Console.Write(msg);
    
    return Console.ReadLine();
}

// метод возводит число a в степень b
int resPow(int a, int b)
{
    int res=1;
    for(int i=1; i<=b; i++)
    {
        res=a*res;
        
    }
return res;
}


//метод находит сумму чисел
int resSum(int a, int b)
{
    return a+b;
}

// метод находит разность чисел
int resDif(int a,int b)
{
    return a-b;
}

//метод находит произведение чисел
int resProd(int a,int b)
{
    return a*b;
}

//метод находит частное чисел
int resDiv(int a,int b)
{
    return a/b;
}

//метод выводит результат операции
void PrintData(string msg, string res)
{
    Console.WriteLine(msg + res);
}

int a = ReadData("введите первое число:");
string oper = ReadDataOper("введите операцию ( + , - , * , /  , P (для возведения в степень)");
int b = ReadData("введите второе число:");



if (oper[0] =='+')
{
    PrintData("result: ", resSum(a, b).ToString());
}
if (oper[0] == '-')
{
    PrintData("result: ", resDif(a, b).ToString());
}
if (oper[0] == '*')
{
    PrintData("result: ", resProd(a, b).ToString());
}
if (oper[0] == '/')
{
    PrintData("result: ", resDiv(a, b).ToString());
}
if (oper[0] == 'P')
{
    PrintData("result: ", resPow(a, b).ToString());
}