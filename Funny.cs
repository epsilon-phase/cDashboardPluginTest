using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//(C) Alexander White under the MIT License
namespace cDashboardPluginTest
{
    public partial class Funny : Form
    {
        public Funny()
        {
            InitializeComponent();

        }

        private void Funny_LocationChanged(object sender, EventArgs e)
        {
            cDashboardPluginTest.PluginInterface.f = true;
        }
    }
}
