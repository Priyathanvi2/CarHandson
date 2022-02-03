using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CarHandson.Models;

namespace CarHandson
{
    public partial class CarEntry : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            LoadData();
        }        
        protected void LoadData()
        {
            Dbcon conn = new Dbcon();
            DataTable dt = conn.load();
            GTable.DataSource = dt;
            GTable.DataBind();
        }
       
        protected void btnSave_Click(object sender, EventArgs e)
        {
            Dbcon conn = new Dbcon();
            CarProperty car = new CarProperty();
            car.CarModel = txtmodel.Text;
            car.CarName = txtname.Text;
            car.CarCategory = txtcategory.Text;
            car.Price = Convert.ToInt32(txtprice.Text);
            car.YearofModel = Convert.ToInt32(txtyear.Text);
            car.Description = txtdes.Text;
            string msg = conn.save(car);
            Response.Write($"<script>alert('{msg}')</script>");
            LoadData();
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            Dbcon conn = new Dbcon();
            CarProperty car = new CarProperty();
            car.CarModel = txtmodel.Text;
            car.CarName = txtname.Text;
            car.CarCategory = txtcategory.Text;
            car.Price = Convert.ToInt32(txtprice.Text);
            car.YearofModel = Convert.ToInt32(txtyear.Text);
            car.Description = txtdes.Text;
            string msg = conn.update(car);
            Response.Write($"<script>alert('{msg}')</script>");
            LoadData();
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            Dbcon conn = new Dbcon();
            CarProperty car = new CarProperty();
            car.CarModel = txtmodel.Text;
            car.CarName = txtname.Text;
            car.CarCategory = txtcategory.Text;
            car.Price = Convert.ToInt32(txtprice.Text);
            car.YearofModel = Convert.ToInt32(txtyear.Text);
            car.Description = txtdes.Text;
            string msg = conn.delete(car);
            Response.Write($"<script>alert('{msg}')</script>");
            LoadData();
        }

        protected void btnReset_Click(object sender, EventArgs e)
        {
            
                txtmodel.Text = "";
                txtname.Text = "";
                txtcategory.Text = "";
                txtprice.Text = "";
                txtyear.Text = "";
            txtdes.Text = "";
                
           
        }
    }
}