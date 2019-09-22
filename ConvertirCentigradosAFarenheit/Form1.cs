using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConvertirCentigradosAFarenheit
{
    public partial class Form1 : Form
    {

        Convertidor convertidor = new Convertidor();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnconvertir_Click(object sender, EventArgs e)
        {
            convertidor.setCentigrados(double.Parse(txtconvertir.Text));
            lblresultado.Text = "El resultado es: " + convertidor.convertir().ToString();
            lblresultado.Visible = true;
        }
    }
}
