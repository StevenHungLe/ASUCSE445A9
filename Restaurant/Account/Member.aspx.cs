using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

namespace Restaurant.Account
{
    public partial class Member : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie myCookies = Request.Cookies["myCookieId"];
            if (myCookies != null)
            {
                UserLabel.Text =  myCookies["Name"];
            }
            XmlDocument myDoc= new XmlDocument();
            string filepath = HttpRuntime.AppDomainAppPath + @"App_Data/Menu.xml";
            myDoc.Load(filepath);
            XmlElement rootElement = myDoc.DocumentElement;
            if (!Page.IsPostBack)
            {
                foreach (XmlNode node in rootElement.ChildNodes)
                {
                    ListBox1.Items.Add(node["name"].InnerText);
                }

            }


        }

        protected void ShowDetailBtn_Click(object sender, EventArgs e)
        {
            if (ListBox1.SelectedIndex < 0)
            {
                NameLabel.Text = "Please select a dish in the list above!";
            }
            else
            {
                
                string name = ListBox1.SelectedValue;
                XmlDocument myDoc = new XmlDocument();
                string filepath = HttpRuntime.AppDomainAppPath + @"App_Data/Menu.xml";
                myDoc.Load(filepath);
                XmlElement rootElement = myDoc.DocumentElement;
                foreach (XmlNode node in rootElement.ChildNodes)
                {
                    if (node["name"].InnerText == name)
                    {
                        NameLabel.Text = "Name : " + node["name"].InnerText;
                        DescriptionLabel.Text = "Description :" + node["description"].InnerText;
                        PriceLabel.Text = "Price :" + node["price"].InnerText;
                    }
                }
                

            }
        }

        protected void AddToCartBtn_Click(object sender, EventArgs e)
        {
            if (ListBox1.SelectedIndex < 0)
            {
                NameLabel.Text = "Please select a dish in the list above!";
            }
            else
            {
                Double totalAmount = 0;
                if (ViewState["Sum"] == null)
                    ViewState["Sum"] = 0;
                
                string name = ListBox1.SelectedValue;
                ListBox2.Items.Add(name);
                XmlDocument myDoc = new XmlDocument();
                string filepath = HttpRuntime.AppDomainAppPath + @"App_Data/Menu.xml";
                myDoc.Load(filepath);
                XmlElement rootElement = myDoc.DocumentElement;
                foreach (XmlNode node in rootElement.ChildNodes)
                {
                    if (node["name"].InnerText == name)
                    {
                        totalAmount = Convert.ToDouble(ViewState["Sum"]);
                        totalAmount = totalAmount + Convert.ToDouble(node["price"].InnerText);
                        ViewState["Sum"] = totalAmount;
                        TotalAmountLabel.Text = Convert.ToString(totalAmount);

                        break;
                    }
                }
                

            }
        }
    }
}