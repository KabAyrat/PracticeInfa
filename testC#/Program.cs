using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите номинал банкноты: ");

        string s = Console.ReadLine();
        int num = int.Parse(s);
            switch (num)
            {
                case 5:
                    Console.WriteLine("Великий Новгород");
                    break;
                case 10:
                    Console.WriteLine("Красноярск");
                    break;
                case 50:
                    Console.WriteLine("Санкт-Петербург");
                    break;
                case 100:
                    Console.WriteLine("Москва.");
                    break;
                case 200:
                    Console.WriteLine("Севастополь.");
                    break;
                case 500:
                    Console.WriteLine("Архангельск.");
                    break;
                case 1000:
                    Console.WriteLine("Ярославль.");
                    break;
                case 2000:
                    Console.WriteLine("Владивосток.");
                    break;
                case 5000:
                    Console.WriteLine("Хабаровск.");
                    break;
                default:
                    Console.WriteLine("Банкнота с таким номиналом не существует.");
                    break;
            }
        }
    }

