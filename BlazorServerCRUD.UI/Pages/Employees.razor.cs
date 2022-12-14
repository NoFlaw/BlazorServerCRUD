using BlazorServerCRUD.Infrastructure.Models;
using BlazorServerCRUD.Service;
using BlazorServerCRUD.UI.Service;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorServerCRUD.UI.Pages
{
    public class EmployeesBase : ComponentBase
    {
        public List<EmployeeViewModel> EmployeeList;

        [Inject] public HelperService HelperService { get; set; }
        [Inject] public IEmployeeService EmployeeService { get; set; }

        protected override async Task OnInitializedAsync()
        {
            EmployeeList = await Task.Run(() => EmployeeService.GetAllEmployeeViewModel());
        }
    }
}
