string? inputNum = Console.ReadLine();

if (inputNum != null)
{ 
   int num1 = int.Parse(inputNum);
   string? outDayOfWeek=string.Empty;
   outDayOfWeek = System.Globalization.CultureInfo.GetCultureInfo("ru_RU").DateTimeFormat.GetDayName((DayOfWeek)num1git);

   Console.WriteLine(outDayOfWeek);

}
        
    





