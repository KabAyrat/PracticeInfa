using System;
using System.IO;

class Animal
{
    private string name;                                                    // ЗАКРЫТЫЕ ПЕРЕМЕННЫЕ
    private string animalClass;
    private double averageWeight;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public string Class                                                         //  ИНСКАПСУЛЯЦИЯ
    {   
        get { return animalClass; }
        set { animalClass = value; }
    }

    public double AverageWeight
    {
        get { return averageWeight; }
        set { averageWeight = value; }
    }

    public Animal()                                                                 //      ЭТО ВСЕ
    {
        Name = "undefined";
        Class = "undefined";
        AverageWeight = 1;
    }
    public void InputFromUser()                                                     //      ВТОРОЕ
    {
        Console.Write("Введите имя животного: ");
        Name = Console.ReadLine();

        Console.Write("Введите класс животного: ");
        Class = Console.ReadLine();

        Console.Write("Введите средний вес животного: ");
        averageWeight = double.Parse(Console.ReadLine());
    }

    public Animal(string name, string animalClass, double averageWeight)            //      ЗАДАНИЕ
    {
        Name = name;
        Class = animalClass;
        AverageWeight = averageWeight;
    }

    

    public void ShowMessage()
    {
        Console.WriteLine($"Животное: {Name}, Класс: {Class}, Средний вес: {AverageWeight}");
    }

    public void SaveToFile(string fileName)                                             //  3 ЗАДАНИЕ
    {
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            writer.WriteLine($"Имя: {Name}");
            writer.WriteLine($"Класс: {Class}");
            writer.WriteLine($"Средний вес: {AverageWeight}");
        }
        Console.WriteLine("Данные успешно сохранены в файл.");
    }
}

class Program
{
    static void Main()
    {
        Animal defaultAnimal = new Animal();
        defaultAnimal.ShowMessage();

        Animal userAnimal = new Animal();
        userAnimal.InputFromUser();
        userAnimal.ShowMessage();

        userAnimal.SaveToFile(@"C:\Users\ayraa\Desktop\input.txt");
    }
}
