using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LuxuryProperties.Shared
{
    public class PropertyTrace
    {
        [Key]
        public int IdPropertyTrace { get; set; }
        public DateTime DateSale { get; set; }
        public string Name { get; set; }
        public double Value { get; set; }
        public float Tax { get; set; }

        //Relacion con Property
        public int IdProperty { get; set; }
        //[ForeignKey("IdProperty")]
        //public Property Property { get; set; }
    }
}
