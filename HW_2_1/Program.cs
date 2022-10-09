Console.Write("Введи трёхзначное число: ");
int threeNumber = Convert.ToInt32(Console.ReadLine());
if (threeNumber < 100)
    {
        Console.WriteLine("неверное число");
    }
else 
    {if (threeNumber > 999) 
        {
            Console.WriteLine("неверное число");
        }
    else
            {
                string stringNumber = Convert.ToString(threeNumber);
                Console.WriteLine("вторая цифра этого числа -> " + stringNumber[1]); 
            }
    }