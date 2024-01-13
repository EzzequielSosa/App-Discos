using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Dominioo;
using Conexion;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class FormAlta : Form
    {
        public FormAlta()
        {
            InitializeComponent();
        }

        private void FormAlta_Load(object sender, EventArgs e)
        {
            ElementoConexion elementoConexion = new ElementoConexion();
            try
            {
                comboBox1Ritmo.DataSource = elementoConexion.listar();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
            Discos nuevoDisco = new Discos();
            conexion_DB Conectar = new conexion_DB();

            try
            {
                nuevoDisco.titulo = textBox1Titulo.Text;
                nuevoDisco.cantCan = int.Parse(textBox2CantCan.Text);
                nuevoDisco.UrlImagen = textBoxUrlImagen.Text;

                nuevoDisco.Ritmo = (Elementos)comboBox1Ritmo.SelectedItem;

                Conectar.agregar(nuevoDisco);
                MessageBox.Show("¡Agregado Exitosamente!");
                Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void button2Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1Ritmo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBoxUrlImagen_Leave(object sender, EventArgs e)
        {
            cargarImagen(textBoxUrlImagen.Text);
        }
        private void cargarImagen(string imagen)
        {
            try
            {
                pictureBoxImagenAlta.Load(imagen);
            }
            catch (Exception)
            {

                pictureBoxImagenAlta.Load("https://wpdirecto.com/wp-content/uploads/2017/08/alt-de-una-imagen.png");
            }
        }
        private void textBoxUrlImagen_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
