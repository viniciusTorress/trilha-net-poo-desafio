using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("SmartPhone: Iphone");
Iphone iphone = new Iphone(numero: "12313", modelo: "12", imei: "123123123", memoria: 16);
iphone.Ligar();
iphone.InstalarAplicativo("Youtube");

Console.WriteLine("SmartPhone: Nokia");
Nokia nokia = new Nokia(numero: "123134", modelo: "lumia", imei: "12312315423", memoria: 16);
nokia.ReceberLigacao();
nokia.InstalarAplicativo("X");