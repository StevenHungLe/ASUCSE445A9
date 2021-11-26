using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Restaurant
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void HomeBtn_Click(object sender, EventArgs e)
        {

        }

        protected void MemberRegisterBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Account/MemberRegister.aspx");
        }

        protected void MemberLoginBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Account/MemberLogin.aspx");
        }

        protected void StaffPageBtn_Click(object sender, EventArgs e)
        {

        }

        protected void StaffLoginBtn_Click(object sender, EventArgs e)
        {

        }
    }
}