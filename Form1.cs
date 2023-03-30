using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NachoOperacion_Suma;
using NachoOpera_Resta;
using NachoOperacion_Division;
using MaterialSkin.Controls;

namespace NachoOpera_Main
{
    public partial class Form1 : MaterialForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_sumar_Click(object sender, EventArgs e)
        {
            lbl_Resultado.Text = Convert.ToString(NachoOperacion_Suma.Class1.Suma(double.Parse(txt_NumeroUno.Text), double.Parse(txt_NumeroDos.Text)));

        }

        private void btn_multiplicacion_Click(object sender, EventArgs e)
        {
            lbl_Resultado.Text = Convert.ToString(NachoOperacion_Multiplicacion.Multiplicacion.Multiplicar(double.Parse(txt_NumeroUno.Text), double.Parse(txt_NumeroDos.Text)));

        }

        private void btn_Resta_Click(object sender, EventArgs e)
        {
            lbl_Resultado.Text = Convert.ToString(NachoOpera_Resta.Class1.Resta(double.Parse(txt_NumeroUno.Text), double.Parse(txt_NumeroDos.Text)));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
               lbl_Resultado.Text=Convert.ToString(NachoOperacion_Division.Dividir.Divide(double.Parse(txt_NumeroUno.Text),double.Parse(txt_NumeroDos.Text)));
      
        }
    }
}
