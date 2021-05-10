using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace Atlantic.MasterData.Domain.Models {
    public class States {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public short Flag { get; set; }
        public int CountriesId { get; set; }
        public Countries Countries { get; set; }
        public ICollection<Cities> Cities { get; set; }
    }
}
