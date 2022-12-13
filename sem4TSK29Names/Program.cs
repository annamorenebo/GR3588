
//метод считывает данные 
string? ReadData(string msg)
{
    Console.WriteLine(msg);
    return Console.ReadLine();
}
//метод выводит результат
void PrintData(string msg, dynamic value)
{
    Console.WriteLine(msg + value.ToString());
}
// разделяет строку с именами на элементы массива c помощью функции Split 
//и выбирает рандомный элемент массива.
string WhoGoesToBuyTheBeer(string inpNames)
{
    string[] arr = inpNames.Split(",");
    Random rnd = new Random();
    return arr[rnd.Next(arr.Length)];
}

string names = ReadData("Введите имена через запятую: ");
PrintData("За пивом пойдет: ", WhoGoesToBuyTheBeer(names));



