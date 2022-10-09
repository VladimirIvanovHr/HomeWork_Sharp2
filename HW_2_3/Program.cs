Console.Write("Введи цифру, обозначающую день недели: ");
int dayweek = Convert.ToInt32(Console.ReadLine());
if (dayweek<1 || dayweek> 7)
    {
        Console.WriteLine("неверное число");
    }
else 
    {
        if (dayweek>0 && dayweek<6)
        {
           Console.WriteLine("нет, это будний день");
        }
        else
        {
            Console.WriteLine("да, это выходной день");
        }
    }