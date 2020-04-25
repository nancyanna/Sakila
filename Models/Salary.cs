using System;
using System.Collections.Generic;

namespace sakila1.Models
{
    public partial class Salary
    {
        public int SalaryId { get; set; }
        public int EmployeeNum { get; set; }
        public decimal Amount { get; set; }
        public DateTime EffectiveDate { get; set; }
    }
}
