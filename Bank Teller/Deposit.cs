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
    public partial class Deposit : UserControl
    {
        Account account = Account.GetInstance();

        public Deposit()
        {
            InitializeComponent();
        }

        private void Deposit_Load(object sender, EventArgs e)
        {
            lblCurrentBalance.Text = account.Balance.ToString("C");
            lblNewBalance.Text = account.Balance.ToString("C");
        }

        private void txtDepositAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputValidation.FloatingNumbersOnly(sender, e);
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            if (txtDepositAmount.Text == "" || Convert.ToDecimal(txtDepositAmount.Text) <= 0 ||
                Convert.ToDecimal(txtDepositAmount.Text) > 100000.99M)
            {
                MessageBox.Show("Invalid deposit amount!\nPlease try again.", "Invalid Deposit Amount", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                account.Balance = account.Balance + Convert.ToDecimal(txtDepositAmount.Text);
                MessageBox.Show("Deposit was successful!\nNew balance will now reflect." +
                    "\nTransaction will be saved.", "Deposit success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                lblCurrentBalance.Text = account.Balance.ToString("C");
                lblNewBalance.Text = account.Balance.ToString("C");

                account.Transactions.Add(new TransactionDTO
                {
                    TransactionDate = DateTime.Now,
                    TransactionType = "Deposit",
                    Amount = Convert.ToDecimal(txtDepositAmount.Text)
                });

                txtDepositAmount.Text = "";
            }
        }

        private void txtDepositAmount_TextChanged(object sender, EventArgs e)
        {
            if(txtDepositAmount.Text == "" || Convert.ToDecimal(txtDepositAmount.Text) <= 0)
            {
                lblNewBalance.Text = account.Balance.ToString("C");
            }
            else
            {
                lblNewBalance.Text = (account.Balance + Convert.ToDecimal(txtDepositAmount.Text)).ToString("C");
            }
        }
    }
}
