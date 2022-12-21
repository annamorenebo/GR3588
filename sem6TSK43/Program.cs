
using System;


//метод считывает введенную формулу для прямой
 string ReadData(string msg)
{
    Console.WriteLine(msg);

    string? ret = Console.ReadLine();
    if (ret == null)
        throw new InvalidOperationException("Вы ничего не ввели");

    return ret;
}

//метод преобразует коэффициенты в числа int и записывает их в виде массива
void CoefficientToInt(string formula, int[] arr)
{
    arr[0] = (int)Char.GetNumericValue(formula[2]);
    arr[1] = (int)Char.GetNumericValue(formula[5]);
}

string eqution1=ReadData("введите уравнение для первой прямой в виде y=kx+b:");
int[] CoefArr1 = new int[2]; // k и b первого уравнения
CoefficientToInt(eqution1, CoefArr1);

string eqution2=ReadData("введите уравнение для первой прямой в виде y=kx+b:");
int[] CoefArr2 = new int[2]; // k и b второго уравнения
CoefficientToInt(eqution2, CoefArr2);


// вычисление точки пересечения
float x=(CoefArr2[1]-CoefArr1[1])/(float)(CoefArr1[0]-CoefArr2[0]); 
float y=CoefArr2[0]*x+CoefArr2[1];

Console.WriteLine("x: {0:F2}", x);
Console.WriteLine("y: {0:F2}", y);


