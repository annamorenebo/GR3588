
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

void PrintData(string msg, dynamic value)
     {
         Console.WriteLine(msg+value.ToString());
     }

void Print1DArr(int[] arr)
     {
         for (int i = 0; i < arr.Length - 1; i++)
         {
             Console.Write(arr[i] + ", ");
         }
         Console.WriteLine(arr[arr.Length - 1]);
     }


int CountEven(int[] arr)
{
    int res =0;
   for(int i=0; i<arr.Length; i++) 
   {
        if(arr[i]%2==0)
        res++;
   }
return res;
}

void BubbleSort(int[] array)
 {  
    for (int i = 1; i < array.Length; i++)
    {
        for(int j=0; j<array.Length-1; j++)
            if( array[j+1]<array[j] )
            {   
                int temp = array[j];
                array[j] = array[j+1];
                array[j+1] = temp;
            }
     }
 }

int[] testArr = GenArray(120, 100,1000);
Print1DArr(testArr);
Console.WriteLine();
Console.WriteLine("Отсортированный массив:");
BubbleSort(testArr);
Print1DArr(testArr);
Console.WriteLine();
PrintData("Количество четных чисел :" , CountEven(testArr));