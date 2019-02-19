using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM
{
    public class Current_Account : Account
    {
        public Current_Account()
        {

        }
        public Current_Account(double x)
        {
            setBalance(x);
        }
        public override void transfer_money(double amount, int bank_number, string bank_type)
        { 
            double transfer_amount = amount;
            string message;
            if (amount > getBalance())
            {
                MessageBox.Show("Insufficient balance");
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
