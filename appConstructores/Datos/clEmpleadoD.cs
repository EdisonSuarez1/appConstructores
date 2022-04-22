using appConstructores.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace appConstructores.Datos
{
    public class clEmpleadoD
    {
        public List<clEmpleadoD> mtdListar()
        {
            string sql = "SELECT * FROM constructores";
            clConexion objConexion = new clConexion();
            DataTable tblEmpleados = new DataTable();
            tblEmpleados = objConexion.mtdDesconectado(sql);

            List<clEmpleadoD> listaEmpleados = new List<clEmpleadoD>();

            int catReg = tblEmpleados.Rows.Count;

            for (int i = 0; i < catReg; i++)
            {

                clEmpleadoE objDatosEmpleado = new clEmpleadoE();
                objDatosEmpleado.idEmpleado = int.Parse(tblEmpleados.Rows[i]["idEmpleado"].ToString());
                objDatosEmpleado.documeto = tblEmpleados.Rows[i]["documento"].ToString();
                objDatosEmpleado.nombre = tblEmpleados.Rows[i]["nombre"].ToString();
                objDatosEmpleado.apellido = tblEmpleados.Rows[i]["apellido"].ToString();
                objDatosEmpleado.email = tblEmpleados.Rows[i]["email"].ToString();
                objDatosEmpleado.fechaNacimiento = DateTime.Parse(tblEmpleados.Rows[i]["fechaNacimiento"].ToString());
                objDatosEmpleado.celular = tblEmpleados.Rows[i]["celular"].ToString();
                objDatosEmpleado.direccion = tblEmpleados.Rows[i]["direccion"].ToString();
                objDatosEmpleado.idArea = int.Parse(tblEmpleados.Rows[i]["idArea"].ToString());
                listaEmpleados.Add(objDatosEmpleado);
            }

            return listaEmpleados;

        }


    }
}