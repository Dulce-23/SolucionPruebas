using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace MuestraEmpresa
{
    class Consultas
    {
        private SqlConnection conexion = new SqlConnection("Data Source=Dulce-PC\\SQLEXPRESS;Initial Catalog=DbEvaluacion; Integrated Security = True");
        private DataSet cds;

        public DataTable BuscarEmpresa(string codigo , string nombre)
        {

            conexion.Open();
            SqlCommand cmd = new SqlCommand("SELECT EmpresaCodigo,Nombre,CorreoElectronico,Telefono FROM DbEvaluacion.DBO.TblEmpresas WHERE EmpresaCodigo =@CODIGO And Nombre =@NOMBRE", conexion);
            cmd.Parameters.AddWithValue("@CODIGO",codigo);
            cmd.Parameters.AddWithValue("@NOMBRE", nombre);
            SqlDataAdapter cad = new SqlDataAdapter(cmd);

            cds = new DataSet();
            cad.Fill(cds, "tabla");
            conexion.Close();
            return cds.Tables["tabla"];

        }


    }
}
