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
    public partial class FrmBigScreenBase : FrmBase
    {
        public FrmBigScreenBase()
        {
            InitializeComponent();
            PnlTop.BackColor = primaryColor;
            BtnClose.BackColor = LblHeader.BackColor = Color.Transparent;
            BtnClose.ForeColor = LblHeader.ForeColor = textColor;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
