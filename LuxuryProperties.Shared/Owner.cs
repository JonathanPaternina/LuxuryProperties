using System.ComponentModel.DataAnnotations;

namespace LuxuryProperties.Shared
{
    public class Owner
    {
        [Key]
        public int IdOwner { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string? Photo { get; set; }
        public DateTime BirthDay { get; set; }
    }
}
