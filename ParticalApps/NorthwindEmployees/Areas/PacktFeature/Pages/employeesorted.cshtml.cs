using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Packt.Shared;

namespace PacktFeatures.Pages
{
    public class EmployeesortedPageModel : PageModel
    {
        private Northwind db;
        public EmployeesortedPageModel  (Northwind injectionContent)
        {
            db = injectionContent;
        }
        
        public IEnumerable<IGrouping<string, Employee>> employeesSorted;

        public void OnGet ()
        {
           employeesSorted = db.Employees.Include(o => o.Orders).AsEnumerable().GroupBy(e => e.City);
        }
    }
}