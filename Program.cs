using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia("83999877876", "Modelo beta", "11111111111", 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("--------------------------");

Console.WriteLine("Smartphone iphone:");
Smartphone iphone = new Iphone("8199001010", "Modelo teste", "33333333333333333", 128);
iphone.Ligar();
iphone.InstalarAplicativo("Tiktok");
