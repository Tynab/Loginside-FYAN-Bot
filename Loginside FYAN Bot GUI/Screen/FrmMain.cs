using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YANF.Script;

namespace Loginside_FYAN_Bot_GUI.Screen
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Shown(object sender, EventArgs e)
        {
            this.FadeIn();
        }
    }
}
