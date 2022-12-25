using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManejoExcepciones
{
    public partial class FSuma : Form
    {
        public FSuma()
        {
            InitializeComponent();
        }

        private void btResultado_Click(object sender, EventArgs e)
        {
            try
            {
                int a, b, r;

                a = int.Parse(txtboxPrimerNumero.Text);

                b = int.Parse(txtBoxSegundoNumero.Text);

                r = a + b;

                MessageBox.Show("el resultado es: " + r);

            }
            catch (Exception ex)
            {

                MessageBox.Show("ingreso caracteres incorrectos. vuelva a intentar");
            }
        }
    }
}
