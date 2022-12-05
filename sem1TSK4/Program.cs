// вводим 3 числа
string? inputNum1 = Console.ReadLine();
string? inputNum2 = Console.ReadLine();
string? inputNum3 = Console.ReadLine();
// назначаем переменную max для максимального значения
int max=0;

if (
    inputNum1 != null &&
    inputNum2 != null &&
    inputNum3 != null
    ) {
    // переводим в числовые значения
    int num1 = int.Parse(inputNum1);
    int num2 = int.Parse(inputNum2);
    int num3 = int.Parse(inputNum3);
// спавнивам первое и второе число
    if (num1 > num2) {
        max = num1;
    } else {
        max = num2;
    }    
//сравниваем третье число с максимумом
    if (num3 > max)
    {
        max = num3;
    }

}
// выводим максимальное число
Console.WriteLine($"Максимальное число: {max}");









