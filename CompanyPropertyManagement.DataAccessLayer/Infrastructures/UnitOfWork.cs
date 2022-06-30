using CompanyPropertyManagement.Data.Context;
using CompanyPropertyManagement.DataAccessLayer.IRepositories;
using CompanyPropertyManagement.DataAccessLayer.Repositories;

namespace CompanyPropertyManagement.DataAccessLayer.Infrastructures
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        private IBuRepository _buRepository;
        private ICategoryRepository _categoryRepository;
        private IInventoryRepository _inventoryRepository;
        private IPropertyRepository _propertyRepository;
        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
        }
        public IBuRepository BuRepository => _buRepository ?? new BuRepository(_context);
        public ICategoryRepository CategoryRepository => _categoryRepository ?? new CategoryRepository(_context);
        public IInventoryRepository InventoryRepository => _inventoryRepository ?? new InventoryRepository(_context);
        public IPropertyRepository PropertyRepository => _propertyRepository ?? new PropertyRepository(_context);
        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
