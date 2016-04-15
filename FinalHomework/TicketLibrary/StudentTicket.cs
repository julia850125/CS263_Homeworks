using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketLibrary
{
 public    class StudentTicket:Ticket 
    {
        public double studenttotalPrice;
        public double StudentTotalPrice
        {
            get { return this.studenttotalPrice; }
            set
            {
                this.studenttotalPrice = this.Number * this.Price * 0.8;
            }
        }
        public StudentTicket(int  number, int price) 
            :base(number,price)
        { this.StudentTotalPrice = studenttotalPrice; }
        public StudentTicket(string number, string price)
            : this(int.Parse (number),int.Parse ( price))
        { }

        
        public override string ToString()
        {   
            return base.ToString() + string.Format("\n使用學生優惠後的總價為:{0}"
            ,this.StudentTotalPrice    );
            
        }
    }
}
