using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace SmarSystemMarket
{
    class ClsAddProduct
    {
        public static DataTable dtusers = new DataTable();
        public static void Addprod(string BarCode,string Company, int Qty,string ProdName,float ProdPrice)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = clset.cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "InsertBroduct22sp";
            cmd.Parameters.Add("@BarCode", SqlDbType.VarChar, 100).Value = BarCode;
            cmd.Parameters.Add("@Company", SqlDbType.VarChar, 10).Value = Company;
            cmd.Parameters.Add("@ProdName", SqlDbType.VarChar, 10).Value = ProdName;
            cmd.Parameters.Add("@ProdPrice", SqlDbType.Decimal, 18).Value = ProdPrice;
           // cmd.Parameters.Add("@ExpProd", SqlDbType.Date).Value = Expdate;
            cmd.Parameters.Add("@Qty", SqlDbType.Int).Value = Qty;
            clset.cn.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Added Broduct Was Success");

            clset.cn.Close();
        }

      
    }
}
