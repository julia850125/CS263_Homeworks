using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketLibrary
{
    public class ChildTicket : Ticket
    {
        private int age;
       
        public int Age { get { return this.age; }
            set { this.age = value; }
             }

        public ChildTicket(int number, int price, int age)
            : base(number, price)
        {
            this.Age = age;
            this.ChildTotalPrice = childtotalPrice;
        }
       

       
        private double  childtotalPrice;
        public double  ChildTotalPrice
        {
            get { return this.childtotalPrice; }
            set
            {
                if (this.age>=12)
                    this.childtotalPrice = this.Number * this.Price;
                else if (this.age >=7&& this.age < 12)
                    this.childtotalPrice = this.Number * this.Price * 0.5;
                else if (this.age >=0&& this.age<7)
                    this.childtotalPrice = this.Number * this.Price * 0.1;
            }
        }
        public ChildTicket(string number, string price, string age)
            : this(int.Parse(number), int.Parse(price), int.Parse(age))
        { }

        public override string ToString()
        {
            if (this.Age >= 12)
            {
                return base.ToString() + string.Format("\n年齡為{0}歲,無法使用兒童優惠，總價為:{1}"
                , this.Age, this.ChildTotalPrice);
            }
            else {
                return base.ToString() + string.Format("\n年齡為{0}歲,使用兒童優惠後的總價為:{1}"
                 , this.Age, this.ChildTotalPrice);
            }
        }
        }

    }


