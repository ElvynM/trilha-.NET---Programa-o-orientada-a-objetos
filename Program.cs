using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

 Smartphone nokia = new Nokia("123456789", "Nokia X20", "1111111111", 64);
 nokia.Ligar();
 nokia.ReceberLigacao();
 nokia.InstalarAplicativo("WhatsApp");
 Console.WriteLine();

 Smartphone iphone = new Iphone("987654321", "iPhone 13", "2222222222", 128);
            iphone.Ligar();
            iphone.ReceberLigacao();
            iphone.InstalarAplicativo("Instagram");
Console.ReadLine();