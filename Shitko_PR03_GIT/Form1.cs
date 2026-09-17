using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shitko_PR03_GIT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime currentDate = DateTime.Now;
            string formattedDate = currentDate.ToShortDateString() + " " + currentDate.ToShortTimeString();
            MessageBox.Show("Текущая дата: " + formattedDate, "Информация",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
