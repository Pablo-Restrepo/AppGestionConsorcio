using AppGestionConsorcio.datos;
using System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGestionConsorcio.logica
{
    class Trabajo
    {
        AccesoDatos dt = new AccesoDatos();
        public int registrarTrabajo(int NIT, int id, string inicio, string fin)
        {
            int resultado;
            string consulta;
            consulta = "insert into tiene (CON_NIT,ABO_ID ,FECHAINICIO ,FECHAFIN) values (" + NIT + "," + id + ",'"+ inicio + "','" + fin + "')";
            resultado = dt.ejecutarDML(consulta);
            return resultado;
        }
        public DataSet buscarFechaIni(string fin)
        {
            DataSet mids = new DataSet(); ;
            string consulta;
            consulta = "SELECT consorcio.CON_NIT \"NIT Consorcio\", CON_NOMBRE \"Nombre del Consorcio\", abogado.ABO_ID \"ID Abogado\", ABO_NOMBRE \"Nombre Abogado\", ABO_APELLIDO \"Apellido Abogado\", ABO_TIPOABOGADO \"Tipo de Abogado\", FECHAFIN FROM tiene INNER JOIN abogado ON tiene.abo_id = abogado.abo_id INNER JOIN consorcio ON tiene.con_nit = consorcio.con_nit WHERE tiene.fechainicio = '" + fin + "'";
            mids = dt.ejecutarSELECT(consulta);
            return mids;
        }
    }
}
