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
    public partial class FrmBase : Form
    {
        protected Color primaryColor = Color.FromArgb(0, 8, 38);
        protected Color secondaryColor = Color.FromArgb(41, 41, 52);
        protected Color backgroundColor = Color.FromArgb(255, 255, 255);
        protected Color textColor = Color.FromArgb(222, 255, 255);
        protected Color accentColor = Color.FromArgb(255, 40, 0);
        public FrmBase()
        {
            InitializeComponent();
            BackColor = backgroundColor;
        }
    }
}
