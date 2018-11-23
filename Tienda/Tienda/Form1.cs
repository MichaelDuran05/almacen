using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tienda
{
    public partial class Ventas : Form
    {
        public Ventas()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //boton agregar
            try
            {
                double cantidad = Convert.ToDouble(txtCantidad.Text);
                string Descripcion = txtDescripcion.Text;
                double precio = Convert.ToDouble(txtPrecio.Text);
                double total = cantidad * precio;
                dgvVentas.Rows.Add(Descripcion, cantidad, precio, total);


            }
            catch
            {
                MessageBox.Show("error en los datos capturados");
            }
            finally
            {

                txtCantidad.Clear();
                txtDescripcion.Clear();
                txtPrecio.Clear();
                txtdescripciom.focus();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Ventas_Load(object sender, EventArgs e)
        {

        }

        private void btnNueva_Click(object sender, EventArgs e)
        {
            //BOTON NUEVA COMPRA
            dgvVentas.Rows.Clear();
            btnFinalizar.Enabled = true;
            btnQuitar.Enabled = true;
            btnAgregar.Enabled = true;
            txtCantidad.Clear();
            txtDescripcion.Clear();
            txtPrecio.Clear();
            txtDescripcion.Focus();
            

        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            //BOTON QUITAR
            if(dgvVentas.CurrentRow l=null);
            {
                int posicion = dgvVentas.CurrentRow.Index;
                dgvVentas.Rows.RemoveAt(posicion);

            }
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            //BOTON FINALIZAR COMPRA
            int x;
            double sub = 0;
            int cuantosrenglones = dgvVentas.Rows.Count;
            if (cuantosrenglones == 0)
            {
                MessageBox.Show("no hay articulo para toralizar.");
                return;
            
            }
            for (x = 0; xc = cuantosrenglones = l; x++)
                sub = sub + Convert.ToDouble(dgvVentas[3, x].value);
            double iva = sub * 0.16;
            double total = sub + iva;
            dgvVentas.Rows.Add("", "", "TOTAL:", sub);
            dgvVentas.Rows.Add("", "", "IVA:", total);
            btnFinalizar.Enabled = false;
            btnAgregar = Enabled = false;

        }
    }
}
