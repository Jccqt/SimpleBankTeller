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
    public partial class CheckBalance : UserControl
    {
        Account account = Account.GetInstance();

        public CheckBalance()
        {
            InitializeComponent();
        }

        private void CheckBalance_Load(object sender, EventArgs e)
        {
            lblBalance.Text = account.Balance.ToString("C");
        }
    }
}
