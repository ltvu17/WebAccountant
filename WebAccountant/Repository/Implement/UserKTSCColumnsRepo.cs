
using WebAccountant.DAOs;
using WebAccountant.ModelsLogin;

namespace WebAccountant.Repository.Implement
{
    public class UserKTSCColumnsRepo : IUserKTSCColumnsRepo
    {
        private readonly UnitOfWork _unitOfWork;
        public UserKTSCColumnsRepo(UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<bool> AddAllColumnOfUser(int userId, IEnumerable<int> columnId)
        {
            try
            {
                var listUser = (await _unitOfWork.UserKTSCColumnsDAO.Find(s => s.UserId == userId, int.MaxValue, 1)).ToList();
                if (listUser != null) {
                    await RemoveAllColumnOfUser(userId);
                }
                List<UserKTSCColumn> userKTSCColumns = new List<UserKTSCColumn>();
                foreach (int id in columnId)
                {
                    userKTSCColumns.Add(new UserKTSCColumn()
                    {
                        UserId = userId,
                        KTSCColumnId = id
                    });
                }
                await _unitOfWork.UserKTSCColumnsDAO.AddRange(userKTSCColumns);
                await _unitOfWork.SaveChangesLoginContextAsync();
                return true;
            }
            catch (Exception ex) { 
                return false;
            }
        }

        public async Task<IEnumerable<KTSCColumn>> GetAllKTSCColumn()
        {
            return await _unitOfWork.KTSCColumnsDAO.GetAll();
        }

        public async Task<IEnumerable<UserKTSCColumn>> GetUserKTSCColumn(int userId)
        {
            return (await _unitOfWork.UserKTSCColumnsDAO.Find(s => s.UserId == userId, int.MaxValue, 1, includeProperties: "KTSCColumn")).ToList();
        }

        public async Task<bool> RemoveAllColumnOfUser(int userId)
        {
            try
            {
                var listUser = (await _unitOfWork.UserKTSCColumnsDAO.Find(s=>s.UserId == userId, int.MaxValue, 1)).ToList();
                var result = await _unitOfWork.UserKTSCColumnsDAO.RemoveRange(listUser);
                if (result)
                {
                    await _unitOfWork.SaveChangesLoginContextAsync();
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
