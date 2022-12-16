double min=double.MaxValue;//присваивает наибольшее возможное значение
double max=double.MinValue;//присваивает наименьшее возможное значение
//генерирует массив вещественных чисел
double[] GenArray(int len, int minValue, int maxValue)
     {
         Random rnd = new Random();
         double[] arr = new double[len];
         for (int i = 0; i < arr.Length; i++)
         {
             arr[i] = new Random().NextDouble()*100;
         }
         return arr;
 
     }
//печатает сгенерированный массив
void Print1DArr(double[] arr)
     {
         for (int i = 0; i < arr.Length - 1; i++)
         {
             Console.Write( "{0:F2}; ", arr[i]);
         }
         Console.WriteLine(" {0:F2} " , arr[arr.Length - 1]);
     } 
// находит минимальное и максимальное значения
void MinMax(double[] arr)
{
    for(int i=0; i< arr.Length; i++)
    {
        if(arr[i]>max)
        {
            max=arr[i];
        }
        if(arr[i]<min)
        {
            min=arr[i];
        }
    }
}
//программа
double[] testArr = GenArray(10, 1, 10);
Print1DArr(testArr);
MinMax(testArr);
Console.WriteLine("min: {0:F2}", min);
Console.WriteLine("max: {0:F2}", max);
Console.WriteLine("Diff: {0:F2}", max-min);