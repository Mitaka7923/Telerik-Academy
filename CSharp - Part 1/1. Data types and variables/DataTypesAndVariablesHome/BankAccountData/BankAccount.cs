using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountData
{
    class BankAccount
    {
        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public decimal Balance { get; set; }

        public string IBAN { get; set; }

        public string BankName { get; set; }

        public ICollection<CreditCard> LinkedCards { get; set; }
    }
}
