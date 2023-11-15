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
    public partial class FrmLogin : FrmBase
    {
        public UserInfo user;
        public FrmLogin()
        {
            InitializeComponent();
            user = new UserInfo();
            LblHeader.ForeColor = accentColor;
            Lblpass.ForeColor = LblUser.ForeColor = primaryColor;
            Btn_Cancel.BackColor = BtnConfirm.BackColor = primaryColor;
            Btn_Cancel.ForeColor = BtnConfirm.ForeColor = textColor;
            TbxPassword.BackColor = TbxUsername.BackColor = secondaryColor;
            TbxPassword.ForeColor = TbxUsername.ForeColor = textColor;
            BackColor = backgroundColor;
        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
           String userName = TbxUsername.Text;
           if (userName == "Alex" && TbxPassword.Text == "1234")
            {
                user.IsValidated = true;
                user.UserName = userName;
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void Txb_enter(object sender, EventArgs e)
        {
            TextBox txb = (TextBox)sender;
            txb.BackColor = primaryColor;
        }

        private void Txb_leave(object sender, EventArgs e)
        {
            TextBox txb = (TextBox)sender;
            txb.BackColor = secondaryColor;
        }

        public void BtnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();       
        }
    }
}
