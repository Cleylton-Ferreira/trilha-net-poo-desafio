using DesafioPOO.Models;

Nokia nokia= new Nokia("12345678","CB-300","11111111111", 64 );
nokia.Ligar();
nokia.InstalarAplicativo("Banco Caixa Econômica Federal");
nokia.ExibirDadosSmartphoneNokia();

System.Console.WriteLine("\n");

Iphone iphone= new Iphone("87654321", "Fan-150", "12345678911", 512);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Banco do Brasil");
iphone.ExibirDadosSmartphoneIphone();