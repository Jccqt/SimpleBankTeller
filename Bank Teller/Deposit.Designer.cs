namespace Bank_Teller
{
    partial class Deposit
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            lblCurrentBalance = new Label();
            label2 = new Label();
            txtDepositAmount = new TextBox();
            label3 = new Label();
            lblNewBalance = new Label();
            label4 = new Label();
            btnDeposit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(14, 131);
            label1.Name = "label1";
            label1.Size = new Size(209, 30);
            label1.TabIndex = 0;
            label1.Text = "Your current balance:";
            // 
            // lblCurrentBalance
            // 
            lblCurrentBalance.AutoSize = true;
            lblCurrentBalance.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCurrentBalance.Location = new Point(229, 131);
            lblCurrentBalance.Name = "lblCurrentBalance";
            lblCurrentBalance.Size = new Size(188, 30);
            lblCurrentBalance.TabIndex = 1;
            lblCurrentBalance.Text = "<Current Balance>";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(14, 187);
            label2.Name = "label2";
            label2.Size = new Size(279, 30);
            label2.TabIndex = 2;
            label2.Text = "Enter the amount of deposit:";
            // 
            // txtDepositAmount
            // 
            txtDepositAmount.BorderStyle = BorderStyle.FixedSingle;
            txtDepositAmount.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDepositAmount.Location = new Point(299, 187);
            txtDepositAmount.MaxLength = 9;
            txtDepositAmount.Name = "txtDepositAmount";
            txtDepositAmount.Size = new Size(218, 35);
            txtDepositAmount.TabIndex = 3;
            txtDepositAmount.TextChanged += txtDepositAmount_TextChanged;
            txtDepositAmount.KeyPress += txtDepositAmount_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(14, 240);
            label3.Name = "label3";
            label3.Size = new Size(181, 30);
            label3.TabIndex = 4;
            label3.Text = "Your new balance:";
            // 
            // lblNewBalance
            // 
            lblNewBalance.AutoSize = true;
            lblNewBalance.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNewBalance.Location = new Point(229, 240);
            lblNewBalance.Name = "lblNewBalance";
            lblNewBalance.Size = new Size(161, 30);
            lblNewBalance.TabIndex = 5;
            lblNewBalance.Text = "<New Balance>";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.RoyalBlue;
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(404, 80);
            label4.TabIndex = 6;
            label4.Text = "Note: \r\n* Smallest amount of deposit will be 0.01.\r\n* Largest amount of deposit will be 100000.99.\r\n* New balance will only reflect when deposit was successful.";
            // 
            // btnDeposit
            // 
            btnDeposit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDeposit.Location = new Point(398, 348);
            btnDeposit.Name = "btnDeposit";
            btnDeposit.Size = new Size(119, 41);
            btnDeposit.TabIndex = 7;
            btnDeposit.Text = "Deposit";
            btnDeposit.UseVisualStyleBackColor = true;
            btnDeposit.Click += btnDeposit_Click;
            // 
            // Deposit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnDeposit);
            Controls.Add(label4);
            Controls.Add(lblNewBalance);
            Controls.Add(label3);
            Controls.Add(txtDepositAmount);
            Controls.Add(label2);
            Controls.Add(lblCurrentBalance);
            Controls.Add(label1);
            Name = "Deposit";
            Size = new Size(628, 450);
            Load += Deposit_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblCurrentBalance;
        private Label label2;
        private TextBox txtDepositAmount;
        private Label label3;
        private Label lblNewBalance;
        private Label label4;
        private Button btnDeposit;
    }
}
