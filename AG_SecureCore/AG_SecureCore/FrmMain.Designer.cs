
namespace AG_SecureCore
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.PnlSideMenu = new System.Windows.Forms.Panel();
            this.PnlValidatedUserMenu = new System.Windows.Forms.Panel();
            this.Btn_3 = new System.Windows.Forms.Button();
            this.Btn_1 = new System.Windows.Forms.Button();
            this.Btn_2 = new System.Windows.Forms.Button();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.PnlSideMenu.SuspendLayout();
            this.PnlValidatedUserMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlSideMenu
            // 
            this.PnlSideMenu.Controls.Add(this.PnlValidatedUserMenu);
            this.PnlSideMenu.Controls.Add(this.BtnLogin);
            this.PnlSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlSideMenu.Location = new System.Drawing.Point(0, 0);
            this.PnlSideMenu.Name = "PnlSideMenu";
            this.PnlSideMenu.Size = new System.Drawing.Size(171, 585);
            this.PnlSideMenu.TabIndex = 2;
            // 
            // PnlValidatedUserMenu
            // 
            this.PnlValidatedUserMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.PnlValidatedUserMenu.BackColor = System.Drawing.Color.Transparent;
            this.PnlValidatedUserMenu.Controls.Add(this.Btn_3);
            this.PnlValidatedUserMenu.Controls.Add(this.Btn_1);
            this.PnlValidatedUserMenu.Controls.Add(this.Btn_2);
            this.PnlValidatedUserMenu.Location = new System.Drawing.Point(0, 66);
            this.PnlValidatedUserMenu.Name = "PnlValidatedUserMenu";
            this.PnlValidatedUserMenu.Size = new System.Drawing.Size(171, 460);
            this.PnlValidatedUserMenu.TabIndex = 4;
            this.PnlValidatedUserMenu.Visible = false;
            // 
            // Btn_3
            // 
            this.Btn_3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(78)))), ((int)(((byte)(30)))));
            this.Btn_3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_3.ForeColor = System.Drawing.Color.White;
            this.Btn_3.Location = new System.Drawing.Point(10, 125);
            this.Btn_3.Name = "Btn_3";
            this.Btn_3.Size = new System.Drawing.Size(152, 55);
            this.Btn_3.TabIndex = 3;
            this.Btn_3.Text = "OPTTION 4";
            this.Btn_3.UseVisualStyleBackColor = false;
            // 
            // Btn_1
            // 
            this.Btn_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(78)))), ((int)(((byte)(30)))));
            this.Btn_1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_1.ForeColor = System.Drawing.Color.White;
            this.Btn_1.Location = new System.Drawing.Point(10, 4);
            this.Btn_1.Name = "Btn_1";
            this.Btn_1.Size = new System.Drawing.Size(152, 55);
            this.Btn_1.TabIndex = 1;
            this.Btn_1.Text = "OPTTION 2";
            this.Btn_1.UseVisualStyleBackColor = false;
            // 
            // Btn_2
            // 
            this.Btn_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(78)))), ((int)(((byte)(30)))));
            this.Btn_2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_2.ForeColor = System.Drawing.Color.White;
            this.Btn_2.Location = new System.Drawing.Point(10, 64);
            this.Btn_2.Name = "Btn_2";
            this.Btn_2.Size = new System.Drawing.Size(152, 55);
            this.Btn_2.TabIndex = 2;
            this.Btn_2.Text = "OPTTION 3";
            this.Btn_2.UseVisualStyleBackColor = false;
            // 
            // BtnLogin
            // 
            this.BtnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(78)))), ((int)(((byte)(30)))));
            this.BtnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogin.ForeColor = System.Drawing.Color.White;
            this.BtnLogin.Location = new System.Drawing.Point(10, 9);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(152, 55);
            this.BtnLogin.TabIndex = 0;
            this.BtnLogin.Text = "LOGIN";
            this.BtnLogin.UseVisualStyleBackColor = false;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1186, 585);
            this.Controls.Add(this.PnlSideMenu);
            this.DoubleBuffered = true;
            this.IsMdiContainer = true;
            this.Name = "FrmMain";
            this.Text = "FrmMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Controls.SetChildIndex(this.PnlSideMenu, 0);
            this.PnlSideMenu.ResumeLayout(false);
            this.PnlValidatedUserMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlSideMenu;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.Button Btn_3;
        private System.Windows.Forms.Button Btn_2;
        private System.Windows.Forms.Button Btn_1;
        private System.Windows.Forms.Panel PnlValidatedUserMenu;
    }
}