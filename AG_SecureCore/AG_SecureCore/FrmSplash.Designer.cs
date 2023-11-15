
namespace AG_SecureCore
{
    partial class FrmSplash
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.PbrLoading = new System.Windows.Forms.ProgressBar();
            this.PbLoadingIcon = new System.Windows.Forms.PictureBox();
            this.TmrLoading = new System.Windows.Forms.Timer(this.components);
            this.LblPercent = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PbLoadingIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // PbrLoading
            // 
            this.PbrLoading.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PbrLoading.Location = new System.Drawing.Point(12, 347);
            this.PbrLoading.MarqueeAnimationSpeed = 1000;
            this.PbrLoading.Name = "PbrLoading";
            this.PbrLoading.Size = new System.Drawing.Size(776, 23);
            this.PbrLoading.Step = 1;
            this.PbrLoading.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.PbrLoading.TabIndex = 0;
            // 
            // PbLoadingIcon
            // 
            this.PbLoadingIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PbLoadingIcon.Location = new System.Drawing.Point(291, 118);
            this.PbLoadingIcon.Name = "PbLoadingIcon";
            this.PbLoadingIcon.Size = new System.Drawing.Size(200, 200);
            this.PbLoadingIcon.TabIndex = 1;
            this.PbLoadingIcon.TabStop = false;
            // 
            // TmrLoading
            // 
            this.TmrLoading.Enabled = true;
            this.TmrLoading.Interval = 70;
            this.TmrLoading.Tick += new System.EventHandler(this.TmrLoading_Tick);
            // 
            // LblPercent
            // 
            this.LblPercent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblPercent.AutoSize = true;
            this.LblPercent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(236)))), ((int)(((byte)(225)))));
            this.LblPercent.Location = new System.Drawing.Point(760, 327);
            this.LblPercent.Name = "LblPercent";
            this.LblPercent.Size = new System.Drawing.Size(28, 17);
            this.LblPercent.TabIndex = 2;
            this.LblPercent.Text = "0%";
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(12, 299);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 42);
            this.button1.TabIndex = 3;
            this.button1.Text = "skip load just for testing";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // FrmSplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 378);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LblPercent);
            this.Controls.Add(this.PbLoadingIcon);
            this.Controls.Add(this.PbrLoading);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "FrmSplash";
            this.Text = "Form1";
            this.Controls.SetChildIndex(this.PbrLoading, 0);
            this.Controls.SetChildIndex(this.PbLoadingIcon, 0);
            this.Controls.SetChildIndex(this.LblPercent, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.PbLoadingIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar PbrLoading;
        private System.Windows.Forms.PictureBox PbLoadingIcon;
        private System.Windows.Forms.Timer TmrLoading;
        private System.Windows.Forms.Label LblPercent;
        private System.Windows.Forms.Button button1;
    }
}

