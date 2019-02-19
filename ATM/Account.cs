using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM
{
    public abstract class Account
    {
        private int pin_number;
        private double balance;

        public void Check_balance() {
            MessageBox.Show("Your balance : RM" + balance);
        }
        public virtual void withdraw(double amount)
        {
            double withdraw_amount = amount;

            if (amount > balance)
            {
                MessageBox.Show("Insufficient balance");
            }
            else {
                MessageBox.Show("Dispensing money......");
                balance = balance - withdraw_amount;
                MessageBox.Show("Balance left: RM" + balance.ToString());

            }
        }
        public void deposit(double amount)
        {
            balance = balance + amount;
            MessageBox.Show("Balance : RM" + balance);
        }
        public abstract void transfer_money(double amount, int bank_number, string bank_type);
        public void change_pin(int new_pin)
        {
            pin_number = new_pin;
            MessageBox.Show(pin_number.ToString());
        }

        public double getBalance() { return balance; }
        public void setBalance(double x) { balance = x; }
    }
}
