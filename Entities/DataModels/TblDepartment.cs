using System;
using System.Collections.Generic;

namespace Entities.DataModels
{
    public partial class TblDepartment
    {
        public TblDepartment()
        {
            TblEmployees = new HashSet<TblEmployee>();
        }

        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; } = null!;
        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdateAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public bool? IsDeleted { get; set; }
        public string? Description { get; set; }

        public virtual ICollection<TblEmployee> TblEmployees { get; set; }
    }
}
