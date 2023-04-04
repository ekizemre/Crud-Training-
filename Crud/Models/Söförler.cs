using System.ComponentModel.DataAnnotations;

namespace Crud.Models
{
    public class Söförler
    {
        [Key]
        public int SöförID { get; set; }   
        public string Söförad { get; set; }

        public int AracID { get; set; } 
    }
}
