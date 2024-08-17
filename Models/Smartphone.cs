using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dio_Dotnet_POO_Desafio.Models
{
    public abstract class Smartphone(string number, string model, string imei, int memory)
    {
        public string Number { get; set; } = number;

        protected abstract string Brand {get; set;}
        private readonly string Model = model;
        private readonly string IMEI = imei;
        private readonly int Memory = memory;

        public const string InstallingMessageInicialPhrase = "Installing app";

        public void Call() {
            Console.WriteLine("Calling...");
        }

        public void ReceiveCall() {
            Console.WriteLine("Receiving call...");
        }

        public void ShowSystemInformation() {
            Console.WriteLine( "\n" +
                "------- SYSTEM ------- \n" +
                $"Smarthphone {Brand} \n".ToUpper() +
                $"Model: {Model}\n" +
                $"IMEI: {IMEI} \n" +
                $"Memory: {Memory} GB \n"
            );
        }

        public abstract void InstallApp(string name);
    }
}