Console.Write("Введи число: ");
int number = Convert.ToInt32(Console.ReadLine());
string result = Convert.ToString(number);
if (result.Length > 2)
    {
        Console.WriteLine("третья цифра -> " + result[2]);
    }
else 
    {
        Console.WriteLine("-> третьей цифры нет");
    }