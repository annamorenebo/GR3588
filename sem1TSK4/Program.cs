string? inputNum1 = Console.ReadLine();
string? inputNum2 = Console.ReadLine();
string? inputNum3 = Console.ReadLine();

int max=0;

if (
    inputNum1 != null &&
    inputNum2 != null &&
    inputNum3 != null
    ) {
    int num1 = int.Parse(inputNum1);
    int num2 = int.Parse(inputNum2);
    int num3 = int.Parse(inputNum3);

    if (num1 > num2) {
        max = num1;
    } else {
        max = num2;
    }    

    if (num3 > max)
    {
        max = num3;
    }

}

Console.WriteLine($"Максимальное число: {max}");








