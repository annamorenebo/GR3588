
Console.WriteLine("введите пятизначное число");

string? strPalin = Console.ReadLine();

bool res =((strPalin[0]==strPalin[4])&&(strPalin[1]==strPalin[3]));


{
    Console.WriteLine(res ? "Это  палиндром":"Это не палиндром");
    
}
