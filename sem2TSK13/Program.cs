int number=int.Parse(Console.ReadLine()??"0");


int digit3=0;

if(number>100)
{
    while(number/1000>0)

    {
        number=number/10;
        
    }
digit3=number%10;
Console.Write ($"третья цифра числа - "+ digit3);

}
else
    {
        Console.Write ($"третьей цифры нет ");
    }
    






    


