using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

// Filip Buczynski

namespace ATM
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string username = UserName.Text;
            string password = Password.Text;
            string folderPath = Server.MapPath("~/App_Data/Accounts");

            try
            {
                //https://learn.microsoft.com/en-us/dotnet/api/system.web.httpcontext.session?view=netframework-4.8.1
                //Creates a session so that the loaded account aobject persists across page loading
                Account loadedAccount = Account.LoadFromJson(folderPath, username);
                if (loadedAccount.Password == password)
                {
                    Session["CurrentAccount"] = loadedAccount;
                    Response.Redirect("AccountDetails.aspx");
                }
                else
                {
                    throw new Exception("Invalid Username or Passowrd. ");
                }

            }
            //
            catch (Exception ex)
            {
                ErrorLabel.Text = ex.Message;
            }            
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("AccountCreation.aspx");
        }
    }
}