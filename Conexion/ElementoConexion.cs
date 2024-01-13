using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using Dominioo;
using System.Data.SqlClient;
using Conexion;

namespace Conexion
{
    public class ElementoConexion
    {
        public List<Elementos> listar() 
        {
            List<Elementos> lista = new List<Elementos>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("select Descripcion as Ritmo from ESTILOS");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Elementos aux = new Elementos();
                    aux.Descripcion = (string)datos.Lector["Ritmo"];

                    lista.Add(aux);
                }
                
   
                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally 
            {
                datos.cerrarConexion();
            }
        }
    }

}

