using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Packt.Shared;

namespace PacktFeatures.Pages
{
    public class EmployeeInfoPageModel : PageModel
    {
        private Northwind db;

        [BindProperty]
        public int id {get;set;}

        public EmployeeInfoPageModel(Northwind injectedContext)
        {
            db = injectedContext;
        }

        public Employee Employee { get; set; }

        public void OnGet()
        {
            Employee = db.Employees.First(e => e.EmployeeID == id);
        }
    }
}
