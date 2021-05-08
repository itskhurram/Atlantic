using System;

namespace Atlantic.MasterData.Domain.Models {
    public class Cities {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public short Flag { get; set; }
        public string WikiDataId { get; set; }
        public string CountryCode { get; set; }
        public string StateCode { get; set; }
        public int StatesId { get; set; }
        public States States { get; set; }
        public int CountriesId { get; set; }
        public Countries Countries { get; set; }

    }
}
