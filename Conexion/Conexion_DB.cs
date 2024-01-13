using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting.Messaging;
using System.Data.SqlClient;
using Dominio;
using Conexion;
using Dominioo;
using System.Security.Cryptography.X509Certificates;

namespace Conexion
{
     public class conexion_DB
    {
        

        public List<Discos> listar()
        {

            List<Discos> lista = new List<Discos>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;


            try
            {
                conexion.ConnectionString = "server=DESKTOP-ORNQQII\\SQLEXPRESS; database=DISCOS_DB; integrated security=true";

                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "select d.Id, titulo, CantidadCanciones, UrlImagenTapa, e.Descripcion as Ritmo from DISCOS d, ESTILOS e where d.IdEstilo = e.Id\r\n\r\n";
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Discos aux = new Discos();
                    aux.id = lector.GetInt32(0);
                    aux.titulo = (string)lector["Titulo"];
                    aux.cantCan =(int) lector["CantidadCanciones"];

                    if (!(lector["UrlImagenTapa"]is DBNull))
                    aux.UrlImagen = (string)lector["UrlImagenTapa"];

                    aux.Ritmo = new Elementos();
                    aux.Ritmo.Descripcion = (string)lector["Ritmo"];



                   

                 

                    lista.Add(aux);

                }
                conexion.Close();
                return lista;
            }

            catch (Exception ex)
            {
                throw ex;
                
               
            }
            

        }

        public void agregar(Discos nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta(" insert into DISCOS (Titulo, CantidadCanciones, UrlImagenTapa, IdEstilo ) values (@Titilo, @CantidadCanciones, @UrlImagenTapa,@IdEstilo)");
                datos.setearParametro("@IdEstilo", nuevo.Ritmo);
                datos.setearParametro("@Titulo", nuevo.titulo);
                datos.setearParametro("@CantidadCanciones", nuevo.cantCan);
                datos.setearParametro("@UrlImagenTapa", nuevo.UrlImagen);
                
              //  datos.setearParametro("@UrlImagenTapa", nuevo.UrlImagen);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { datos.cerrarConexion(); }

        }
        public void modificar(Discos Dis) 
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("update DISCOS set  Titulo = @Titulo, CantidadCanciones = @CantidadCanciones, UrlImagenTapa = @UrlImagenTapa, IdEstilo = @IdEstilo where Id = @Id");
                datos.setearParametro("@Titulo", Dis.titulo);
                datos.setearParametro("@CantidadCanciones", Dis.cantCan);
                datos.setearParametro("@UrlImagenTapa", Dis.UrlImagen);
                datos.setearParametro("@Id estilo", Dis.Ritmo);

                datos.ejecutarAccion();

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
        
    }

    
}

