using Monopolia.DbContexts;
using Monopolia.Entities;

namespace Monopolia.Repositories;

public class BoxEfRepository : BaseEfRepository<Box>
{
    public BoxEfRepository(WareHouseContext databaseContext) : base(databaseContext)
    { }
}