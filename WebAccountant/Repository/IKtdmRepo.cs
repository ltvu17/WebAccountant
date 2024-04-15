using WebAccountant.ModelsBase;

namespace WebAccountant.Repository
{
    public interface IKtdmRepo
    {
        public Task<IEnumerable<Ktdm>> GetAllKtdmsAsync();
    }
}
