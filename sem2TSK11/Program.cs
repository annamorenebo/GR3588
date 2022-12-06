System.Random numberSintezator=new System.Random();
int number =numberSintezator.Next(100,1000);
Console.WriteLine(number);

int firstNumber=number/100;
int secondNumber=number%100/10;
int thirdNumber=number%10;



Console.WriteLine($"{firstNumber}{thirdNumber}");
    


