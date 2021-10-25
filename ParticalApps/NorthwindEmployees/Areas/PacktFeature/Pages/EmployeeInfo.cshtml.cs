using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Packt.Shared;

namespace PacktFeatures.Pages
{
    public class EmployeeInfoPageModel : PageModel
    {
        private readonly Northwind db;

        [BindProperty(SupportsGet = true)]
        public int ID { get; set; }

        public EmployeeInfoPageModel(Northwind injectedContext)
        {
            db = injectedContext;
        }

        [BindProperty]
        public Employee Employee { get; set; }

        public void OnGet()
        {
            Employee = db.Employees
            .Where(e => e.Address != null)
            .Include(o => o.Orders)
            .ThenInclude(o => o.OrderDetails)         
            .FirstOrDefault();
        }
    }
}
