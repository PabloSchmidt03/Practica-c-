using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiTercerApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblFormulario_Click(object sender, EventArgs e)
        {
            lblFormulario.BackColor = Color.Red;

        }

        private void lblFormulario_MouseLeave(object sender, EventArgs e)
        {
            lblFormulario.BackColor = System.Drawing.SystemColors.Control;
            lblFormulario.Cursor = Cursors.Arrow;
            
        }

        private void lblFormulario_MouseMove(object sender, MouseEventArgs e)
        {
            lblFormulario.BackColor = Color.White;
            lblFormulario.Cursor = Cursors.Hand;
        }
    }
}
