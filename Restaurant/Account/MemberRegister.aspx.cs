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
    public partial class MemberRegister : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Image.ImageUrl = "~/Account/imageVerifier.aspx";
            Image.Visible = true;
        }

        protected void GetNewImageBtn_Click(object sender, EventArgs e)
        {
            myImageRef.Service1Client myProxy = new myImageRef.Service1Client();
            string myStr = myProxy.GetVerifierString(5);
            Session["generatedString"] = myStr;
            Image.Visible = true;
        }

        protected void RegisterButton_Click(object sender, EventArgs e)
        {
            //Step 1 :password match check
            if (PasswordTextBox.Text != ConfirmTextBox.Text)
            {
                PwdErrorLabel.Text = "*The confirm password does not match!";
                PwdErrorLabel.Visible = true;
                return;
            }
            else if (PasswordTextBox.Text == "")
            {
                PwdErrorLabel.Text = "*Password cannot be empty";
                PwdErrorLabel.Visible = true;
                return;
            }
            PwdErrorLabel.Visible = false;
            //Step 2 :Image verification test
            if (StringTextBox.Text != (string)Session["generatedString"])
            {
                StrErrLabel.Text = string.Format("*Text does not match image");
                StrErrLabel.Visible = true;
                return;
            }
            StrErrLabel.Visible = false;

            //Step 3 : Validate user name

            if (UsernameTextBox.Text == "")
            {
                UserErrorLabel.Text = "* Username cannot be empty";
                UserErrorLabel.Visible = true;
                return;
            }
            UserErrorLabel.Visible = false;

            string user = UsernameTextBox.Text;
            string password = PasswordTextBox.Text;
            string filepath = HttpRuntime.AppDomainAppPath + @"Account\App_Data\Members.xml";
            //Encrypt the password using the DLL function
            Cryption cryption = new Cryption();
            string pwdEncrypt = cryption.Encrypt(PasswordTextBox.Text);
            XmlDocument myDoc = new XmlDocument();
            myDoc.Load(filepath);
            XmlElement rootElement = myDoc.DocumentElement;

            foreach (XmlNode node in rootElement.ChildNodes)
            {
                if (node["name"].InnerText == user)
                {
                    UserErrorLabel.Text = string.Format("* Account with username {0} already exists.", user);
                    UserErrorLabel.Visible = true;
                    return;
                }
            }

            UserErrorLabel.Visible = false;
            XmlElement myMember = myDoc.CreateElement("member", rootElement.NamespaceURI);
            rootElement.AppendChild(myMember);
            XmlElement myUser = myDoc.CreateElement("name", rootElement.NamespaceURI);
            myMember.AppendChild(myUser);
            myUser.InnerText = user;
            XmlElement myPwd = myDoc.CreateElement("password", rootElement.NamespaceURI);
            myMember.AppendChild(myPwd);
            myPwd.InnerText = pwdEncrypt;
            myDoc.Save(filepath);
            Response.Redirect("Member.aspx");
        }
    }
    
}