using Dio_Dotnet_POO_Desafio;
using Dio_Dotnet_POO_Desafio.Models;



Smartphone nokia = new Nokia(number: "123456", model: "Chad", imei: "121233217", memory: 64);
nokia.ShowSystemInformation();
nokia.Call();
nokia.ReceiveCall();
nokia.InstallApp("Steam");


Console.WriteLine("\n");



Smartphone iphone = new Iphone(number: "654321", model: "Titanium", imei: "678544461", memory: 128);
iphone.ShowSystemInformation();
iphone.Call();
iphone.ReceiveCall();
iphone.InstallApp("Safari_2");