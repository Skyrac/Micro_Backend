using UserDomain.Contracts.Enum;

namespace UserDomain.Contracts.DTO
{
    public class CreateOrUpdateUserDTO
    {
        public string EmailAddress { get; set; }
        public string Password { get; set; }
        public UserRole Role { get; set; }
    }
}