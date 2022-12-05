// вводим число
string? inputLine = Console.ReadLine();

if(inputLine!=null)
{   //переводим в числовое значение
    int num = int.Parse(inputLine);
    // назначаем переменную - остаток от деления на 2 
    int RemDiv=num%2;
        // проверяемБ нулевой ли остаток
        if(RemDiv==0) 
        {
            //если нулевой, то выводим на экран, что число четное
            Console.WriteLine("число четное");

        }
        else
        {   // иначе выводим, что число нечетное
            Console.WriteLine("число нечетное");
        }
    
}


