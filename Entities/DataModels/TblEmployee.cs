using System;
using System.Collections.Generic;

namespace Entities.DataModels
{
    public partial class TblEmployee
    {
        public TblEmployee()
        {
            TblAddresses = new HashSet<TblAddress>();
        }

        public int EmpId { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public int DepartmentId { get; set; }
        public string EmailAddress { get; set; } = null!;
        public int? Experience { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool IsActive { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual TblDepartment Department { get; set; } = null!;
        public virtual ICollection<TblAddress> TblAddresses { get; set; }
    }
}
