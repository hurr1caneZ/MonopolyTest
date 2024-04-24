using Monopolia.DbContexts;
using Monopolia.Entities;

namespace Monopolia.Repositories;

public class PalletEfRepository : BaseEfRepository<Pallet>
{
    public PalletEfRepository(WareHouseContext databaseContext) : base(databaseContext)
    { }
}