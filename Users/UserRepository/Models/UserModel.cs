using System.ComponentModel.DataAnnotations;

namespace UserRepository.Models
{
    public class UserModel
    {
        [Key]
        public int userid {get; set;}
        public string username {get;set;}
    }
}