// See https://aka.ms/new-console-template for more information

using System.Threading.Channels;

Console.WriteLine("Podaj date poczatkowa(YYYY-MM-DD)");
DateTime startDate = Convert.ToDateTime(Console.ReadLine());
Console.WriteLine("Podaj date koncowa(YYYY-MM-DD)");
DateTime endDate = Convert.ToDateTime(Console.ReadLine());
var diffrenceDays = (endDate - startDate).TotalDays;
var diffrenceHours = (endDate - startDate).TotalHours;
var diffrenceSeconds = (endDate - startDate).TotalSeconds;
Console.WriteLine("Dni: "+diffrenceDays+", Godziny: "+diffrenceHours+", Sekundy: "+diffrenceSeconds);