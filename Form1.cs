using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace serpintes_y_escaleras
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";

            dado b = new dado();
            jugador a = new jugador(1);
            jugador c = new jugador(2);

            int x, y;

            do
            {
                x = a.avanzar(b.num_ran());
                y = c.avanzar(b.num_ran());
                textBox1.Text =textBox1.Text + "jugador1: " + x.ToString() + "  ||  jugador2: " + y.ToString()+ "\r\n";
            } while (x <= 100 && y <= 100);

            if (x >= 100)
                label1.Text = "el jugador 1 gana";
            else
                label1.Text = "el jugador 2 gana";

        }
    }
}
