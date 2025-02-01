using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZainCustomerService.DataManagement
{
    /// <summary>
    /// This Simple class only hold the information for
    /// a single SIM (Line) package or subscription
    /// </summary>
    public class Package
    {
        public string Name { get; set; }
        public double simPrice { get; set; }
        public double MonthlyPrice { get; set; }
        public bool IsPrepaidBool { get; set; }
    }
}
