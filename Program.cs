using DesafioPOO.Models;

Console.WriteLine("Smartphone Iphone");

Iphone iphone = new Iphone("36489M","233Mw45","123456789Im", 512);
iphone.Ligar();
iphone.InstalarAplicativo("Telegram");

Console.WriteLine("\r\n");

Console.WriteLine("Smartphone Nokia");

Nokia nokia = new Nokia("584898aa", "1111", "222Mdas", 8);
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Whatsapp");
