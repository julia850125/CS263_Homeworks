using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeLibrary
{
  public   class Manager:Employee 
    {
        private int departmentperformance;
        private int totalSalary;
        public int Departmentperformance
        {
            get { return this.departmentperformance; }
            set
            {
                if (value < 0)
                    this.departmentperformance = 0;
                else
                    this.departmentperformance = value;
            }
        }
        public int TotalSalary
        {
            get { return this.totalSalary; }
            set
            {
                this.totalSalary = (int)base.baseSalary + (int)(this.departmentperformance * 0.2);
            }
        }
        public Manager (string id, string name, int baseSalary, int departmentperformance)
            : base(id, name, baseSalary)
        {
            this.Departmentperformance = departmentperformance;
            this.TotalSalary = totalSalary;
        }
        public Manager(string id, string name, string baseSalary, string departmentperformance)
            : this(id, name, int.Parse(baseSalary), int.Parse(departmentperformance))
        { }
        public override double BaseSalary
        {
            get
            {
                return base.BaseSalary;
            }
            set
            {
                if (value >100000)
                    this.baseSalary = 100000;
                else if (value >= 40000 && value <= 100000)
                    this.baseSalary = value;
                else
                    this.baseSalary = 40000;
            }
        }

        public override string ToString()
        {
            return base.ToString() + string.Format("\n部門業績:{0}\n總薪資:{1}"
                , this.Departmentperformance, this.TotalSalary);
        }
    }
}
