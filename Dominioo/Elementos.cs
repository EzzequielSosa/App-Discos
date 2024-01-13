using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominioo
{
    public class Elementos
    {
        public string Descripcion { get; set; }

        public override string ToString()
        {
            return Descripcion.ToString();
        }

        //public int TipoEdicion {  get; set; }
    }
}
