using System;
using System.Collections.Generic;

namespace Entities.DataModels
{
    public partial class TblState
    {
        public int StateId { get; set; }
        public string StateName { get; set; } = null!;
        public int CountryId { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? DeleteAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual TblCountry Country { get; set; } = null!;
    }
}
