using Middle_Abarrotes_PDV;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Back_CRUDs_BD;

namespace pruebaVENTA
{
    public partial class Editar : Form
    {
        Producto prod = new Producto();
        public Editar()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Presentacion valorpresentacion;
            switch (comboPresentacion.SelectedItem.ToString())
            {
                case "CAJA":
                    valorpresentacion = Presentacion.CAJA;
                    break;
                case "KILO":
                    valorpresentacion = Presentacion.KILO;
                    break;
                case "LITRO":
                    valorpresentacion = Presentacion.LITRO;
                    break;
                case "PIEZA":
                    valorpresentacion = Presentacion.PIEZA;
                    break;
                default:
                    valorpresentacion = Presentacion.KILO;
                    break;

            }
            bool resultado = prod.modificarProd(txtNom.Text, txtDesc.Text, double.Parse(txtPrecio.Text), txtCodBarras.Text, txtImagen.Text, txtMarca.Text, valorpresentacion);
            //valir el res
            if (resultado == false)
                Producto.msgError = "Error al Modificar";

        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            List<Producto> prods = prod.consultarGeneral($" nombre LIKE '%{textBoxbuscar.Text}%' OR descripcion LIKE '%{textBoxbuscar.Text}%'");
            if (prods.Count > 0)
            {
                dataGridProductos.Rows.Clear();
                foreach (Producto pro in prods)
                {
                    dataGridProductos.Rows.Add(new object[] { pro.id, pro.nombre, pro.cod_barras, pro.descripcion, pro.precio, pro.imagen, });

                }
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {
        }

        private void textBoxbuscar_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBoxbuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                buttonBuscar_Click(sender, e);
            }
        }
    }
}
