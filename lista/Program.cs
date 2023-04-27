// See https://aka.ms/new-console-template for more information


List<string> ListVaror = new List<string> ()  {"mjölk", "socker", "grillkorv", "senap"};

Console.WriteLine("Inköpslista: ");

Console.WriteLine(ListVaror);

Console.WriteLine("Vad för vara vill du lägga till?");


ListVaror.Add(Console.ReadLine());

Console.ReadLine();
