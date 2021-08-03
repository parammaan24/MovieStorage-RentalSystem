using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStorage_RentalSystem
{
  public  class ConnectSQL
    {

        // connection between database
        SqlConnection con;
        String Constr = "Data Source=DESKTOP-LTQK306;Initial Catalog=dbVideo;Integrated Security=True";
        SqlCommand command;
        SqlDataReader reader;

        public void runIDU(String qry)
        {
            con = new SqlConnection(Constr);
            con.Open();
            command = new SqlCommand(qry, con);
            int y = command.ExecuteNonQuery();

            con.Close();
        }

        public DataTable getRecords(String qry)
        {
            con = new SqlConnection(Constr);

            con.Open();
            command = new SqlCommand(qry, con);

            reader = command.ExecuteReader();

            DataTable dt = new DataTable();

            dt.Load(reader);

            con.Close();

            return dt;
        }


    }
}
