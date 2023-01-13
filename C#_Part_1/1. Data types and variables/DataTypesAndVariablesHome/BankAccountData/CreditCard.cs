using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountData
{
    class CreditCard
    {
        public CreditCard(string cardNumber)
        {
            this.CardNumber = cardNumber;
        }

        public string CardNumber { get; set; }
    }
}
