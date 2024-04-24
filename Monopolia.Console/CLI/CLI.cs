using Monopolia.Console.Commands.Pallet;
using Monopolia.Console.Interfaces;
using Monopolia.DbContexts;
using Monopolia.Entities;
using Monopolia.Repositories;
using Monopolia.Repositories.Interfaces;

namespace Monopolia.Console.CLI;

public class CLI
{
    private readonly PalletEfRepository _palletRepository;
    
    private const string _commands = "  -create pallet \n" +
                                     "  -add box \n" +
                                     "\n" +
                                     "  enter -break to stop\n";

    private const string _options = "   -h, --help " +
                                    "   Prints help information\n";

    private readonly bool _flag = true;

    public CLI(WareHouseContext context)
    {
        _palletRepository = new PalletEfRepository(context);
        ShowCommandsAndOptions();
        while (_flag)
        {
            ICommand command;
            System.Console.ForegroundColor = ConsoleColor.DarkYellow;
            switch (System.Console.ReadLine())
            {
                case "-create pallet":
                    try
                    {
                        System.Console.ResetColor();
                        command = new CreatePallet(_palletRepository);
                        command.Execute();
                    }
                    catch (Exception e)
                    {
                        System.Console.WriteLine(e);
                        throw;
                    }
                    

                    break;
                case "-h":
                    ShowCommandsAndOptions();
                    break;
                case "--help":
                    ShowCommandsAndOptions();
                    break;
                case "-break":
                    _flag = false;
                    break;
            }
        }
    }

    private static void ShowCommandsAndOptions()
    {
        System.Console.ForegroundColor = ConsoleColor.DarkYellow;
        System.Console.WriteLine("COMMANDS: ");
        System.Console.ResetColor();
        System.Console.WriteLine(_commands);

        System.Console.ForegroundColor = ConsoleColor.DarkYellow;
        System.Console.WriteLine("OPTIONS: ");
        System.Console.ResetColor();
        System.Console.WriteLine(_options);
    }
}