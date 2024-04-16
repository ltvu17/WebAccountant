using Microsoft.EntityFrameworkCore.ChangeTracking;
using WebAccountant.ModelsBase;

namespace WebAccountant.Repository
{
    public interface IKtdmRepo
    {
        public Task<IEnumerable<Ktdm>> GetAllKtdmsAsync();
        public Task<EntityEntry<Ktdm>> AddNew(string values);
        public Task Update(string key, string values);
        public Task Delete(string key);
    }
}
