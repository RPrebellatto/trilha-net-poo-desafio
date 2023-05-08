using DesafioPOO.Models;

// Implementado

Console.WriteLine("Novo Nokia");

Smartphone nokia = new Nokia("1234124", "M1", "112343", 128);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine();

Console.WriteLine("Novo IPhone");
Smartphone iPhone = new IPhone("23455542", "11", "645632", 128);
iPhone.ReceberLigacao();
iPhone.InstalarAplicativo("Instagram");