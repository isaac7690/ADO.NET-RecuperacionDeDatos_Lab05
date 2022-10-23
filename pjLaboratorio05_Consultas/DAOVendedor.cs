using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace pjLaboratorio05_Consultas
{
    public class DAOVendedor
    {
        Conexion objCon = new Conexion();
        SqlConnection cn;

        //1.Listado general de vendedores
        public DataTable listadoGeneral()
        {
            cn = objCon.getConecta();
            SqlDataAdapter da = new SqlDataAdapter("SP_LISTAVENDEDORES", cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        //2. Listado de Distritos para COMBO
        public DataTable listadoDistritos()
        {
            cn = objCon.getConecta();
            SqlDataAdapter da = new SqlDataAdapter("SP_LISTADODISTRITOS", cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        //3. Listado de vendedores por distrito
        public DataTable listadoVendedoresxDistrito(Vendedor objV)
        {
            cn = objCon.getConecta();
            cn.Open();
            SqlDataAdapter da = new SqlDataAdapter("SP_VENDEDORESxDISTRITO", cn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddWithValue("@DIS", objV.ide_dis);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cn.Close();
            return dt;
        }
        //4. Listado de facturas por fechas
        public DataTable listadoFacturasxFechas(DateTime f1,DateTime f2)
        {
            cn = objCon.getConecta();
            cn.Open();
            SqlDataAdapter da = new SqlDataAdapter("SP_LISTAFACTURASxFECHAS", cn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddWithValue("@f1", f1);
            da.SelectCommand.Parameters.AddWithValue("@f2", f2);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cn.Close();
            return dt;
        }
        //5. listado de facturas por vendedor
        public DataTable listadoFacturasxVendedor(Vendedor objV)
        {
            cn = objCon.getConecta();
            cn.Open();
            SqlDataAdapter da = new SqlDataAdapter("SP_LISTAFACTURASxVENDEDOR", cn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddWithValue("@VEN", objV.ide_ven);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cn.Close();
            return dt;
        }
        //6. listado de vendedores por inicial
        public DataTable listadoVendedorxInicial(string inicial)
        {
            cn = objCon.getConecta();
            cn.Open();
            SqlDataAdapter da = new SqlDataAdapter("SP_LISTAVENDEDORESxINICIAL", cn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddWithValue("@ini",inicial);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cn.Close();
            return dt;
        }


    }
}
