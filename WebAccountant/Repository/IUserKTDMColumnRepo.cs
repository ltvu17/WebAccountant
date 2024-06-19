using WebAccountant.ModelsLogin;

namespace WebAccountant.Repository
{
    public interface IUserKTDMColumnRepo
    {
        public Task<IEnumerable<KTDMColumn>> GetAllKTDMColumn();
        public Task<IEnumerable<UserKTDMColumn>> GetUserKTDMColumn(int userId);
        public Task<bool> AddAllColumnOfUser(int userId, IEnumerable<UserKTDMColumn> column);
        public Task<bool> RemoveAllColumnOfUser(int userId);
    }
}
