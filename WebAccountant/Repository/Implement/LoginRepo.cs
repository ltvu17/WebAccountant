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
            if (user == null) { return null; }
            var cypherPassword = ExtentionService.EncryptString(loginDTO.Password);
            if(user.Password == cypherPassword)
            {
				var database = (await _unitOfWork.DatabaseInforDAO.Find(
				expression: db => db.User.Id == user.Id && db.DatabaseYear == loginDTO.DatabaseYear, 1, 1
				)).FirstOrDefault().DataBaseName;
                ExtentionService.SetAppConnectionString(ExtentionService.DecryptString(database));
                var userDTO = user.UserDTOMapper();
                userDTO.HasDatabase = true;
                return userDTO;

			}
            return null;
        }

		public void Logout()
		{
			ExtentionService.SetAppConnectionString("No Connection");
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

		public async Task<UserDTO> RegisterTest(RegisterDTO entity)
		{
			var user = (await _unitOfWork.UserDao.Find(s => s.UserName == entity.UserName, 1, 1)).FirstOrDefault();
			if (user != null)
			{
				throw new Exception("User Already Exist");
			}
			else
			{
				var cypherPassword = ExtentionService.EncryptString(entity.Password);
				var entityInsert = new User()
				{
					UserName = entity.UserName,
					Password = cypherPassword,
					Email = entity.Email,
					Phone = entity.Phone,
				};
				await _unitOfWork.UserDao.Add(entityInsert);
				await _unitOfWork.SaveChangesLoginContextAsync();
                entityInsert = (await _unitOfWork.UserDao.Find(s => s.UserName == entity.UserName, 1, 1)).FirstOrDefault();
                var databaseInfor = new DatabaseInfor()
                {
                    User = entityInsert,
                    DatabaseYear = "2024",
                    DataBaseName = ExtentionService.EncryptString(entity.Database),
			    };
				await _unitOfWork.DatabaseInforDAO.Add(databaseInfor);
				await _unitOfWork.SaveChangesLoginContextAsync();
				return entityInsert.UserDTOMapper();
			}
		}
	}
}
