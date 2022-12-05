//вводим два числа
string? inputNum1 = Console.ReadLine();
string? inputNum2 = Console.ReadLine();
// назначаем переменную max для максимального значения
int max=0;
if(inputNum1!=null&&inputNum2!=null)
{
    // переводим в численные значения
    int num1 = int.Parse(inputNum1);
    int num2 = int.Parse(inputNum2);
    //сравниваем два числа, наибольшее записывваем в переменную max
    if(num1>num2)
    {
        max=num1;
    }
    else
    {
        max=num2;
    }    
}
// выводим максимальное значение
Console.WriteLine($"Максимальное число={max}");







