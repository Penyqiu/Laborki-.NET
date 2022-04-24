// See https://aka.ms/new-console-template for more information

using System.Linq.Expressions;
using System.Net;
using System.Text.RegularExpressions;

Console.WriteLine("Podaj ip");
    
    string ip = Console.ReadLine() ?? throw new InvalidOperationException();
Match match = Regex.Match(ip, @"^(25[0-5]|2[0-4][0-9]|[0-1]{1}[0-9]{2}|[1-9]{1}[0-9]{1}|[1-9])\.(25[0-5]|2[0-4][0-9]|[0-1]{1}[0-9]{2}|[1-9]{1}[0-9]{1}|[1-9]|0)\.(25[0-5]|2[0-4][0-9]|[0-1]{1}[0-9]{2}|[1-9]{1}[0-9]{1}|[1-9]|0)\.(25[0-5]|2[0-4][0-9]|[0-1]{1}[0-9]{2}|[1-9]{1}[0-9]{1}|[0-9])$");


if (match.Success)
{
    Console.WriteLine("Dobre ip");
    
}
else
{
    Console.WriteLine("Ktos ci zle dal ip, ja ci dam dobre, ktos ci zle ip dal");
    
}

Console.WriteLine("Podaj email");
    
string email = Console.ReadLine() ?? throw new InvalidOperationException();
Match matchEmail = Regex.Match(email, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");

if (matchEmail.Success)
{
    Console.WriteLine("Ktos ci dobry email dal");
}
else
{
    Console.WriteLine("Ktos ci zly email dal, zly wpisywales, ja ci dam dobry");
}