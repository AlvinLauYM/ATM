using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM
{
    public class Saving_Account_Interface : IAccount
    {
        public int pin_number { get; set; }
        public double balance { get; set; }

        public Saving_Account_Interface(){}
        public Saving_Account_Interface(double x)
        {
            balance = x;
        }
        public void withdraw(double amount)
        {
            double maximum_amount = 5000;
            double withdraw_amount = amount;
            string message;
            if (amount > balance)
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
                balance = balance - withdraw_amount;
                MessageBox.Show("Balance left: RM" + balance.ToString());
            }

        }

        public void transfer_money(double amount, int bank_number, string bank_type)
        {
            double maximum_amount = 5000;
            double transfer_amount = amount;
            string message;
            if (amount > balance)
            {
                MessageBox.Show("Insufficient balance");
            }
            else if (transfer_amount > maximum_amount)
            {
                MessageBox.Show("You are not allowed to transfer over RM" + maximum_amount);
            }
            else
            {
                MessageBox.Show("Transfering money......");
                balance = balance - transfer_amount;
                MessageBox.Show("Balance left: RM" + balance.ToString());

            }

        }

        public void Check_balance()
        {
            MessageBox.Show("Your balance : RM" + balance);
        }

        public void deposit(double amount)
        {
            balance = balance + amount;
            MessageBox.Show("Balance : RM" + balance);
        }

        public void change_pin(int new_pin)
        {
            pin_number = new_pin;
            MessageBox.Show(pin_number.ToString());
        }
    }
}
