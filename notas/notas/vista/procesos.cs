using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace notas.vista
{
    class Procesos
    {
        public int mate;
        public Procesos()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Hide()
        {
            throw new NotImplementedException();
        }

        entidades.ClsDatos cls = new entidades.ClsDatos();
        private void button1_Click(object sender, EventArgs e, object lab1, object lab2, object lab3, object par1, object par2, object par3)
        {

            string materia = "";
            if (mate == 1)
            {
                materia = "poo";
            }
            if (mate == 2)
            {
                materia = "matematica";
            }
            if (mate == 3)
            {
                materia = "Software Utilitario";
            }
            if (mate == 4)
            {
                materia = "Base de datos";
            }
            if (mate == 5)
            {
                materia = "Psicologia";
            }

            cls.Labo1 = double.Parse(lab1.Text);
            cls.Labo2 = double.Parse(lab2.Text);
            cls.Labo3 = double.Parse(lab3.Text);
            cls.Parc1 = double.Parse(par1.Text);
            cls.Parc2 = double.Parse(par2.Text);
            cls.Parc3 = double.Parse(par3.Text);

            NClslogica proceso = new NClslogica();

            MessageBox.Show("los promedios de " + materia + " son\n" + proceso.calculo(cls));

            this.cls();

        }
    }

}
