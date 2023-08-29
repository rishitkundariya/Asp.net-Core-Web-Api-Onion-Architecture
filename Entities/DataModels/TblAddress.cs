using System;
using System.Collections.Generic;

namespace Entities.DataModels
{
    public partial class TblAddress
    {
        public int AddressId { get; set; }
        public int EmployeeId { get; set; }
        public string PhysicalAddress { get; set; } = null!;
        public int CountryId { get; set; }
        public bool IsPermentAddress { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual TblCountry Country { get; set; } = null!;
        public virtual TblEmployee Employee { get; set; } = null!;
    }
}
