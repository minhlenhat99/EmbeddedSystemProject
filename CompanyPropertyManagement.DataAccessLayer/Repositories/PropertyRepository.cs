using CompanyPropertyManagement.Data.Context;
using CompanyPropertyManagement.Data.Domain;
using CompanyPropertyManagement.DataAccessLayer.IRepositories;

namespace CompanyPropertyManagement.DataAccessLayer.Repositories
{
    public class PropertyRepository : BaseRepository<Property>, IPropertyRepository
    {
        public PropertyRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
