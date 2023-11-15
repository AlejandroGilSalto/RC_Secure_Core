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
    public partial class FrmMain : FrmBigScreenBase
    {
        private UserInfo user;
        public FrmMain()
        {
            InitializeComponent();
            LoadLoginForm();
            BtnLogin.BackColor = Btn_1.BackColor = Btn_2.BackColor = Btn_3.BackColor = primaryColor;
            BtnLogin.ForeColor = Btn_1.ForeColor = Btn_2.ForeColor = Btn_3.ForeColor = textColor;
            PnlValidatedUserMenu.BackColor = PnlSideMenu.BackColor = backgroundColor;
            
        }

        private void LoadLoginForm()
        {
            using (FrmLogin frm = new FrmLogin())
            {
                frm.StartPosition = FormStartPosition.CenterScreen;
                frm.DialogResult = DialogResult.None;
                frm.ShowDialog();
                if (frm.DialogResult.Equals(DialogResult.OK))
                {
                    PnlValidatedUserMenu.Visible = true;
                    user = frm.user;
                }
            }
        }


        private void BtnLogin_Click(object sender, EventArgs e)
        {       
            LoadLoginForm();
        }
    }
}
