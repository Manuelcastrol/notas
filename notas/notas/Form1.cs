using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace notas
{
    public partial class Form1 : Form
    {
        private void Form1_Load(object sender, EventArgs e)
        {

            public Notas()
            {
                InitializeComponent();
            }

            private void Form1_Load(object sender, EventArgs e)
            {

            }

            private void nombre_Click(object sender, EventArgs e)
            {

            }

            private void button1_Click(object sender, EventArgs e)
            {

                Proceso ventana = new Proceso();
                ventana.mate = 1;
                ventana.ShowDialog();
            }

            private void button2_Click(object sender, EventArgs e)
            {

                Proceso ventana = new Proceso();
                ventana.mate = 2;
                ventana.Show();
            }

            private void button3_Click(object sender, EventArgs e)
            {

                Proceso ventana = new Proceso();
                ventana.mate = 3;
                ventana.Show();
            }

            private void button5_Click(object sender, EventArgs e)
            {

                Proceso ventana = new Proceso();
                ventana.mate = 4;
                ventana.Show();
            }

            private void button4_Click(object sender, EventArgs e)
            {

                Proceso ventana = new Proceso();
                ventana.mate = 5;
                ventana.Show();
            }
        }





    }
    
}
