using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Web;

namespace MVC.Lab02.Ex01.WebMVCR1.Models
{
    public enum AccountType
    { 
        Checking, Deposit
    }
    public class StudyCsharp
    {
    }
    public struct BankAccount
    {
        public long accNo;
        public decimal accBal;
        public AccountType accType;
        public override string ToString()
        {
            //string res = String.Format("Номер счета {0}, баланс {1}, тип {2}", accNo, accBal, accType);
            // res;
            string str = $"Номер счета {accNo}, баланс {accBal}, тип {accType}";
            return str;           
        }
    }
}