using WebAccountant.DAOs;
using WebAccountant.ModelsBase;

namespace WebAccountant.Repository.Implement
{
    public class UserTableRepo : IUserTableRepo
    {
        private readonly UnitOfWork _unitOfWork;

        public UserTableRepo(UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<IEnumerable<KtUserTable>> GetUserPermission(string userName)
        {
            return await _unitOfWork.KtUserTableDAO.Find(s => s.MaUser == userName, int.MaxValue, 1);
        }
    }
}
