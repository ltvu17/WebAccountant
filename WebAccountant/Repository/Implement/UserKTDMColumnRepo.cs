using WebAccountant.DAOs;
using WebAccountant.ModelsLogin;

namespace WebAccountant.Repository.Implement
{
    public class UserKTDMColumnRepo : IUserKTDMColumnRepo
    {
        private readonly UnitOfWork _unitOfWork;
        public UserKTDMColumnRepo(UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<bool> AddAllColumnOfUser(int userId, IEnumerable<UserKTDMColumn> column)
        {
            try
            {
                var listUser = (await _unitOfWork.UserKTDMColumnDAO.Find(s => s.UserId == userId, int.MaxValue, 1)).ToList();
                if (listUser != null)
                {
                    await RemoveAllColumnOfUser(userId);
                }
                List<UserKTDMColumn> userKTDMColumns = new List<UserKTDMColumn>();
                foreach (var id in column)
                {
                    userKTDMColumns.Add(new UserKTDMColumn()
                    {
                        UserId = userId,
                        KTDMColumnId = id.KTDMColumnId,
                        Width = id.Width,
                    });
                }
                await _unitOfWork.UserKTDMColumnDAO.AddRange(userKTDMColumns);
                await _unitOfWork.SaveChangesLoginContextAsync();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public async Task<IEnumerable<KTDMColumn>> GetAllKTDMColumn()
        {
            return await _unitOfWork.KTDMColumnsDAO.GetAll();
        }

        public async Task<IEnumerable<ModelsLogin.UserKTDMColumn>> GetUserKTDMColumn(int userId)
        {
            return (await _unitOfWork.UserKTDMColumnDAO.Find(s => s.UserId == userId, int.MaxValue, 1, includeProperties: "KTDMColumn")).ToList();
        }

        public async Task<bool> RemoveAllColumnOfUser(int userId)
        {
            try
            {
                var listUser = (await _unitOfWork.UserKTDMColumnDAO.Find(s => s.UserId == userId, int.MaxValue, 1)).ToList();
                var result = await _unitOfWork.UserKTDMColumnDAO.RemoveRange(listUser);
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
