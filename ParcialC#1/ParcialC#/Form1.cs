using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParcialC_
{
    public partial class Form1 : Form
    {
            CalcularPresupuesto Calcular = new CalcularPresupuesto(); 
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {


            if (txtAncho.Text == "" || txtAlto.Text == "")
            {
                MessageBox.Show("ERROR: Ingrese algun valor");
                
            }
            else
            {
                Calcular.ancho = Convert.ToInt32(txtAncho.Text);
                Calcular.alto = Convert.ToInt32(txtAlto.Text);
                if (txtProducto.Text == "Porton")
                {
                    Calcular.Valor = 40000;  // SE MULTIPLICA POR 40 MIL COMO EJEMPLO
                }
                else if (txtProducto.Text == "Reja")
                {
                    Calcular.Valor = 30000; // SE MULTIPLICA POR 40 MIL COMO EJEMPLO
                }
                else if (txtProducto.Text == "Cielo Raso")
                {
                    Calcular.Valor = 50000; // SE MULTIPLICA POR 50 MIL COMO EJEMPLO
                }

                else
                {
                    MessageBox.Show("ERROR: Producto no encontrado");
                }

                Calcular.CalcularPresupuestos(Calcular.ancho, Calcular.alto, Calcular.Valor);
                txtPresupuesto.Text = "$ " + Convert.ToString(Calcular.total);
            }

               

            

  

        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            txtProducto.Text = comboBox1.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
