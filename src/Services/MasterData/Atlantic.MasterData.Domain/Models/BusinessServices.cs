using System.ComponentModel.DataAnnotations;

namespace Atlantic.MasterData.Domain.Models {
    public class BusinessServices {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public short Flag { get; set; } 
    }
}
