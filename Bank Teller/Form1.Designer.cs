namespace Bank_Teller
{
    partial class frmStart
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtPIN = new TextBox();
            btnVerify = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(154, 34);
            label1.Name = "label1";
            label1.Size = new Size(159, 21);
            label1.TabIndex = 0;
            label1.Text = "Please enter your PIN";
            // 
            // txtPIN
            // 
            txtPIN.BorderStyle = BorderStyle.FixedSingle;
            txtPIN.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPIN.Location = new Point(165, 77);
            txtPIN.MaxLength = 6;
            txtPIN.Name = "txtPIN";
            txtPIN.PasswordChar = '*';
            txtPIN.Size = new Size(136, 33);
            txtPIN.TabIndex = 1;
            txtPIN.KeyPress += txtPIN_KeyPress;
            // 
            // btnVerify
            // 
            btnVerify.FlatStyle = FlatStyle.Popup;
            btnVerify.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVerify.Location = new Point(180, 134);
            btnVerify.Name = "btnVerify";
            btnVerify.Size = new Size(99, 36);
            btnVerify.TabIndex = 2;
            btnVerify.Text = "Verify PIN ";
            btnVerify.UseVisualStyleBackColor = true;
            btnVerify.Click += btnVerify_Click;
            // 
            // frmStart
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(471, 182);
            Controls.Add(btnVerify);
            Controls.Add(txtPIN);
            Controls.Add(label1);
            Name = "frmStart";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += frmStart_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtPIN;
        private Button btnVerify;
    }
}
