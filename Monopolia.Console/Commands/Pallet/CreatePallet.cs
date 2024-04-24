using Monopolia.Console.Interfaces;
using Monopolia.Repositories;

namespace Monopolia.Console.Commands.Pallet;

public class CreatePallet : ICommand
{
    private readonly PalletEfRepository _repository;

    public CreatePallet(PalletEfRepository repository)
    {
        _repository = repository;
    }

    public async Task Execute()
    {
         System.Console.Write("Pallet height: ");
         double height = double.Parse(System.Console.ReadLine() ?? "1.0");
         System.Console.Write("Pallet width: ");
         double width = double.Parse(System.Console.ReadLine() ?? "1.0");
         System.Console.Write("Pallet depth: ");
         double depth = double.Parse(System.Console.ReadLine() ?? "1.0");
         System.Console.Write("Pallet weight: ");
         var pallet = new Entities.Pallet(width, height, depth);
         System.Console.WriteLine(pallet);
         Entities.Pallet savedPallet = await _repository.Add(pallet);
         System.Console.Write($"Successfully added {savedPallet}: ");
         
    }
}