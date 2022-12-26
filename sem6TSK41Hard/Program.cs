
//метод считывает введенную строку
 string? ReadData(string msg)
{
    Console.WriteLine(msg);

    string? ret = Console.ReadLine();
    if (ret == null)
        throw new InvalidOperationException("Вы ничего не ввели");

    return ret;
}

//метод находит начало положительного числа в строке и считает количество начал 
 int PositiveNumberCount( string inputStr)

 {
    int count=0;
    for(int i=0; i < inputStr.Length; i++)
    {
        if(Char.IsNumber(inputStr, i))
        {
            if (i == 0 || (!(Char.IsNumber(inputStr, i-1) || inputStr[i-1] == '-')))
                count++;
        
        }
        
    }
    return count;
 }


string inputStr=ReadData("введите символы");

Console.WriteLine("количество чисел: {0}", PositiveNumberCount(inputStr));