using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LuxuryProperties.Shared
{
    public class PropertyImage
    {
        [Key]
        public int IdPropertyImage{ get; set; }
        public string? File { get; set; }
        public bool Enabled { get; set; }

        //Relacion con Property
        public int IdProperty { get; set; }
        //[ForeignKey("IdProperty")]
        //public Property Property { get; set; }
    }
}
