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
using Conexion;
using System.Data.SqlClient;


namespace WindowsFormsApp1

{
    public partial class ListaDiscos : Form

    {
        private List<Discos> discoLista;



        public ListaDiscos()
        {
            InitializeComponent();
        }

       

        private void ListaDiscos_Load(object sender, EventArgs e)
        {
            
            cargar();

        }

        private void dataGridView_Lista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        public void button1VerLista_Click(object sender, EventArgs e)
        {

        }

        private void cargar()
        {
            conexion_DB lis = new conexion_DB();
            try
            {
                
                discoLista = lis.listar();
                dataGridView_Lista.DataSource = discoLista;
                dataGridView_Lista.Columns["UrlImagen"].Visible = false;
                cargarImagen(discoLista[0].UrlImagen);
            

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        // mostrar imagen seleccionando
        private void dataGridView_Lista_SelectionChanged(object sender, EventArgs e)
        {
            Discos seleccionado = (Discos)dataGridView_Lista.CurrentRow.DataBoundItem;
            cargarImagen(seleccionado.UrlImagen);
        }

        //metodo para cargar imagen por defecto

        private void cargarImagen(string imagen)
        {
            try
            {
                pictureBox1Imagen.Load(imagen);
            }
            catch (Exception)
            {

                pictureBox1Imagen.Load("https://wpdirecto.com/wp-content/uploads/2017/08/alt-de-una-imagen.png");
            }
        }

        private void button2Agregar_Click(object sender, EventArgs e)
        {
            FormAlta formu = new FormAlta();
            formu.ShowDialog();
            cargar();

        }

        private void pictureBox1Imagen_Click(object sender, EventArgs e)
        {

        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {

        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            Discos seleccionado;
            seleccionado = (Discos)dataGridView_Lista.CurrentRow.DataBoundItem;
            FormAlta modificar = new FormAlta();
            modificar.ShowDialog();
            cargar();
            
        }
    }
}
