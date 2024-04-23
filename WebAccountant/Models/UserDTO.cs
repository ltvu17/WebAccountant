namespace WebAccountant.Models
{
    public class UserDTO
    {   
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public bool HasDatabase { get; set; } = false;
    }
}
