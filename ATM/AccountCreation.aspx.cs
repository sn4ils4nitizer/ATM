using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ATM;

namespace ATM
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        Random rand = new Random();
        public int GetRandom()
        {
            return rand.Next(1000, 9999);
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = DropDownList1.SelectedValue;
        }
        //https://www.geeksforgeeks.org/asp-server-mappath-method/
        //https://www.c-sharpcorner.com/UploadFile/abhikumarvatsa/server-mappath-in-Asp-Net/
        //getting directories in Windows is not as easy as on linux :(
        protected void Button1_Click(object sender, EventArgs e)
        {
            string selectedValue = DropDownList1.SelectedValue;
            Account account = new Account(GetRandom(), TextBox1.Text, TextBox2.Text, selectedValue, TextBox3.Text, 1000);
            string folderPath = Server.MapPath("~/App_Data/Accounts");
            System.Diagnostics.Debug.WriteLine(folderPath);

            account.SaveToJson(folderPath);
            Response.Redirect("WebForm1.aspx");
        }
    }
}