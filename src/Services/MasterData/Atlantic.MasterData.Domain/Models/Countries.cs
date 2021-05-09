using System.Collections.Generic;
namespace Atlantic.MasterData.Domain.Models {
    public class Countries {
        public int Id { get; set; }
        public string Name { get; set; }
        public short Flag { get; set; }
        public ICollection<States> States { get; set; }
        public ICollection<Cities> Cities { get; set; }
    }

}


