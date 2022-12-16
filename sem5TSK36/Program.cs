//генерирует массив
int[] GenArray(int len, int minValue, int maxValue)
     {
         Random rnd = new Random();
         int[] arr = new int[len];
         for (int i = 0; i < arr.Length; i++)
         {
             arr[i] = new Random().Next(minValue, maxValue + 1);
         }
         return arr;
     }
//печатает массив
void Print1DArr(int[] arr)
     {
         for (int i = 0; i < arr.Length - 1; i++)
         {
             Console.Write(arr[i] + ", ");
         }
         Console.WriteLine(arr[arr.Length - 1]);
     }
// суммирует элементы массива на нечетных позициях
int SumOdd(int[] arr)
{   
    int sum=0;
   
    for(int i = 1; i < arr.Length; i += 2)
        sum+=arr[i];

    return sum;
}
//выводит результат
void PrintData(string msg, dynamic value)
{
    Console.WriteLine(msg + value.ToString());
}



//программа
int[] testArr = GenArray(10, 0, 10);
Print1DArr(testArr);
int res=SumOdd(testArr);
PrintData("Сумма чисел на нечетных позициях равна ", res);
