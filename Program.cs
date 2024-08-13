using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia("123456", "Modelo 1", "111111111", 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");


Console.WriteLine("Smartphone Nokia");
Smartphone iphone = new Iphone("123456", "Modelo 1", "111111111", 64);
iphone.Ligar();
iphone.InstalarAplicativo("Telegram");
