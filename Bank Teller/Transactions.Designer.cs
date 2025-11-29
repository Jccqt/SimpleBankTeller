namespace Bank_Teller
{
    partial class Transactions
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
            label2 = new Label();
            lblCurrentBalance = new Label();
            dataGridTransactions = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridTransactions).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(208, 25);
            label1.Name = "label1";
            label1.Size = new Size(178, 32);
            label1.TabIndex = 0;
            label1.Text = "All Transactions";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(85, 75);
            label2.Name = "label2";
            label2.Size = new Size(165, 30);
            label2.TabIndex = 1;
            label2.Text = "Current balance:";
            // 
            // lblCurrentBalance
            // 
            lblCurrentBalance.AutoSize = true;
            lblCurrentBalance.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCurrentBalance.Location = new Point(256, 75);
            lblCurrentBalance.Name = "lblCurrentBalance";
            lblCurrentBalance.Size = new Size(188, 30);
            lblCurrentBalance.TabIndex = 2;
            lblCurrentBalance.Text = "<Current Balance>";
            // 
            // dataGridTransactions
            // 
            dataGridTransactions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridTransactions.Enabled = false;
            dataGridTransactions.Location = new Point(3, 122);
            dataGridTransactions.Name = "dataGridTransactions";
            dataGridTransactions.Size = new Size(622, 325);
            dataGridTransactions.TabIndex = 3;
            // 
            // Transactions
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridTransactions);
            Controls.Add(lblCurrentBalance);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Transactions";
            Size = new Size(628, 450);
            Load += Transactions_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridTransactions).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label lblCurrentBalance;
        private DataGridView dataGridTransactions;
    }
}
