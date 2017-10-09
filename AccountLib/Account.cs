using System;
using System.Collections.Generic;
using System.Linq;

namespace AccountLib
{
    public class Account
    {
        public Account(string Code, string Description, decimal amount, bool isSummary)
        {
            this.Code = Code;
            this.Description = Description;
            this.amount = amount;
            this.IsSummary = isSummary;
            Children = new List<Account>();
        }
        public string Code;
        private decimal amount;
        public string Description { get; set; }
        public decimal Amount {
            get
            {
                if (IsSummary)
                    return Children.Sum(child => child.Amount);
                return amount;
            }
        }
        public bool IsSummary { get; set; }
        public List<Account> Children { get; set; }
    }
}
