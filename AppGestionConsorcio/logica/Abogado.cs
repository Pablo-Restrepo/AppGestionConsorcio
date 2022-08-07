using AppGestionConsorcio.datos;
using System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGestionConsorcio.logica
{
    class Abogado
    {
        AccesoDatos dt = new AccesoDatos();
        public int registrarAbogado(int id, string nombre, string apellido, string numcasosganados, string tipoabogado)
        {
            int resultado;
            string consulta;
            consulta = "insert into abogado (ABO_ID,ABO_NOMBRE,ABO_APELLIDO,ABO_NUMCASOSGANADOS,ABO_TIPOABOGADO) values (" + id + ",'" + nombre + "','"+ apellido + "','" + numcasosganados + "','" + tipoabogado + "')";
            resultado = dt.ejecutarDML(consulta);
            return resultado;
        }
        public DataSet cuantosPenalistas()
        {
            DataSet mids = new DataSet(); ;
            string consulta;
            consulta = "SELECT COUNT(ABO_ID) \"Numero de Abogados penalistas\" FROM abogado WHERE ABO_TIPOABOGADO = 'penalista'";
            mids = dt.ejecutarSELECT(consulta);
            return mids;
        }
    }
}
