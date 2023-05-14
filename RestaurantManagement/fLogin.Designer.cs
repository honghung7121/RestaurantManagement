namespace RestaurantManagement
{
    partial class fLogin
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
            panel1 = new System.Windows.Forms.Panel();
            txbLoginName = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            panel2 = new System.Windows.Forms.Panel();
            txbPassword = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            btnLogin = new System.Windows.Forms.Button();
            btnExit = new System.Windows.Forms.Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(txbLoginName);
            panel1.Controls.Add(label1);
            panel1.Location = new System.Drawing.Point(12, 21);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(539, 59);
            panel1.TabIndex = 0;
            // 
            // txbLoginName
            // 
            txbLoginName.Location = new System.Drawing.Point(138, 18);
            txbLoginName.Name = "txbLoginName";
            txbLoginName.Size = new System.Drawing.Size(382, 27);
            txbLoginName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(13, 17);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(119, 25);
            label1.TabIndex = 0;
            label1.Text = "Login Name:";
            // 
            // panel2
            // 
            panel2.Controls.Add(txbPassword);
            panel2.Controls.Add(label2);
            panel2.Location = new System.Drawing.Point(12, 86);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(539, 59);
            panel2.TabIndex = 1;
            // 
            // txbPassword
            // 
            txbPassword.Location = new System.Drawing.Point(136, 17);
            txbPassword.Name = "txbPassword";
            txbPassword.Size = new System.Drawing.Size(384, 27);
            txbPassword.TabIndex = 1;
            txbPassword.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(13, 17);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(97, 25);
            label2.TabIndex = 0;
            label2.Text = "Password:";
            // 
            // btnLogin
            // 
            btnLogin.Location = new System.Drawing.Point(323, 164);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new System.Drawing.Size(107, 29);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new System.Drawing.Point(438, 164);
            btnExit.Name = "btnExit";
            btnExit.Size = new System.Drawing.Size(94, 29);
            btnExit.TabIndex = 3;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // fLogin
            // 
            AcceptButton = btnLogin;
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(566, 232);
            Controls.Add(btnExit);
            Controls.Add(btnLogin);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "fLogin";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Login";
            FormClosing += fLogin_Closing;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txbLoginName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txbPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnExit;
    }
}
