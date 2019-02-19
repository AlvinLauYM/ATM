using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM
{
    public partial class ATM_Services : UserControl
    {
        public Account account { get; set; }
        public ATM_Services()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            account.Check_balance();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string pin_number = PromptDialog.ShowDialog("Pin Number","Change Pin Number");
            account.change_pin(Int32.Parse(pin_number));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string withdraw_money = PromptDialog.ShowDialog("Withdraw", "Amount");
            account.withdraw(double.Parse(withdraw_money));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string transfer_amount = PromptDialog.ShowDialog("Transfer", "Amount");
            string bank_number = PromptDialog.ShowDialog("Bank Number", "Bank Number");
            string bank_type = PromptDialog.ShowDialog("Bank Type", "Bank Type");
            account.transfer_money(double.Parse(transfer_amount), Int32.Parse(bank_number),bank_type);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string deposit_amount = PromptDialog.ShowDialog("Deposit", "Amount");
            account.deposit(double.Parse(deposit_amount));
        }
    }
}
