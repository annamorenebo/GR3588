//Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}
// Печать результата
void PrintResult(string msg, int res)
{
    Console.WriteLine(msg +res);
}
//подсчет суммы элементов рекурсивным способом
int SummRecMN(int M, int N)
{
    int outRes = 0;
    if (M >= N) return outRes + N;
     outRes = M + SummRecMN(M + 1, N);
    return outRes;
}

int number1 = ReadData("Введите число M: ");
int number2 = ReadData("Введите число N: ");
int summMN = number1<number2? SummRecMN(number1, number2):SummRecMN(number2, number1);
PrintResult("Сумма чисел от М до N: ", summMN);