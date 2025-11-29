namespace Bank_Teller
{
    partial class Withdraw
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
            btnWithdraw = new Button();
            label4 = new Label();
            lblNewBalance = new Label();
            label3 = new Label();
            txtWithdrawAmount = new TextBox();
            label2 = new Label();
            lblCurrentBalance = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnWithdraw
            // 
            btnWithdraw.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnWithdraw.Location = new Point(422, 346);
            btnWithdraw.Name = "btnWithdraw";
            btnWithdraw.Size = new Size(119, 41);
            btnWithdraw.TabIndex = 15;
            btnWithdraw.Text = "Withdraw";
            btnWithdraw.UseVisualStyleBackColor = true;
            btnWithdraw.Click += btnWithdraw_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.RoyalBlue;
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(415, 80);
            label4.TabIndex = 14;
            label4.Text = "Note: \r\n* Smallest amount of withdraw will be 0.01.\r\n* Largest amount of withdraw will be 100000.99.\r\n* New balance will only reflect when withdraw was successful.";
            // 
            // lblNewBalance
            // 
            lblNewBalance.AutoSize = true;
            lblNewBalance.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNewBalance.Location = new Point(253, 253);
            lblNewBalance.Name = "lblNewBalance";
            lblNewBalance.Size = new Size(161, 30);
            lblNewBalance.TabIndex = 13;
            lblNewBalance.Text = "<New Balance>";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(38, 253);
            label3.Name = "label3";
            label3.Size = new Size(181, 30);
            label3.TabIndex = 12;
            label3.Text = "Your new balance:";
            // 
            // txtWithdrawAmount
            // 
            txtWithdrawAmount.BorderStyle = BorderStyle.FixedSingle;
            txtWithdrawAmount.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtWithdrawAmount.Location = new Point(330, 200);
            txtWithdrawAmount.MaxLength = 9;
            txtWithdrawAmount.Name = "txtWithdrawAmount";
            txtWithdrawAmount.Size = new Size(218, 35);
            txtWithdrawAmount.TabIndex = 11;
            txtWithdrawAmount.TextChanged += txtWithdrawAmount_TextChanged;
            txtWithdrawAmount.KeyPress += txtWithdrawAmount_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(38, 200);
            label2.Name = "label2";
            label2.Size = new Size(295, 30);
            label2.TabIndex = 10;
            label2.Text = "Enter the amount of withdraw:";
            // 
            // lblCurrentBalance
            // 
            lblCurrentBalance.AutoSize = true;
            lblCurrentBalance.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCurrentBalance.Location = new Point(253, 144);
            lblCurrentBalance.Name = "lblCurrentBalance";
            lblCurrentBalance.Size = new Size(188, 30);
            lblCurrentBalance.TabIndex = 9;
            lblCurrentBalance.Text = "<Current Balance>";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(38, 144);
            label1.Name = "label1";
            label1.Size = new Size(209, 30);
            label1.TabIndex = 8;
            label1.Text = "Your current balance:";
            // 
            // Withdraw
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnWithdraw);
            Controls.Add(label4);
            Controls.Add(lblNewBalance);
            Controls.Add(label3);
            Controls.Add(txtWithdrawAmount);
            Controls.Add(label2);
            Controls.Add(lblCurrentBalance);
            Controls.Add(label1);
            Name = "Withdraw";
            Size = new Size(628, 450);
            Load += Withdraw_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnWithdraw;
        private Label label4;
        private Label lblNewBalance;
        private Label label3;
        private TextBox txtWithdrawAmount;
        private Label label2;
        private Label lblCurrentBalance;
        private Label label1;
    }
}
