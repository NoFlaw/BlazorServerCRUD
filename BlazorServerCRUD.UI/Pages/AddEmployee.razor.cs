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
    public class AddEmployeeBase : ComponentBase
    {
        public AddEmployeeViewModel NewEmployee = new AddEmployeeViewModel();
        
        [Inject] public HelperService HelperService { get; set; }
        [Inject] public IEmployeeService EmployeeService { get; set; }
        

        protected async void CreateEmployee()
        {
            await EmployeeService.AddEmployeeViewModelAsync(NewEmployee);            
            HelperService.NavigateTo("/Employees", true);
        }
        
        protected void Cancel()
        {
            HelperService.NavigateTo("/Employees", false);
        }
    }
}
