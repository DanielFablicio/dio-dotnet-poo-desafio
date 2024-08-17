using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dio_Dotnet_POO_Desafio.Models
{
    public class Iphone(string number, string model, string imei, int memory) : Smartphone(number, model, imei, memory)
    {

        protected override string Brand { get; set; } = "Iphone";
        public override void InstallApp(string name) {
            Console.WriteLine($"{InstallingMessageInicialPhrase} {name} on {Brand}.");
        }
    }
}