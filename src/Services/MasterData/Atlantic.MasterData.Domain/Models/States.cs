using System;
using System.Collections.Generic;

namespace Atlantic.MasterData.Domain.Models {
    public class States {
        public int Id { get; set; }
        public string Name { get; set; }
        public short Flag { get; set; }
        public int CountriesId { get; set; }
        public Countries Countries { get; set; }
        public ICollection<Cities> Cities { get; set; }

    }
}
