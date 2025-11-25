using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Teller
{
    public class Account
    {
        private static Account instance;

        private Account()
        {
            
        }

        public static Account GetInstance()
        {
            if(instance == null)
            {
                instance = new Account();
            }

            return instance;
        }

        public string PIN { get; set; } = "";
        public decimal Balance { get; set; }

        public List<TransactionDTO> Transactions { get; set; } = [];
    }
}
