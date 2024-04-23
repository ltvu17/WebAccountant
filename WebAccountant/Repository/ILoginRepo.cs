using WebAccountant.Models;
using WebAccountant.ModelsLogin;

namespace WebAccountant.Repository
{
    public interface ILoginRepo
    {
        public Task<UserDTO> Login(LoginDTO loginDTO);
        public Task<UserDTO> Register(User userEntity);
    }
}
