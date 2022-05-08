using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var connect = new GeneratorService.GeneratorSoapClient();
            var output = connect.GeneratorLiczb();
            Console.WriteLine(output);
        }
    }
}
