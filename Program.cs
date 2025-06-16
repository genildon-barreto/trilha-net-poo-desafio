using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("\nSmartphone Nokia:");
Smartphone nokia = new Nokia(numero: "05511876", modelo: "Asha 501", imei: "46878765423", memoria: 4);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\nSmartphone Iphone:");
Smartphone iphone = new Iphone("05578543", "Iphone X", "97838494562", 256);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");
iphone.InstalarAplicativo("Telegram");