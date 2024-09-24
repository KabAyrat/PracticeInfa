using System;
using System.Linq;
using System.IO;

class Program
{
    static void Main()
    {
        string file = "test.txt";
        string reader = File.ReadAllText(file);

        char[] letters = { 'A', 'a', 'O', 'o', 'I', 'i', 'Y', 'y', 'E', 'e', 'U', 'u' };

        string[] words = reader.Split(letters[] {' ',',','.'}, StringSplitOptions.RemoveEmptyEntries);
    }
}
