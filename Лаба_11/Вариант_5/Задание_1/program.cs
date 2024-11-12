using System;
using System.IO;

abstract class Animal
{
    private string name;
    private string animalClass;
    private double averageWeight;
    protected string habitat;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public string Class
    {
        get { return animalClass; }
        set { animalClass = value; }
    }

    public double AverageWeight
    {
        get { return averageWeight; }
        set
        {
            if (value <= 0)
            {
                Console.WriteLine("Значение должно быть больше нуля");
            }
            else
            {
                averageWeight = value;
            }
        }
    }

    public string Habitat
    {
        get { return habitat; }
        set { habitat = value; }
    }

    public Animal()
    {
        Name = "undefined";
        Class = "undefined";
        AverageWeight = 1;
        Habitat = "unknown";
    }

    public Animal(string name, string animalClass, double averageWeight)
    {
        Name = name;
        Class = animalClass;
        AverageWeight = averageWeight;
        Habitat = "unknown";
    }

    public virtual void DescribeHabitat()
    {
        Console.WriteLine($"{Name} обитает в {Habitat}.");
    }

    public void InputFromUser()
    {
        Console.Write("Введите имя животного: ");
        Name = Console.ReadLine();
        Console.Write("Введите класс животного: ");
        Class = Console.ReadLine();
        Console.Write("Введите средний вес животного: ");
        double weight;
        if (double.TryParse(Console.ReadLine(), out weight))
        {
            AverageWeight = weight;
        }
        else
        {
            Console.WriteLine("Ошибка ввода. Установлено значение по умолчанию (1).");
            AverageWeight = 1;
        }
        Console.Write("Введите место обитания животного: ");
        Habitat = Console.ReadLine();
    }

    public virtual void ShowMessage()
    {
        Console.WriteLine($"Животное: {Name}, Класс: {Class}, Средний вес: {AverageWeight} кг.");
    }

    public virtual void ShowHabitat()
    {
        Console.WriteLine($"Место обитания: {Habitat}");
    }

    public void SaveToFile(StreamWriter writer)
    {
        writer.WriteLine($"Имя: {Name}");
        writer.WriteLine($"Класс: {Class}");
        writer.WriteLine($"Средний вес: {AverageWeight} кг.");
        writer.WriteLine($"Место обитания: {Habitat}");
        writer.WriteLine();
    }

    public static bool operator >(Animal a1, Animal a2)
    {
        return a1.AverageWeight > a2.AverageWeight;
    }

    public static bool operator <(Animal a1, Animal a2)
    {
        return a1.AverageWeight < a2.AverageWeight;
    }

    public static Animal operator +(Animal a1, Animal a2)
    {
        return new Mammal
        {
            Name = a1.Name + " и " + a2.Name,
            Class = a1.Class,
            AverageWeight = a1.AverageWeight + a2.AverageWeight,
            Habitat = "Общее место обитания"
        };
    }

    // Абстрактный метод для изменения свойств класса
    public abstract void UpdateProperties();
}

class Mammal : Animal
{
    public bool HasFur { get; set; }

    public Mammal() : base()
    {
        Class = "Mammal";
        HasFur = true;
    }

    public Mammal(string name, double averageWeight, string habitat, bool hasFur)
        : base(name, "Mammal", averageWeight)
    {
        Habitat = habitat;
        HasFur = hasFur;
    }

    public override void DescribeHabitat()
    {
        Console.WriteLine($"{Name} — млекопитающее, которое обитает в {Habitat}.");
    }

    // Реализация метода для изменения свойств класса Mammal
    public override void UpdateProperties()
    {
        Console.WriteLine("Обновление свойств для млекопитающего:");
        Console.Write("Введите новое имя: ");
        Name = Console.ReadLine();
        Console.Write("Введите новый средний вес: ");
        if (double.TryParse(Console.ReadLine(), out double newWeight))
        {
            AverageWeight = newWeight;
        }
        Console.Write("Есть ли мех (да/нет): ");
        HasFur = Console.ReadLine().ToLower() == "да";
    }
}

class Bird : Animal
{
    public bool CanFly { get; set; }

    public Bird() : base()
    {
        Class = "Bird";
        CanFly = true;
    }

    public Bird(string name, double averageWeight, string habitat, bool canFly)
        : base(name, "Bird", averageWeight)
    {
        Habitat = habitat;
        CanFly = canFly;
    }

    public override void DescribeHabitat()
    {
        string flyingAbility = CanFly ? "может летать" : "не может летать";
        Console.WriteLine($"{Name} — птица, которая обитает в {Habitat} и {flyingAbility}.");
    }

    // Реализация метода для изменения свойств класса Bird
    public override void UpdateProperties()
    {
        Console.WriteLine("Обновление свойств для птицы:");
        Console.Write("Введите новое имя: ");
        Name = Console.ReadLine();
        Console.Write("Введите новый средний вес: ");
        if (double.TryParse(Console.ReadLine(), out double newWeight))
        {
            AverageWeight = newWeight;
        }
        Console.Write("Может ли летать (да/нет): ");
        CanFly = Console.ReadLine().ToLower() == "да";
    }
}