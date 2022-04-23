using appConstructores.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace appConstructores.Datos
{
    public class clEmpresaD
    {
        public List<clEmpresaE> mtdListar()
        {
            string sql = "SELECT * FROM constructores";
            clConexion objConexion = new clConexion();
            DataTable tblEmpresa = new DataTable();
            tblEmpresa = objConexion.mtdDesconectado(sql);

            List<clEmpresaE> listaEmpresa = new List<clEmpresaE>();

            int catReg = tblEmpresa.Rows.Count;

            for (int i = 0; i < catReg; i++)
            {

                clEmpresaE objDatosEmpresa = new clEmpresaE();
                objDatosEmpresa.idEmpresa= int.Parse(tblEmpresa.Rows[i]["idEmpresa"].ToString());
                objDatosEmpresa.nombreempresa = tblEmpresa.Rows[i]["nombreempresa"].ToString();
                objDatosEmpresa.direcciones = tblEmpresa.Rows[i]["direcciones"].ToString();
                objDatosEmpresa.telefono = tblEmpresa.Rows[i]["telefono"].ToString();
                objDatosEmpresa.ciudad = tblEmpresa.Rows[i]["ciudad"].ToString();
              
                listaEmpresa.Add(objDatosEmpresa);
            }

            return listaEmpresa;

        }

    }
}