using UserDomain.Contracts.Data.Entities;

namespace UserDomain.Contracts.DTO
{
    public class ItemDTO : AuditableEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Categories { get; set; }
        public string ColorCode { get; set; }
    }
}