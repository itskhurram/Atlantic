using System;
using System.Collections.Generic;

namespace Atlantic.MasterData.Domain.Models {
    public class Countries {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ISO3 { get; set; }
        public string ISO2 { get; set; }
        public string Phonecode { get; set; }
        public string Capital { get; set; }
        public string Currency { get; set; }
        public string Currency_symbol { get; set; }
        public string TLD { get; set; }
        public string Native { get; set; }
        public string Region { get; set; }
        public string Subregion { get; set; }
        public string Timezones { get; set; }
        public string Translations { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
        public string Emoji { get; set; }
        public string EmojiU { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public short Flag { get; set; }
        public string WikiDataId { get; set; }
        public ICollection<States> States { get; set; }
    }
}
