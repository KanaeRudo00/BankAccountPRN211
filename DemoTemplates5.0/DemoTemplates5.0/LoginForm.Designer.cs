namespace DemoTemplates5._0
{
    partial class LoginForm
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
            lbUserId = new System.Windows.Forms.Label();
            lbPassword = new System.Windows.Forms.Label();
            lbMessage = new System.Windows.Forms.Label();
            tbUserId = new System.Windows.Forms.TextBox();
            tbPassword = new System.Windows.Forms.TextBox();
            btnLogin = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // lbUserId
            // 
            lbUserId.AutoSize = true;
            lbUserId.Location = new System.Drawing.Point(10, 25);
            lbUserId.Name = "lbUserId";
            lbUserId.Size = new System.Drawing.Size(51, 20);
            lbUserId.TabIndex = 0;
            lbUserId.Text = "UserId";
            lbUserId.UseWaitCursor = true;
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Location = new System.Drawing.Point(10, 75);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new System.Drawing.Size(70, 20);
            lbPassword.TabIndex = 1;
            lbPassword.Text = "Password";
            // 
            // lbMessage
            // 
            lbMessage.AutoSize = true;
            lbMessage.ForeColor = System.Drawing.Color.Red;
            lbMessage.Location = new System.Drawing.Point(13, 124);
            lbMessage.Name = "lbMessage";
            lbMessage.Size = new System.Drawing.Size(0, 20);
            lbMessage.TabIndex = 2;
            lbMessage.UseWaitCursor = true;
            // 
            // tbUserId
            // 
            tbUserId.Location = new System.Drawing.Point(96, 22);
            tbUserId.Name = "tbUserId";
            tbUserId.PlaceholderText = "Please input UserId...";
            tbUserId.Size = new System.Drawing.Size(243, 27);
            tbUserId.TabIndex = 3;
            // 
            // tbPassword
            // 
            tbPassword.Location = new System.Drawing.Point(96, 75);
            tbPassword.Name = "tbPassword";
            tbPassword.PasswordChar = '*';
            tbPassword.PlaceholderText = "Please input Password...";
            tbPassword.Size = new System.Drawing.Size(243, 27);
            tbPassword.TabIndex = 4;
            // 
            // btnLogin
            // 
            btnLogin.Location = new System.Drawing.Point(139, 157);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new System.Drawing.Size(94, 29);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += Login;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(380, 199);
            Controls.Add(btnLogin);
            Controls.Add(tbPassword);
            Controls.Add(tbUserId);
            Controls.Add(lbMessage);
            Controls.Add(lbPassword);
            Controls.Add(lbUserId);
            Name = "LoginForm";
            Text = "LoginForm";
            Load += LoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lbUserId;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Label lbMessage;
        private System.Windows.Forms.TextBox tbUserId;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Button btnLogin;
    }
}