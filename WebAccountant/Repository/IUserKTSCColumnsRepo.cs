using WebAccountant.ModelsLogin;

namespace WebAccountant.Repository
{
    public interface IUserKTSCColumnsRepo
    {
        public Task<IEnumerable<KTSCColumn>> GetAllKTSCColumn();
        public Task<IEnumerable<UserKTSCColumn>> GetUserKTSCColumn(int userId);
        public Task<bool> AddAllColumnOfUser(int userId, IEnumerable<int> columnId);
        public Task<bool> RemoveAllColumnOfUser(int userId);
    }
}
