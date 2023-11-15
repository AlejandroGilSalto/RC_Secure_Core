using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AG_SecureCore
{
    public partial class FrmSplash : FrmBigScreenBase
    {
        private readonly Random rand;
        private readonly LoadingGraphic loadingIcon;
        private FrmMain mainForm;


        public FrmSplash()
        {
            InitializeComponent();
            LblPercent.ForeColor = textColor;
            rand = new Random(Environment.TickCount);
            loadingIcon = new LoadingGraphic(PbLoadingIcon,backgroundColor,accentColor);
            BackColor = backgroundColor;
        }

        private void TmrLoading_Tick(object sender, EventArgs e)
        {
            loadingIcon.step();
            if (rand.Next(1, 100) < 70)
            {
                PbrLoading.PerformStep();
                String percent =  (((double)PbrLoading.Value / PbrLoading.Maximum)*100).ToString();
                LblPercent.Text = string.Concat(percent, " %");
                if (PbrLoading.Value >= PbrLoading.Maximum)
                {
                    mainForm = LoadMainForm();
                }
            }
        }

       

        private FrmMain LoadMainForm()
        {
            TmrLoading.Enabled = false;
            this.Hide();        
            FrmMain frm = new FrmMain();
            frm.Show();
            frm.FormClosed += CloseForm;
            return frm;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            LoadMainForm();
        }

        private void CloseForm(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
