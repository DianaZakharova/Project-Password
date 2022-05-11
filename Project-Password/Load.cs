using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Password
{
    public partial class Load : Form
    {
        public Load()
        {
            InitializeComponent();
            timer.Start(); //запустили таймер
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < 10;i++)
            {
                Opacity += 0.1d;
            }
        }
    }
}
