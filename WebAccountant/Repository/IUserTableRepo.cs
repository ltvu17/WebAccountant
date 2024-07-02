using WebAccountant.ModelsBase;

namespace WebAccountant.Repository
{
    public interface IUserTableRepo
    {
        public Task<IEnumerable<KtUserTable>> GetUserPermission(string userName);
    }
}
