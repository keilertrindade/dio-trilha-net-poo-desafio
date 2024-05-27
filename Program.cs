using DesafioPOO.Models;


Console.WriteLine("Criando smartphone Iphone:");
Iphone iphone = new Iphone (numero: "992232342345", modelo: "Iphone 13 Pro Max", imei: "3512344546767667",  memoria:128);
iphone.InstalarAplicativo("Instagram");

Console.WriteLine("Criando smartphone Nokia:");
Nokia nokia = new Nokia("559685968596","Nokia 3405","12987126912612",65);
nokia.InstalarAplicativo("EA Football 24");