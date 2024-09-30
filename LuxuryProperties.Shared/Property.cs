using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LuxuryProperties.Shared
{
    public class Property
    {
        [Key]
        public int IdProperty { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public double Price { get; set; }
        public int CodeInternal { get; set; }
        public int Year { get; set; }

        //Relacion con Owner
        public int IdOwner { get; set; }
        //[ForeignKey("IdOwner")]
        //public Owner Owner { get; set; }

    }
}
