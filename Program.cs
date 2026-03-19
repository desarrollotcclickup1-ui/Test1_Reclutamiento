using Test1.Services;

Console.WriteLine("Seleccione opción:");
Console.WriteLine("1 - Transacciones");
Console.WriteLine("2 - Inventario");
Console.WriteLine("3 - Compresor");

var option = Console.ReadLine();

switch (option)
{
    case "1":
        new TransactionService().Run();
        break;
    case "2":
        new ProductService().Run();
        break;
    case "3":
        var comp = new StringCompressor();
        Console.WriteLine("Resultado: " + comp.Compress("aabbbccccdd"));
        break;
}