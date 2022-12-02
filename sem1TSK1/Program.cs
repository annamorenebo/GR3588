string? inputNum1 = Console.ReadLine();
string? inputNum2 = Console.ReadLine();

if(inputNum1!=null&&inputNum2!=null)
{
    int num1 = int.Parse(inputNum1);
    int num2 = int.Parse(inputNum2);
        if(num2==num1*num1) 
        {
            Console.WriteLine("второе квадрат первого");

        }
        else
        {
            Console.WriteLine("второе не квадрат первого");
        }
    
}

