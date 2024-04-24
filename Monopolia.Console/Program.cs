using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Monopolia.Console.CLI;
using Monopolia.DbContexts;
using Monopolia.Entities;
using Monopolia.Repositories;
using Monopolia.Repositories.Interfaces;

public class Program
{
    private static WareHouseContext _context;

    public static void ConfigureServices()
    {
        var services = new ServiceCollection();                      

        services.AddSingleton<IBaseRepository<Box>, BoxEfRepository>();
        services.AddSingleton<IBaseRepository<Pallet>, PalletEfRepository>();
        services.AddDbContext<WareHouseContext>(options => options.UseSqlite("Filename=monopolia.db"));            
        var serviceProvider = services.BuildServiceProvider();
        _context = serviceProvider.GetService<WareHouseContext>();
    }
    
    public static void Main(string[] args)
    {
        ConfigureServices();
        var cli = new CLI(_context);
    }
}