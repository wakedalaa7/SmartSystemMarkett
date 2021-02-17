using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace SmarSystemMarket
{
    class ClsUsers
    {
        public static DataTable dtusers = new DataTable();
        public static  int login(string id)
        {
            int flag = 0;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = clset.cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "loginsp";
            cmd.Parameters.Add ("@id", SqlDbType.VarChar, 9).Value=id;
            clset.cn.Open();
            dtusers.Load(cmd.ExecuteReader());
            if (dtusers.Rows.Count > 0)
            {
                flag = 1;
                //BuyingForm bf = new BuyingForm();               
                //dtusers.Rows[0].Delete();
                //bf.Show();
            }
            dtusers.Reset();
            
            clset.cn.Close();
            return flag;
        }
        public static int login2(string id)
        {
            int flag = 0;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = clset.cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "login22sp";
            cmd.Parameters.Add("@id", SqlDbType.VarChar, 9).Value = id;
            clset.cn.Open();
            dtusers.Load(cmd.ExecuteReader());
            if (dtusers.Rows.Count > 0)
            {
                flag = 1;
                //BuyingForm bf = new BuyingForm();               
                //dtusers.Rows[0].Delete();
                //bf.Show();
            }
            dtusers.Reset();

            clset.cn.Close();
            return flag;
        }
    }
}
