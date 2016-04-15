using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketLibrary
{
    public class Ticket
    {
        public double totalPrice;
        virtual public double TotalPrice
        {
            get { return this.totalPrice; }
            set
            {
                this.totalPrice = this.Number * this.Price;
            }
        }
        public Ticket() { }
        public Ticket(int number, int price) {
            this.Number = number;
            this.Price = price;
            this.TotalPrice = totalPrice;
        }
        public Ticket(string number, string price)
            :this(int.Parse(number),int.Parse(price) )
        {
            

        }
        public double  Number { get; set; }
        public double  Price{ get; set; }
       

        public override string ToString()
        {
            string result = string.Empty;
            result += string.Format("購票成功！所購買的票張數:{0}\n 票價:{1}\n",
                this.Number , this.Price );
            result += string.Format("總價:{0}", this.TotalPrice );
            return result;
        }
    }
}
