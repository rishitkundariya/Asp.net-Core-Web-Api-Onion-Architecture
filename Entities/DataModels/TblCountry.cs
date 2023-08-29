using System;
using System.Collections.Generic;

namespace Entities.DataModels
{
    public partial class TblCountry
    {
        public TblCountry()
        {
            TblAddresses = new HashSet<TblAddress>();
            TblStates = new HashSet<TblState>();
        }

        public int CoutryId { get; set; }
        public string CountryName { get; set; } = null!;
        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? DeleteAt { get; set; }
        public DateTime Updated { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual ICollection<TblAddress> TblAddresses { get; set; }
        public virtual ICollection<TblState> TblStates { get; set; }
    }
}
