int number1=int.Parse(Console.ReadLine()??"0");

int number2=int.Parse(Console.ReadLine()??"0");
int result = number2%number1;
if (result==0)
    {
        Console.Write ("второе число кратно первому");

    }
else 
    {
        Console.Write ("второе число не кратно первому, остаток от деления равен"+ result);

    }
//Console.WriteLine(number1);
