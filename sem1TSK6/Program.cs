string? inputLine = Console.ReadLine();

if(inputLine!=null)
{
    int num = int.Parse(inputLine);
    int RemDiv=num%2;

        if(RemDiv==0) 
        {
            Console.WriteLine("число четное");

        }
        else
        {
            Console.WriteLine("число нечетное");
        }
    
}


