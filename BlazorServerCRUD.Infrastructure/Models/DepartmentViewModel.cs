using System.Collections.Generic;

namespace BlazorServerCRUD.Infrastructure.Models
{
    public class DepartmentViewModel
    {
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public bool? IsActive { get; set; }
        public List<EmployeeViewModel> Employees { get; set; }
    }
}