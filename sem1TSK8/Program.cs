string? inputNum = Console.ReadLine();
string? evenRow = String.Empty;
if(inputNum!=null)
{
    int num = int.Parse(inputNum);
    int evenNum=2;
    while(evenNum<=num)
    {
        evenRow=evenRow+evenNum + ",";
        evenNum=evenNum+2;
    }

 }

Console.WriteLine( evenRow );







