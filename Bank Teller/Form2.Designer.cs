namespace Bank_Teller
{
    partial class Form2
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            btnExit = new Button();
            btnViewTransactions = new Button();
            btnWithdraw = new Button();
            btnDeposit = new Button();
            btnCheckBalance = new Button();
            contentPanel = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnExit);
            panel1.Controls.Add(btnViewTransactions);
            panel1.Controls.Add(btnWithdraw);
            panel1.Controls.Add(btnDeposit);
            panel1.Controls.Add(btnCheckBalance);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(175, 450);
            panel1.TabIndex = 0;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Red;
            btnExit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExit.Location = new Point(22, 402);
            btnExit.Name = "btnExit";
            btnExit.RightToLeft = RightToLeft.No;
            btnExit.Size = new Size(119, 36);
            btnExit.TabIndex = 4;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnViewTransactions
            // 
            btnViewTransactions.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnViewTransactions.Location = new Point(22, 241);
            btnViewTransactions.Name = "btnViewTransactions";
            btnViewTransactions.RightToLeft = RightToLeft.No;
            btnViewTransactions.Size = new Size(119, 55);
            btnViewTransactions.TabIndex = 3;
            btnViewTransactions.Text = "View Transactions";
            btnViewTransactions.UseVisualStyleBackColor = true;
            btnViewTransactions.Click += btnViewTransactions_Click;
            // 
            // btnWithdraw
            // 
            btnWithdraw.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnWithdraw.Location = new Point(22, 169);
            btnWithdraw.Name = "btnWithdraw";
            btnWithdraw.Size = new Size(119, 41);
            btnWithdraw.TabIndex = 2;
            btnWithdraw.Text = "Withdraw";
            btnWithdraw.UseVisualStyleBackColor = true;
            btnWithdraw.Click += btnWithdraw_Click;
            // 
            // btnDeposit
            // 
            btnDeposit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDeposit.Location = new Point(22, 103);
            btnDeposit.Name = "btnDeposit";
            btnDeposit.Size = new Size(119, 41);
            btnDeposit.TabIndex = 1;
            btnDeposit.Text = "Deposit";
            btnDeposit.UseVisualStyleBackColor = true;
            btnDeposit.Click += btnDeposit_Click;
            // 
            // btnCheckBalance
            // 
            btnCheckBalance.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCheckBalance.Location = new Point(22, 34);
            btnCheckBalance.Name = "btnCheckBalance";
            btnCheckBalance.Size = new Size(119, 41);
            btnCheckBalance.TabIndex = 0;
            btnCheckBalance.Text = "Check Balance";
            btnCheckBalance.UseVisualStyleBackColor = true;
            btnCheckBalance.Click += btnCheckBalance_Click;
            // 
            // contentPanel
            // 
            contentPanel.Location = new Point(171, 0);
            contentPanel.Name = "contentPanel";
            contentPanel.Size = new Size(628, 450);
            contentPanel.TabIndex = 1;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(contentPanel);
            Controls.Add(panel1);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            Load += Form2_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnCheckBalance;
        private Button btnDeposit;
        private Button btnWithdraw;
        private Panel contentPanel;
        private Button btnExit;
        private Button btnViewTransactions;
    }
}