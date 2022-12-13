string? ReadData(string msg)
{
    Console.Write(msg );
    return Console.ReadLine();
}

int CountViaCharArray(string inputNumber)
{
    char[] arr;
    int res = 0;

    arr = inputNumber.ToCharArray();
 
    foreach (char i in arr)
    {
        res +=  int.Parse(i.ToString());
    }

    return res;
}

int CountViaMath(string inputNumber)
{
    int res = 0;
    int num = int.Parse(inputNumber); 
 
    while(num > 0)
    {  
        res += num % 10;
        num = num / 10;
    }

    return res;
}

void PrintData(string msg, dynamic val)
{
    Console.WriteLine(msg + val.ToString());
}

string? input = ReadData("Введите число: ");

if (input == null || input.Equals("")) {
   Console.Error.WriteLine("Что-то вы не то ввели");
} else {
    PrintData("Сумма цифр через массив: ", CountViaCharArray(input));
    PrintData("Сумма цифр через деление: ", CountViaMath(input));
}
DateTime d1=DateTime.Now;
int length1=CountViaCharArray(input);
Console.WriteLine($"через массив {DateTime.Now-d1}");

DateTime d2=DateTime.Now;
int length2=CountViaMath(input);
Console.WriteLine($"вычисления {DateTime.Now-d2}");


