using WebAccountant.DAOs;
using WebAccountant.Models;
using WebAccountant.ModelsLogin;

namespace WebAccountant.Repository.Implement
{
    public class LoginRepo : ILoginRepo
    {
        private readonly UnitOfWork _unitOfWork;
        public LoginRepo(UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<UserDTO> Login(LoginDTO loginDTO)
        {
            var user = (await _unitOfWork.UserDao.Find(s => s.UserName == loginDTO.UserName, 1, 1)).FirstOrDefault();
            var cypherPassword = ExtentionService.EncryptString(loginDTO.Password);
            if(user.Password == cypherPassword)
            {
                return user.UserDTOMapper();
            }
            return null;
        }

        public async Task<UserDTO> Register(User userEntity)
        {
            var user = (await _unitOfWork.UserDao.Find(s => s.UserName == userEntity.UserName, 1, 1)).FirstOrDefault();
            if (user != null)
            {
                throw new Exception("User Already Exist");
            }
            else
            {
                var cypherPassword = ExtentionService.EncryptString(userEntity.Password);
                var entity = new User()
                {
                    UserName = userEntity.UserName,
                    Password = cypherPassword,
                    Email = userEntity.Email,
                    Phone = userEntity.Phone,
                };
                await _unitOfWork.UserDao.Add(entity);
                await _unitOfWork.SaveChangesLoginContextAsync();
                return entity.UserDTOMapper();
            }

        }
    }
}
