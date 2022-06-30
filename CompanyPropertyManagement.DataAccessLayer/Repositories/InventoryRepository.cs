using CompanyPropertyManagement.Data.Context;
using CompanyPropertyManagement.Data.Domain;
using CompanyPropertyManagement.DataAccessLayer.IRepositories;

namespace CompanyPropertyManagement.DataAccessLayer.Repositories
{
    public class InventoryRepository : BaseRepository<Inventory>, IInventoryRepository
    {
        public InventoryRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
