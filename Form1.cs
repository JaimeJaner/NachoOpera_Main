﻿using System;
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

namespace NachoOpera_Main
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_sumar_Click(object sender, EventArgs e)
        {
            lbl_Resultado.Text=Convert.ToString(NachoOperacion_Suma.Class1.Suma(double.Parse(txt_NumeroUno.Text), double.Parse(txt_NumeroDos.Text)));

        }

        private void btn_Resta_Click(object sender, EventArgs e)
        {
            lbl_Resultado.Text = Convert.ToString(NachoOpera_Resta.Class1.Resta(double.Parse(txt_NumeroUno.Text), double.Parse(txt_NumeroDos.Text)));
        }
    }
}
