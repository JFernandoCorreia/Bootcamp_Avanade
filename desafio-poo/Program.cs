using DesafioPOO.Models;

Console.WriteLine("Celular Nokia:");
Smartphone nokia = new Nokia(
    numero:"123",
    modelo:"modelo 1",
    imei:"1",
    memoria:128
);
nokia.Ligar();
nokia.InstalarAplicativo("Facebook");

Console.WriteLine("Celular Iphone");
Smartphone iphone = new Iphone(
    numero:"456",
    modelo:"modelo 2",
    imei:"2",
    memoria:256
);
iphone.Ligar();
iphone.InstalarAplicativo("Safari");
 Console.WriteLine("\nPrograma concluído.");