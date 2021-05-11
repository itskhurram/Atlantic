using System.ComponentModel.DataAnnotations;
namespace Atlantic.MasterData.Domain.Models {
    public class Cities {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public short Flag { get; set; }
        public int StatesId { get; set; }
        public States States { get; set; }
        public int CountriesId { get; set; }
        public Countries Countries { get; set; }
    }
}
