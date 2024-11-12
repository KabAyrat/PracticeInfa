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

    public abstract void DescribeHabitat();

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
}

class Ungulate : Mammal
{
    public int HoofCount { get; set; }

    public Ungulate() : base()
    {
        Class = "Ungulate";
        HoofCount = 4;
    }

    public Ungulate(string name, double averageWeight, string habitat, bool hasFur, int hoofCount)
        : base(name, averageWeight, habitat, hasFur)
    {
        HoofCount = hoofCount;
    }

    public override void DescribeHabitat()
    {
        Console.WriteLine($"{Name} — парнокопытное, которое обитает в {Habitat} и имеет {HoofCount} копыта.");
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
}


class Program
{
    static void SaveComparisonResult(Animal animal1, Animal animal2, Animal combinedAnimal, string filePath)
    {
        using (StreamWriter writer = new StreamWriter(filePath, true))
        {
            animal1.SaveToFile(writer);
            animal2.SaveToFile(writer);
            writer.WriteLine($"Суммарный вес {animal1.Name} и {animal2.Name} = {combinedAnimal.AverageWeight}");
            if (animal1 > animal2)
            {
                writer.WriteLine($"{animal1.Name} тяжелее, чем {animal2.Name}.");
                Console.WriteLine($"{animal1.Name} тяжелее, чем {animal2.Name}.");
            }
            else if (animal1 < animal2)
            {
                writer.WriteLine($"{animal1.Name} легче, чем {animal2.Name}.");
                Console.WriteLine($"{animal1.Name} легче, чем {animal2.Name}.");
            }
            else
            {
                writer.WriteLine($"{animal1.Name} и {animal2.Name} весят одинаково.");
                Console.WriteLine($"{animal1.Name} и {animal2.Name} весят одинаково.");
            }
        }
        Console.WriteLine("Информация о сравнении записана в файл.");
    }

    static void Main()
    {
        Console.WriteLine("Введите данные для первого животного:");
        Animal animal1 = new Mammal();
        animal1.InputFromUser();

        Console.WriteLine("Введите данные для второго животного:");
        Animal animal2 = new Bird();
        animal2.InputFromUser();

        Console.WriteLine("\nВывод информации о первом и втором животном:");
        animal1.ShowMessage();
        animal1.ShowHabitat();
        animal2.ShowMessage();
        animal2.ShowHabitat();
        Console.WriteLine();

        Animal combinedAnimal = animal1 + animal2;
        Console.WriteLine($"Суммарный вес животных {animal1.Name} и {animal2.Name}: {combinedAnimal.AverageWeight} кг.");
        string filePath = @"C:\Users\ayraa\source\repos\InfaLab`s\InfaLab`s\TextFile1.txt";
        SaveComparisonResult(animal1, animal2, combinedAnimal, filePath);

        Console.WriteLine("\nСоздаем массив из четырёх животных:");
        Animal[] animals = new Animal[4];
        animals[0] = animal1;
        animals[1] = animal2;
        animals[2] = new Mammal { Name = "Тигр", Class = "Млекопитающее", AverageWeight = 250, Habitat = "Джунгли" };
        animals[3] = new Bird { Name = "Сокол", Class = "Птица", AverageWeight = 1.5, Habitat = "Горы" };

        Console.WriteLine("\nИнформация о всех животных из массива:");
        foreach (var animal in animals)
        {
            animal.ShowMessage();
            animal.DescribeHabitat();
            Console.WriteLine();
        }
    }
}