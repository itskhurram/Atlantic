using System;
using System.Collections.Generic;

namespace Atlantic.MasterData.Domain.Models {
    public class States {
        public int Id { get; set; }
        public string Name { get; set; }
        public string FipsCode { get; set; }
        public string ISO2 { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public short Flag { get; set; }
        public string WikiDataId { get; set; }
        public string CountryCode { get; set; }
        public int CountriesId { get; set; }
        public Countries Countries { get; set; }
        public ICollection<Cities> Cities { get; set; }

    }
}
