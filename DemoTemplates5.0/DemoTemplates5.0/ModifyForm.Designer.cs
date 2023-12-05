namespace DemoTemplates5._0
{
    partial class ModifyForm
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
            btnSubmit = new System.Windows.Forms.Button();
            btnCancel = new System.Windows.Forms.Button();
            lbId = new System.Windows.Forms.Label();
            lbName = new System.Windows.Forms.Label();
            lbBranchName = new System.Windows.Forms.Label();
            lbType = new System.Windows.Forms.Label();
            lbOpenDate = new System.Windows.Forms.Label();
            ipOpenDate = new System.Windows.Forms.DateTimePicker();
            ipType = new System.Windows.Forms.ComboBox();
            ipId = new System.Windows.Forms.TextBox();
            ipBranchName = new System.Windows.Forms.TextBox();
            ipAccountName = new System.Windows.Forms.TextBox();
            SuspendLayout();
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new System.Drawing.Point(128, 394);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new System.Drawing.Size(94, 29);
            btnSubmit.TabIndex = 7;
            btnSubmit.Text = "Add";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += Submit;
            // 
            // btnCancel
            // 
            btnCancel.Location = new System.Drawing.Point(261, 394);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(94, 29);
            btnCancel.TabIndex = 8;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += Cancel;
            // 
            // lbId
            // 
            lbId.AutoSize = true;
            lbId.Location = new System.Drawing.Point(28, 42);
            lbId.Name = "lbId";
            lbId.Size = new System.Drawing.Size(22, 20);
            lbId.TabIndex = 9;
            lbId.Text = "Id";
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Location = new System.Drawing.Point(28, 115);
            lbName.Name = "lbName";
            lbName.Size = new System.Drawing.Size(49, 20);
            lbName.TabIndex = 10;
            lbName.Text = "Name";
            // 
            // lbBranchName
            // 
            lbBranchName.AutoSize = true;
            lbBranchName.Location = new System.Drawing.Point(28, 185);
            lbBranchName.Name = "lbBranchName";
            lbBranchName.Size = new System.Drawing.Size(94, 20);
            lbBranchName.TabIndex = 11;
            lbBranchName.Text = "BranchName";
            // 
            // lbType
            // 
            lbType.AutoSize = true;
            lbType.Location = new System.Drawing.Point(28, 251);
            lbType.Name = "lbType";
            lbType.Size = new System.Drawing.Size(40, 20);
            lbType.TabIndex = 12;
            lbType.Text = "Type";
            // 
            // lbOpenDate
            // 
            lbOpenDate.AutoSize = true;
            lbOpenDate.Location = new System.Drawing.Point(28, 321);
            lbOpenDate.Name = "lbOpenDate";
            lbOpenDate.Size = new System.Drawing.Size(50, 20);
            lbOpenDate.TabIndex = 13;
            lbOpenDate.Text = "label5";
            // 
            // ipOpenDate
            // 
            ipOpenDate.CustomFormat = "dd/MM/yyyy";
            ipOpenDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            ipOpenDate.Location = new System.Drawing.Point(128, 316);
            ipOpenDate.Name = "ipOpenDate";
            ipOpenDate.Size = new System.Drawing.Size(104, 27);
            ipOpenDate.TabIndex = 14;
            // 
            // ipType
            // 
            ipType.DisplayMember = "Text";
            ipType.FormattingEnabled = true;
            ipType.Location = new System.Drawing.Point(128, 248);
            ipType.Name = "ipType";
            ipType.Size = new System.Drawing.Size(284, 28);
            ipType.TabIndex = 15;
            ipType.ValueMember = "Value";
            // 
            // ipId
            // 
            ipId.Location = new System.Drawing.Point(128, 39);
            ipId.Name = "ipId";
            ipId.Size = new System.Drawing.Size(284, 27);
            ipId.TabIndex = 16;
            // 
            // ipBranchName
            // 
            ipBranchName.Location = new System.Drawing.Point(128, 182);
            ipBranchName.Name = "ipBranchName";
            ipBranchName.Size = new System.Drawing.Size(284, 27);
            ipBranchName.TabIndex = 17;
            // 
            // ipAccountName
            // 
            ipAccountName.Location = new System.Drawing.Point(128, 112);
            ipAccountName.Name = "ipAccountName";
            ipAccountName.Size = new System.Drawing.Size(284, 27);
            ipAccountName.TabIndex = 18;
            // 
            // ModifyForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(444, 450);
            Controls.Add(ipAccountName);
            Controls.Add(ipBranchName);
            Controls.Add(ipId);
            Controls.Add(ipType);
            Controls.Add(ipOpenDate);
            Controls.Add(lbOpenDate);
            Controls.Add(lbType);
            Controls.Add(lbBranchName);
            Controls.Add(lbName);
            Controls.Add(lbId);
            Controls.Add(btnCancel);
            Controls.Add(btnSubmit);
            Name = "ModifyForm";
            Text = "ModifyForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbBranchName;
        private System.Windows.Forms.Label lbType;
        private System.Windows.Forms.Label lbOpenDate;
        private System.Windows.Forms.DateTimePicker ipOpenDate;
        private System.Windows.Forms.ComboBox ipType;
        private System.Windows.Forms.TextBox ipId;
        private System.Windows.Forms.TextBox ipBranchName;
        private System.Windows.Forms.TextBox ipAccountName;
    }
}