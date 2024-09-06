using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            agregar();
        }

        public void agregar()
        {
            // Agregar el nombre a la lista
            string nombre = tbNombre.Text.Trim(); // Funcion para borrar espacios tanto al principio como al final de la cadena
            if (string.IsNullOrEmpty(nombre)) //Validacion de datos
            {
                MessageBox.Show("El nombre no puede estar vacío");
                tbNombre.Focus();
                return;
            }
            cmbNombres.Items.Add(nombre);
            // Limpiar
            tbNombre.Text = "";
            tbNombre.Focus();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCopiar_Click(object sender, EventArgs e)
        {
            // Mostrar los nombres de la lista
            int cant = cmbNombres.Items.Count;
            for (int i = 0; i < cant; i++)
            {
                string nombre = cmbNombres.Items[i].ToString();
                cmbNombres.Items.Add(nombre);
            }
        }
    }
}
