using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareMetrics_2_Inheritance
{
    class InheritanceExample
    {
    }

    class DateRange
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
    class Base
    {
        public DateTime ActionDate { get; set; }
    }

    class Child1 :Base
    {
        //public bool IsActionExpired()
        //{
        //    return ActionDate < DateTime.Now;
        //}
    }

    class Child2: Child1
    {
        //public DateRange Range { get; set; }
        //public bool IsInRange()
        //{
        //    return ActionDate > Range.StartDate && ActionDate < Range.EndDate;
        //}
    }
}
