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
    public partial class Transactions : UserControl
    {
        Account account = Account.GetInstance();

        public Transactions()
        {
            InitializeComponent();
        }

        private void Transactions_Load(object sender, EventArgs e)
        {
            lblCurrentBalance.Text = account.Balance.ToString("C");

            dataGridTransactions.SuspendLayout();

            dataGridTransactions.AutoGenerateColumns = false;
            dataGridTransactions.Columns.Clear();

            dataGridTransactions.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "TransactionDate",
                DataPropertyName = "TransactionDate",
                HeaderText = "Transaction Date",
                DefaultCellStyle = { Format = "yyyy-MM-dd hh:mm tt" }
            });

            dataGridTransactions.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "TransactionType",
                DataPropertyName = "TransactionType",
                HeaderText = "Type"
            });

            dataGridTransactions.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Amount",
                DataPropertyName = "Amount",
                HeaderText = "Amount",
                DefaultCellStyle = { Format = "C" }
                
            });

            dataGridTransactions.DataSource = account.Transactions;
            dataGridTransactions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridTransactions.ResumeLayout(true);
        }
    }
}
