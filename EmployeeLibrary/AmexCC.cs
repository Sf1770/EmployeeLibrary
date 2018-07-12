using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeLibrary
{
    public class AmexCC : CreditCard
    {
        public string creditCardNum { get; }

        public string cvv { get; }

        public string pin { get; set; }

        public int Offer(int creditScore)
        {
            int discountedFee = 0;
            if ((creditScore >= 650) && (creditScore < 700))
            {
                discountedFee = 15;
            }
            else if (creditScore > 700)
            {
                discountedFee = 25;
            }
            else
            {
                discountedFee = 0;
            }
            return discountedFee;
        }
    }
}
