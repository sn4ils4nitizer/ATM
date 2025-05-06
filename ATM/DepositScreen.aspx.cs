using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ATM
{
    public partial class DepositScreen : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Account currentAccount = Session["CurrentAccount"] as Account;
                if (currentAccount == null)
                {
                    Response.Redirect("WeForm1.aspx");
                }
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            Account currentAccount = Session["CurrentAccount"] as Account;
            double amount;
            double.TryParse(txtDepositAmount.Text, out amount);
            if (amount <= 0)
            {
                lblMessage.Text = "Please enter a valid amount";
            }
            else
            {
                currentAccount.deposit(amount, Server.MapPath("~/App_Data/Logs"));
                Response.Redirect("AccountDetails.aspx");
                //ActualBalance.Text = currentAccount.Balance.ToString();
            }

        }

        protected void Cancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("AccountDetails.aspx");
        }
    }
}