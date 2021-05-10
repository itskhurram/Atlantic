using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace Atlantic.MasterData.Domain.Models {
    public class Countries {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public short Flag { get; set; }
        public ICollection<States> States { get; set; }
        public ICollection<Cities> Cities { get; set; }
    }
}
