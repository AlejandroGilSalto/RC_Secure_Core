
namespace AG_SecureCore
{
    partial class FrmLogin
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
            this.TbxUsername = new System.Windows.Forms.TextBox();
            this.LblUser = new System.Windows.Forms.Label();
            this.Lblpass = new System.Windows.Forms.Label();
            this.TbxPassword = new System.Windows.Forms.TextBox();
            this.LblHeader = new System.Windows.Forms.Label();
            this.BtnConfirm = new System.Windows.Forms.Button();
            this.Btn_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TbxUsername
            // 
            this.TbxUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(68)))), ((int)(((byte)(75)))));
            this.TbxUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbxUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbxUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(236)))), ((int)(((byte)(225)))));
            this.TbxUsername.Location = new System.Drawing.Point(105, 93);
            this.TbxUsername.Name = "TbxUsername";
            this.TbxUsername.Size = new System.Drawing.Size(263, 22);
            this.TbxUsername.TabIndex = 1;
            this.TbxUsername.Enter += new System.EventHandler(this.Txb_enter);
            this.TbxUsername.Leave += new System.EventHandler(this.Txb_leave);
            // 
            // LblUser
            // 
            this.LblUser.AutoSize = true;
            this.LblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(112)))), ((int)(((byte)(61)))));
            this.LblUser.Location = new System.Drawing.Point(12, 95);
            this.LblUser.Name = "LblUser";
            this.LblUser.Size = new System.Drawing.Size(81, 17);
            this.LblUser.TabIndex = 2;
            this.LblUser.Text = "Username";
            // 
            // Lblpass
            // 
            this.Lblpass.AutoSize = true;
            this.Lblpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lblpass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(112)))), ((int)(((byte)(61)))));
            this.Lblpass.Location = new System.Drawing.Point(16, 126);
            this.Lblpass.Name = "Lblpass";
            this.Lblpass.Size = new System.Drawing.Size(77, 17);
            this.Lblpass.TabIndex = 3;
            this.Lblpass.Text = "Password";
            // 
            // TbxPassword
            // 
            this.TbxPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(68)))), ((int)(((byte)(75)))));
            this.TbxPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbxPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(236)))), ((int)(((byte)(225)))));
            this.TbxPassword.Location = new System.Drawing.Point(105, 124);
            this.TbxPassword.Name = "TbxPassword";
            this.TbxPassword.Size = new System.Drawing.Size(263, 22);
            this.TbxPassword.TabIndex = 2;
            this.TbxPassword.UseSystemPasswordChar = true;
            this.TbxPassword.Enter += new System.EventHandler(this.Txb_enter);
            this.TbxPassword.Leave += new System.EventHandler(this.Txb_leave);
            this.TbxPassword.Validated += new System.EventHandler(this.BtnConfirm_Click);
            // 
            // LblHeader
            // 
            this.LblHeader.AutoSize = true;
            this.LblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.LblHeader.Location = new System.Drawing.Point(64, 35);
            this.LblHeader.Name = "LblHeader";
            this.LblHeader.Size = new System.Drawing.Size(261, 29);
            this.LblHeader.TabIndex = 5;
            this.LblHeader.Text = "LOGIN TO CONTINUE";
            // 
            // BtnConfirm
            // 
            this.BtnConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(78)))), ((int)(((byte)(30)))));
            this.BtnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.BtnConfirm.Location = new System.Drawing.Point(225, 169);
            this.BtnConfirm.Name = "BtnConfirm";
            this.BtnConfirm.Size = new System.Drawing.Size(143, 35);
            this.BtnConfirm.TabIndex = 7;
            this.BtnConfirm.Text = "Confirm";
            this.BtnConfirm.UseVisualStyleBackColor = false;
            this.BtnConfirm.Click += new System.EventHandler(this.BtnConfirm_Click);
            // 
            // Btn_Cancel
            // 
            this.Btn_Cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(78)))), ((int)(((byte)(30)))));
            this.Btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.Btn_Cancel.Location = new System.Drawing.Point(19, 169);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.Size = new System.Drawing.Size(143, 35);
            this.Btn_Cancel.TabIndex = 7;
            this.Btn_Cancel.Text = "Cancel";
            this.Btn_Cancel.UseVisualStyleBackColor = false;
            this.Btn_Cancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 219);
            this.Controls.Add(this.Btn_Cancel);
            this.Controls.Add(this.BtnConfirm);
            this.Controls.Add(this.LblHeader);
            this.Controls.Add(this.Lblpass);
            this.Controls.Add(this.LblUser);
            this.Controls.Add(this.TbxPassword);
            this.Controls.Add(this.TbxUsername);
            this.Name = "FrmLogin";
            this.Text = "LoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TbxUsername;
        private System.Windows.Forms.Label LblUser;
        private System.Windows.Forms.Label Lblpass;
        private System.Windows.Forms.TextBox TbxPassword;
        private System.Windows.Forms.Label LblHeader;
        private System.Windows.Forms.Button BtnConfirm;
        private System.Windows.Forms.Button Btn_Cancel;
    }
}