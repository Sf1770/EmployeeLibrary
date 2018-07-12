using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeLibrary
{
    interface CreditCard
    {
        string creditCardNum { get; }
        string cvv { get; }
        string pin { get; set; }
        int Offer(int creditScore);
    }
}

