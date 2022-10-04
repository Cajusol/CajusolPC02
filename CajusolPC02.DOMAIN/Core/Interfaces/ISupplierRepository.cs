using CajusolPC02.DOMAIN.Core.Entities;

namespace CajusolPC02.DOMAIN.Core.Interfaces
{
    public interface ISupplierRepository
    {
        Task<bool> Delete(int id);
        Task<Supplier> GetSupplier(int id);
        Task<IEnumerable<Supplier>> GetSuppliers();
        Task<IEnumerable<Supplier>> GetSuppliersByCountry(string country);
        Task<bool> Insert(Supplier supplier);
        Task<bool> Update(Supplier supplier);
    }
}