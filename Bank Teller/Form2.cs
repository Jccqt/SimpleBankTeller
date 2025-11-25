using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank_Teller
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // will only add the new control on first load
            var checkBalance = new CheckBalance();
            contentPanel.Controls.Add(checkBalance);
        }

        private void btnCheckBalance_Click(object sender, EventArgs e)
        {
            // will clear the past control and add the new control
            contentPanel.Controls.Clear();
            var checkBalance = new CheckBalance();
            contentPanel.Controls.Add(checkBalance);
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            // will clear the past control and add the new control
            contentPanel.Controls.Clear();
            var deposit = new Deposit();
            contentPanel.Controls.Add(deposit);
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            // will clear the past control and add the new control
            contentPanel.Controls.Clear();
            var withdraw = new Withdraw();
            contentPanel.Controls.Add(withdraw);
        }

        private void btnViewTransactions_Click(object sender, EventArgs e)
        {
            // will clear the past control and add the new control
            contentPanel.Controls.Clear();
            var viewTransactions = new Transactions();
            contentPanel.Controls.Add(viewTransactions);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult exitDiag = MessageBox.Show("Are you sure you want to exit the application?\n" +
                "Any unsaved changes will be lost!", "Exit Application", MessageBoxButtons.YesNo, 
                MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

            if(exitDiag == DialogResult.Yes)
            {
                Application.Exit(); // will exit the application
            }
        }
    }
}
