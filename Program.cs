// See https://aka.ms/new-console-template for more information

var arguments = args.AsQueryable().FirstOrDefault<string>();

if (arguments == null)
{
    System.Console.WriteLine("arguments were null");
}

System.Console.WriteLine($"Passed argument {arguments}");

if (arguments == "fetch")
{
    RandomApi randomApi = new RandomApi();
    await randomApi.CallApi();
}

