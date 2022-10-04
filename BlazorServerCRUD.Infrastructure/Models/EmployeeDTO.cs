using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorServerCRUD.Infrastructure.Models
{
    public class EmployeeDTO
    {
        public int EmployeeId { get; set; }
        public int DepartmentId { get; set; }
        public string EmployeeName { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? StartDate { get; set; }
        public string PhotoFileName { get; set; }
        public string DepartmentName { get; set; }
        public DepartmentDTO Department { get; set; }
    }
}
