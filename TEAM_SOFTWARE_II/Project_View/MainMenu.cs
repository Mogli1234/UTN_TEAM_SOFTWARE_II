using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_View
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void btnCreateSport_Click(object sender, EventArgs e)
        {
            Create_Sport sport = new Create_Sport();
            sport.ShowDialog();
        }
    }
}
