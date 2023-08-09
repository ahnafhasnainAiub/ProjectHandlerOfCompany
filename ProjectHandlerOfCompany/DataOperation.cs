using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data;

namespace ProjectHandlerOfCompany
{
    public class DataOperation
    {
        private SqlConnection SqlCon { set; get; }
        public SqlCommand SqlCom { set; get; }
        
        public DataOperation(string sqlCon = "Data Source=DESKTOP-7BNTHOH\\SQLEXPRESS;Initial Catalog=ProjectHandler;User ID=sa;Password=1234")
        {
            this.SqlCon = new SqlConnection(sqlCon);
        }
        public void OpenDatabase()
        {
            this.SqlCon.Open();
        }
        public void CloseDatabase()
        {
            this.SqlCon.Close();
        }
        public void SetCommand(string sqlQuery)
        {
            this.SqlCom = new SqlCommand(sqlQuery, this.SqlCon);
        }
        // select command
        public DataSet RunQueryCommand(string sqlQuery)
        {
            this.SetCommand(sqlQuery);
            SqlDataAdapter sda = new SqlDataAdapter(this.SqlCom);
            DataSet da = new DataSet();
            sda.Fill(da);
            return da;
        }
        //CREATE, UPDATE, DELETE
        public int RunNonQueryCommand(string sqlQuery)
        {
            this.SetCommand(sqlQuery);
            return this.SqlCom.ExecuteNonQuery();
        }
        public int RowCounter(string sqlQuery)
        {
            int counter = 0;
            this.SetCommand(sqlQuery);
            SqlDataReader sdr = SqlCom.ExecuteReader();
            while (sdr.Read())
            {
                counter++;
            }
            return counter;
        }
    }
}
