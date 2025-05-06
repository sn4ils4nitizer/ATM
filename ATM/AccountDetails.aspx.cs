using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Security.Principal;

namespace ATM
{
    public partial class AccountDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //https://www.c-sharpcorner.com/UploadFile/2f73dd/what-is-postback-in-Asp-Net/
            //https://stackoverflow.com/questions/28354485/asp-net-postback-and-function
            // The sites above helped me understand postback
            if (!IsPostBack)
            {
                Account currentAccount = Session["CurrentAccount"] as Account;
                if (currentAccount != null)
                {
                    Label1.Text += currentAccount.AccountName;
                    Label2.Text += currentAccount.AccountName;
                    Label3.Text += currentAccount.AccountName + "'s " + currentAccount.AccountType + " account.";
                    Label4.Text += currentAccount.AccountNumber;
                    ActualBalance.Text += currentAccount.Balance;
                    Interest.Text = "Interest accrued:" + (currentAccount.Balance*0.01).ToString();
                }
                else
                {
                    Label1.Text = "Error: No account loaded.";
                }
            }
        }
        protected void Deposit_Click(object sender, EventArgs e)
        {
            Response.Redirect("DepositScreen.aspx");
        }

        protected void Withdrawal_Click(object sender, EventArgs e) 
        {
            Response.Redirect("WithdrawalForm.aspx");
        }

        //On logout the account and its info are saved to the json file
        //User is edirected to login page, variables are clear and session is forgotten
        protected void Logout_Click(object sender, EventArgs e) 
        {
            Account currentAccount = Session["CurrentAccount"] as Account;
            string folderPath = Server.MapPath("~/App_Data/Accounts");

            currentAccount.SaveToJson(folderPath);
            Response.Redirect("WebForm1.aspx");
            Session.Clear();
            Session.Abandon();
        }
    }
}