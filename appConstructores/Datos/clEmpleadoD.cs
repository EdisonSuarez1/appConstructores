using appConstructores.Entidades;
using System.Collections.Generic;
using System.Data;

namespace appConstructores.Datos
{
    public class clEmpleadoD
    {
        public List<clEmpleadoE> mtdListar()
        {
            string sql = "SELECT * FROM constructores";
            clConexion objConexion = new clConexion();
            DataTable tblEmpleados = new DataTable();
            tblEmpleados = objConexion.mtdDesconectado(sql);

            List<clEmpleadoE> listaEmpleados = new List<clEmpleadoE>();

            int catReg = tblEmpleados.Rows.Count;

            for (int i = 0; i < catReg; i++)
            {

                clEmpleadoE objDatosEmpleado = new clEmpleadoE();
                objDatosEmpleado.idempleado = int.Parse(tblEmpleados.Rows[i]["idEmpleado"].ToString());
                objDatosEmpleado.nombres = tblEmpleados.Rows[i]["nombres"].ToString();
                objDatosEmpleado.apellidos = tblEmpleados.Rows[i]["apellidos"].ToString();
                objDatosEmpleado.ndocumento = tblEmpleados.Rows[i]["nombre"].ToString();
                objDatosEmpleado.tipoempleado = tblEmpleados.Rows[i]["nombre"].ToString();

                listaEmpleados.Add(objDatosEmpleado);
            }

            return listaEmpleados;

        }


    }
}