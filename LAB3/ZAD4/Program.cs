// See https://aka.ms/new-console-template for more information

var ludzie = new List<Person>
{
    new Person() {Age = 2137, Name = "Karol Wojtyla"},
    new Person() {Age = 2137, Name = "Zbrodniarz Wojenny"},

};

foreach (Person wypisywanko in ludzie)
{
    Console.WriteLine("Imie i nazwiko: "+wypisywanko.Name+"\n"+"Wiek: "+wypisywanko.Age);
}

public class Person
{
    private string name;
    private int age;

    public string Name
    {
        get => name;
        set => name = value ?? throw new ArgumentNullException(nameof(value));
    }

    public int Age
    {
        get => age;
        set => age = value;
    }
}