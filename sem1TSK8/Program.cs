// вводим число
string? inputNum = Console.ReadLine();
//назначаем пустую строку для записи четных чисел
string? evenRow = String.Empty;
if(inputNum!=null)
{   // переводим введенное число в числовое значение
    int num = int.Parse(inputNum);
    // назначаем начальное число равное 2
    int evenNum=2;
    // цикл: пока число меньше или равно введенному, выполняем 
    while(evenNum<=num)
    {   // в стоку четных чисел добавляем следующее четное число
        evenRow=evenRow+evenNum + ",";
        // прибавляем 2Б чтобы получить следующее четное число
        evenNum=evenNum+2;
    }

 }
// выводим строку четных чисел
Console.WriteLine( evenRow );







