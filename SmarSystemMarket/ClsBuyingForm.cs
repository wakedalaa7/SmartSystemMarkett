using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace SmarSystemMarket
{
    class ClsBuyingForm
    {
        public static DataTable dtusers = new DataTable();
        public static string[] BuyPro(string [] barcode)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = clset.cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "ProddCosSP";
            cmd.Parameters.Add("@barcode", SqlDbType.VarChar, 9).Value = barcode[0];
            clset.cn.Open();
            dtusers.Load(cmd.ExecuteReader());
            if (dtusers.Rows.Count > 0)
            {              
                barcode[1] = dtusers.Rows[0][2].ToString();
                barcode[2] = dtusers.Rows[0][3].ToString();
            }
            dtusers.Reset();

            clset.cn.Close();
            return barcode;
        }
//        create proc ProdCosSP
//@barcode varchar(100)
//as
//select* from Product
//where BarCode = @barcode
    }
}
