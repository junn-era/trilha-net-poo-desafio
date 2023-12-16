using System.Formats.Asn1;
using DesafioPOO.Models;

Console.WriteLine("Smartphone iPhone");
Smartphone iphone = new Iphone(numero: "6211111111", modelo: "Model A", imei: "Z#123@123!", memoria: 2048);
iphone.Ligar();
iphone.InstalarAplicativo("Telegram");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(numero: "123321", modelo: "Model N", imei: "ZZaz123", memoria: 2);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");