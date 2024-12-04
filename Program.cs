using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

// Smartphone teste = new Smartphone(); CHECK DE REGRA 1, NAO INSTANCIA SE TIRAR O //

Smartphone iphone = new Iphone("1", "XR", "12345678", 128);

Console.WriteLine("Digite o nome do Aplicativo que deseja Instalar");
iphone.InstalarAplicativo(Console.ReadLine());

Smartphone nokia = new Nokia("2", "Tijolao", "87654321", 64);
Console.WriteLine("Digite o nome do Aplicativo que deseja Instalar");

nokia.InstalarAplicativo(Console.ReadLine());