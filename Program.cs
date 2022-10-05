using POOTelemoveis.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia =new Nokia(numero: "123456789", modelo: "Modelo 1", imei: "55555555", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("whatsapp");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone =new Iphone(numero: "123456789", modelo: "Modelo 1", imei: "55555555", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Telegram");