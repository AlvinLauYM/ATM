using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM
{
    public class Saving_Account : Account
    {
        public Saving_Account()
        {

        }
        public Saving_Account(double x)
        {
            setBalance(x);
        }
        public override void withdraw(double amount)
        {
            double maximum_amount = 5000;
            double withdraw_amount = amount;
            string message;
            if (amount > getBalance())
            {
                MessageBox.Show("Insufficient balance");
            }
            else if (withdraw_amount > maximum_amount)
            {
                MessageBox.Show("You are not allowed to withdraw over RM" + maximum_amount);
            }
            else
            {
                MessageBox.Show("Dispensing money......");
                setBalance(getBalance() - withdraw_amount);
                MessageBox.Show("Balance left: RM" + getBalance().ToString());
            }

        }

        public override void transfer_money(double amount, int bank_number, string bank_type)
        {
            double maximum_amount = 5000;
            double transfer_amount = amount;
            string message;
            if (amount > getBalance())
            {
                MessageBox.Show("Insufficient balance");
            }
            else if(transfer_amount > maximum_amount)
            {
                MessageBox.Show("You are not allowed to transfer over RM" + maximum_amount);
            }
            else
            {
                MessageBox.Show("Transfering money......");
                setBalance(getBalance() - transfer_amount);
                MessageBox.Show("Balance left: RM" + getBalance().ToString());

            }

        }
     



    }
}
