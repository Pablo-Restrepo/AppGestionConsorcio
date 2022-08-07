using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppGestionConsorcio.datos;
using System.Data;

namespace AppGestionConsorcio.logica
{
    class Consorcio
    {
        AccesoDatos dt = new AccesoDatos();
        public int registrarConsorcio(int codigo, string nombre, int aniofundacion)
        {
            int resultado;
            string consulta;
            consulta = "insert into consorcio (CON_NIT,CON_NOMBRE,CON_ANOFUNDACION) values (" + codigo + ",'" + nombre + "'," + aniofundacion + ")";
            resultado = dt.ejecutarDML(consulta);
            return resultado;
        }
    }
}
