using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Packt.Shared;

namespace PacktFeatures.Pages
{
    public class EmployeeInfoPageModel : PageModel
    {
        private Northwind db;

        [BindProperty(SupportsGet = true)]
        public int id {get;set;}

        public EmployeeInfoPageModel(Northwind injectedContext)
        {
            db = injectedContext;
        }

        public Employee Employee { get; set; }

        public void OnGet()
        {
            //Employee = db.Employees.FirstOrDefault(e => e.EmployeeID == id);
            Employee = db.Employees.Include(o => o.Orders).Where(e => e.EmployeeID == id).FirstOrDefault();
            // db.Entry(Employee)
            //     .Collection(c => c.Orders)
            //     .Load();
        }
    }
}
