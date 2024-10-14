using System;
using System.IO;

class Animal
{
    private string name;                                                    // ЗАКРЫТЫЕ ПЕРЕМЕННЫЕ
    public string Name
    {
        get { return name; }
        set { name = value; }
    }


    private string animalClass;
    public string Class                                                         //  ИНСКАПСУЛЯЦИЯ или КОНСТРУКТОР
    {   
        get { return animalClass; }
        set { animalClass = value; }
    }


    private double averageWeight;
    public double AverageWeight
    {
        get { return averageWeight; }
        set { 
            if(value <= 0)
            {
                Console.WriteLine("значение должно быть больше нуля");
            }
            else
            {
                averageWeight = value;
            }
        }
    }


    public Animal()                                                                 //      ЭТО ВСЕ
    {                                                                               //
        Name = "undefined";                                                         //
        Class = "undefined";                                                        //
        AverageWeight = 1;                                                          //
    }                                                                               //
    public void InputFromUser()                                                     //      ВТОРОЕ
    {                                                                               //
        Console.Write("введите имя животного: ");                                   //
        Name = Console.ReadLine();                                                  //
                                                                                    //
        Console.Write("введите класс животного: ");                                 //
        Class = Console.ReadLine();                                                 //
                                                                                    //
        Console.Write("введите средний вес животного: ");                           //
        averageWeight = double.Parse(Console.ReadLine());                           //
    }                                                                               //
                                                                                    //
    public Animal(string name, string animalClass, double averageWeight)            //      ЗАДАНИЕ
    {
        Name = name;
        Class = animalClass;
        AverageWeight = averageWeight;
    }

    

    public void ShowMessage()
    {
        Console.WriteLine($"животное: {Name}, класс: {Class}, средний вес: {AverageWeight}");
    }

    public void SaveToFile(string fileName)                                             //  3 ЗАДАНИЕ
    {
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            writer.WriteLine($"имя: {Name}");
            writer.WriteLine($"класс: {Class}");
            writer.WriteLine($"средний вес: {AverageWeight}");
        }
        Console.WriteLine("данные записаны в файл");
    }
    Publi
}

class Program
{
    static void Main()
    {
        Animal defaultAnimal = new Animal();
        Console.WriteLine("по умолчанию: ");                                                                //  ЭТО 
        defaultAnimal.ShowMessage();                                                                        //  |  |
                                                                                                            //  |__|
        Animal userAnimal = new Animal();                                                                   //     |
        Console.WriteLine("\nвведите данные для нового объекта:");                                          //  ЗАДАНИЕ
        userAnimal.InputFromUser();
        userAnimal.ShowMessage();


        userAnimal.SaveToFile(@"C:\Users\ayraa\source\repos\ConsoleApp6\ConsoleApp6\TextFile1.txt");
    }
}
