using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace ATM
{
    public partial class ATM : Form
    {
       
        public ATM()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            atM_Services1.Visible = true;
            button1.Visible = false;
            button2.Visible = false;
            button6.Visible = true;
            atM_Services1.account = new Saving_Account_Interface(7000);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            atM_Services1.Visible = false;
            button1.Visible = true;
            button2.Visible = true;
            button6.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            atM_Services1.Visible = true;
            button1.Visible = false;
            button2.Visible = false;
            button6.Visible = true;
            atM_Services1.account = new Current_Account_Interface(7500);
        }
    }
}
