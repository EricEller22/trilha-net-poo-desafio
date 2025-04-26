using DesafioPOO.Models;

Iphone iphone = new Iphone("27999652362", "Iphone 16 PRO", "176y39990dj", 128);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");


Console.WriteLine("        ");


Nokia nokia = new Nokia("27997392804", "Nokia Tijolão", "awe3213d21", 16);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Whatsapp");

