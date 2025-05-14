using DesafioPOO.Models;

Console.WriteLine("Testando Nokia:");
Smartphone nokia = new Nokia(numero: "123456", modelo: "Nokia 3310", imei: "111111111111", memoria: 64);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Snake");

Console.WriteLine("\nTestando iPhone:");
Smartphone iphone = new Iphone(numero: "987654", modelo: "iPhone 13", imei: "999999999999", memoria: 256);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");
