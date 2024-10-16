using DesafioPOO.Models;

Nokia nokia_smartphone = new Nokia("+5541987645592", "C21", "22-149865-816643-8", 128);
Console.WriteLine("Smartphone nokia:");
nokia_smartphone.Call();
nokia_smartphone.RecieveCall();
nokia_smartphone.InstallApplication("WhatsApp");

Iphone iphone_smartphone = new Iphone("+5581955921234", "16 PRO MAX", "11-843845-756342-5",512);
iphone_smartphone.Call();
iphone_smartphone.RecieveCall();
iphone_smartphone.InstallApplication("Telegram");

Console.ReadKey();