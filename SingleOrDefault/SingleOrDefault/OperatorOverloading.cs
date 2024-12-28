using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleOrDefault
{
    internal class OperatorOverloading
    {
        public class Ticket
        {
            public int paybleAmount;

            public Ticket(int paybleAmount)
            {
                this.paybleAmount = paybleAmount;   
            }

            public static Ticket operator +(Ticket a, Ticket b)
            {
                return new Ticket(a.paybleAmount + b.paybleAmount);
            }
        }
       
    }
}
