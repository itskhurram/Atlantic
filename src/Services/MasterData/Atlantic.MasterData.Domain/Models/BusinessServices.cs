using System;
namespace Atlantic.MasterData.Domain.Models {
    public class BusinessServices {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public short Flag { get; set; }
    }
}
