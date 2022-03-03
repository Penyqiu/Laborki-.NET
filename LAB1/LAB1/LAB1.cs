// See https://aka.ms/new-console-template for more information

//Zad1
Console.WriteLine("/////////////////    ZAD1    //////////////////");
Console.WriteLine("Hello, World!");


//ZAD2
Console.WriteLine("/////////////////    ZAD2    //////////////////");
Console.WriteLine("Imie mordo");
var name = Console.ReadLine();
var lastName = Console.ReadLine();
Console.WriteLine($"{Environment.NewLine}ELO, {name},{lastName}");
Console.Write($"{Environment.NewLine}Press any key to exit...");
Console.ReadKey(true);

//ZAD3
Console.WriteLine("/////////////////    ZAD3    //////////////////");
Console.WriteLine("Podaj PATH mordeczko: ");
var path = Console.ReadLine();

if (args.Length == 0)
{
    if (path != null)
    {
        DirectoryInfo dir = new DirectoryInfo(path);

        foreach (DirectoryInfo d in dir.GetDirectories())
        {
            Console.WriteLine("{0, -30}\t directory", d.Name);
        }

        foreach (FileInfo f in dir.GetFiles())
        {
            Console.WriteLine("{0, -30}\t File", f.Name);
        }
    }
} 

//ZAD 4
Console.WriteLine("/////////////////    ZAD4    //////////////////");
Console.WriteLine("Podaj path do pliku w ktorym szukamy");
string path_io = Console.ReadLine();
Console.WriteLine("Podaj jakeigo slowa szukamy");
string searchValue = Console.ReadLine();
Console.WriteLine("Podaj na co zmieniamy");
string replaceValue = Console.ReadLine();
string text = File.ReadAllText(path_io);
text = text.Replace(searchValue, replaceValue);
Console.WriteLine("Podaj gdzie zapisujemy");
string pathSave = Console.ReadLine();
File.WriteAllText(pathSave, text);

Console.WriteLine("/////////////////    ZAD5    //////////////////");