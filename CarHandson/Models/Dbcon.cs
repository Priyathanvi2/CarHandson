using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace CarHandson.Models
{
    public class Dbcon
    {
        string ConnectionString = "Data Source=100.72.130.5;Initial Catalog = Training; Persist Security Info=True;User ID = TrainingUsr; Password=Tr@ininGU$r@#321";
         public string save(CarProperty cm)
        {
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into CarSalesTable values ('"+cm.CarModel+"','"+cm.CarName+"','"+cm.CarCategory+"',"+cm.Price+","+cm.YearofModel+",'"+cm.Description+"')", con);
            cmd.ExecuteNonQuery();
            con.Close();
            return "Data Saved";
        }
        public string update(CarProperty cp)
        {
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("Update CarSalesTable set CarCategory='"+cp.CarCategory+"',Price="+cp.Price+",YearofModel="+cp.YearofModel+",Description='"+cp.Description+"' where CarModel='"+cp.CarModel+"' ",con);
            cmd.ExecuteNonQuery();
            con.Close();
            return "Data Updated";
        }
        public string delete(CarProperty cp)
        {
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand($"delete from CarSalesTable where CarModel='{cp.CarModel}'",con);
            cmd.ExecuteNonQuery();
            con.Close();
            return "Data Deleted";
        }
        public DataTable load()
        {
            SqlConnection con = new SqlConnection(ConnectionString);
            SqlDataAdapter da = new SqlDataAdapter("select * from CarSalesTable", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}