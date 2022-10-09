Console.Write("Введи трёхзначное число: ");
int threeDigitNumber = Convert.ToInt32(Console.ReadLine());
if (threeDigitNumber < 100)
    {
        Console.WriteLine("неверное число");
    }
else 
    {if (threeDigitNumber > 999) 
        {
            Console.WriteLine("неверное число");
        }
    else
            {
                string stringNumber = Convert.ToString(threeDigitNumber);
                Console.WriteLine("вторая цифра этого числа -> " + stringNumber[1]); 
            }
    }