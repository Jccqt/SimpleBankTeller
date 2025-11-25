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
    public partial class Withdraw : UserControl
    {
        Account account = Account.GetInstance();

        public Withdraw()
        {
            InitializeComponent();
        }

        private void Withdraw_Load(object sender, EventArgs e)
        {
            lblCurrentBalance.Text = account.Balance.ToString("C");
            lblNewBalance.Text = account.Balance.ToString("C");
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            if (txtWithdrawAmount.Text == "" || Convert.ToDecimal(txtWithdrawAmount.Text) <= 0 ||
                Convert.ToDecimal(txtWithdrawAmount.Text) > 100000.99M || Convert.ToDecimal(txtWithdrawAmount.Text) > account.Balance)
            {
                MessageBox.Show("Invalid deposit amount!\nPlease try again.", "Invalid Deposit Amount", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                account.Balance = account.Balance - Convert.ToDecimal(txtWithdrawAmount.Text);
                MessageBox.Show("Withdraw was successful!\nNew balance will now reflect." +
                    "\nTransaction will be saved.", "Withdraw success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                lblCurrentBalance.Text = account.Balance.ToString("C");
                lblNewBalance.Text = account.Balance.ToString("C");

                account.Transactions.Add(new TransactionDTO
                {
                    TransactionDate = DateTime.Now,
                    TransactionType = "Withdraw",
                    Amount = Convert.ToDecimal(txtWithdrawAmount.Text)
                });

                txtWithdrawAmount.Text = "";
            }
        }

        private void txtWithdrawAmount_TextChanged(object sender, EventArgs e)
        {
            if (txtWithdrawAmount.Text == "" || Convert.ToDecimal(txtWithdrawAmount.Text) <= 0)
            {
                lblNewBalance.Text = account.Balance.ToString("C");
            }
            else
            {
                lblNewBalance.Text = (account.Balance - Convert.ToDecimal(txtWithdrawAmount.Text)).ToString("C");
            }
        }

        private void txtWithdrawAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputValidation.FloatingNumbersOnly(sender, e);
        }
    }
}
