﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CW.Models
{
    public class BankCredit : BankItem
    {
        public DateTime Date { get; set; }
        public string PaymentInfo { get; set; }
        public BankCredit(Card bill) : base(bill) { }

        public BankCredit(Credit credit)
        {
            Number = credit.credit_number;
            Currency = credit.credit_currency;
            Money = credit.balance;
            Date = credit.pay_time;
        }
    }
}
