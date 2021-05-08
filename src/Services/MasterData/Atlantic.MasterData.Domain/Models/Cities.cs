using System;

namespace Atlantic.MasterData.Domain.Models {
    public class Cities {
        public int Id { get; set; }
        public string Name { get; set; }
        public short Flag { get; set; }
        public string CountryCode { get; set; }
        public string StateCode { get; set; }
        public int StatesId { get; set; }
        public States States { get; set; }
        public int CountriesId { get; set; }
        public Countries Countries { get; set; }

    }
}
