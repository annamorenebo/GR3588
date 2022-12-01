string? inputNum1 = Console.ReadLine();
string? inputNum2 = Console.ReadLine();
if(inputNum1!=null&&inputNum2!=null)
{
    int num1 = int.Parse(inputNum1);
    int num2 = int.Parse(inputNum2);
    int outResult = num1*num2;
    Console.WriteLine(outResult);
}



