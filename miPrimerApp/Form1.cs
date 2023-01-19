namespace Ej1
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome to C#");
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Hope to see you soon!");
        }

        private void btnChangeColor_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The Click event has launched");
            this.BackColor = Color.Black;
        }

        private void Main_Click(object sender, EventArgs e)
        {
            MouseEventArgs click = (MouseEventArgs)e;

            if (click.Button == MouseButtons.Left)
                MessageBox.Show("Presiono el botón Izquierdo", "Atención");
            else if (click.Button == MouseButtons.Right)
                MessageBox.Show("Presiono el Botón Derecho", "Atención");
            else
            if (click.Button == MouseButtons.Middle)
                MessageBox.Show("Presiono el botón del Medio", "Atención");
        }
    }
}