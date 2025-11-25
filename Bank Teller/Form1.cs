

namespace Bank_Teller
{
    public partial class frmStart : Form
    {
        Account account = Account.GetInstance();
        private int failedCounter;

        public frmStart()
        {
            InitializeComponent();
        }

        private void frmStart_Load(object sender, EventArgs e)
        {
            account.PIN = "123456";
            failedCounter = 0;
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            if (txtPIN.Text != account.PIN) // will check if the PIN was invalid
            {
                failedCounter++;
                MessageBox.Show($"Invalid PIN (failed count: {failedCounter}", "Invalid PIN", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

            }

            if (failedCounter == 3) // will check if the failed counter is already 3
            {
                MessageBox.Show("Sorry, you failed to verify your PIN.", "Failed to Verify PIN", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit(); // will exit the application
            }
            else
            {
                account.Balance = 50235.43M;
                var form2 = new Form2();
                form2.Show();
                this.Hide();
            }
        }

        private void txtPIN_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputValidation.WholeNumbersOnly(sender, e);
        }
    }
}
