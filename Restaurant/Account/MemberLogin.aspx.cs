using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using ClassLibrary;

namespace Restaurant.Account
{
    public partial class MemberLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie myCookies = Request.Cookies["myCookieId"];
            if (myCookies != null)
            {
                Response.Redirect("Member.aspx");
            }
        }

        protected void LoginBtn_Click(object sender, EventArgs e)
        {
            string filepath = HttpRuntime.AppDomainAppPath + @"Account\App_Data\Members.xml";
            string user = UsernameTextBox.Text;
            string password = PasswordTextBox.Text;
            Cryption cryption = new Cryption();
            string pwdEncrypt = cryption.Encrypt(password);
            XmlDocument myDoc = new XmlDocument();
            myDoc.Load(filepath);
            XmlElement rootElement = myDoc.DocumentElement;
            foreach(XmlNode node in rootElement.ChildNodes)
            {
                if(node["name"].InnerText == user)
                {
                    if (node["password"].InnerText == pwdEncrypt)
                    {
                        errorLogin.Visible = false;
                        
                        if(CheckBox1.Checked == true)
                        {
                            HttpCookie myCookies = new HttpCookie("myCookieId");
                            myCookies["Name"] = user;
                            myCookies["Password"] = password;
                            myCookies.Expires = DateTime.Now.AddMonths(6);
                            Response.Cookies.Add(myCookies);
                        }
                        Response.Redirect("Member.aspx");
                        return;
                    }
                    else
                    {
                        errorLogin.Text = "*Password is not correct!";
                        errorLogin.Visible = true;
                        return;
                    }
                }
            }
            errorLogin.Text = "* The Username does not exist!";
            errorLogin.Visible = true;

        }
    }
}