using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeLibrary
{
    public class Sales : Employee
    {
        private int performance;
        private int  totalSalary;
        public int Performance
        {
            get { return this.performance; }
            set
            {
                if (value < 0)
                    this.performance = 0;
                else
                    this.performance = value;
            }
        }
        public int TotalSalary
        {
            get { return this.totalSalary; }
            set
            {
                this.totalSalary = (int)base.baseSalary + (int)(this.performance*0.5);
            }
        }
        public Sales(string id, string name, int baseSalary, int performance)
            : base(id, name, baseSalary)
        {
            this.Performance = performance;
            this.TotalSalary = totalSalary;
        }
        
        public Sales(string id, string name, string baseSalary, string performance)
            : this(id, name, int.Parse(baseSalary), int.Parse(performance))
        { }

     public override double BaseSalary
        {
            get
            {
                return base.BaseSalary;
            }
            set
            {
                if (value > 40000)
                    this.baseSalary = 40000;
                else if (value >= 22000 && value <= 40000)
                    this.baseSalary = value;
                else
                    this.baseSalary = 22000;
            }
        }
        public override string ToString()
        {
            return base.ToString() + string.Format("\n業績:{0}\n總薪資:{1}"
                , this.Performance, this.TotalSalary);
        }
    }
}