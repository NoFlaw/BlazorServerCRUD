using System;
using System.ComponentModel.DataAnnotations;

namespace BlazorServerCRUD.Infrastructure.Models
{
    public class AddEmployeeViewModel
    {
        public int EmployeeId { get; set; }
        public int DepartmentId { get; set; }
        public string EmployeeName { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? StartDate { get; set; }
        public string PhotoFileName { get; set; }
        public DepartmentViewModel Department { get; set; }
    }
}
