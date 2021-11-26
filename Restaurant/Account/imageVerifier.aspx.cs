using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Restaurant.Account
{
    public partial class imageVerifier : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Clear();
            myImageRef.Service1Client myProxy = new myImageRef.Service1Client();
            string myStr;
            if (Session["generatedString"] == null)
            {
                myStr = myProxy.GetVerifierString(5);
                Session["generatedString"] = myStr;
            }
            else
            {
                myStr = Session["generatedString"].ToString();
            }
            Byte[] bytes = myProxy.GetImage(myStr);
            Stream stream = new MemoryStream(bytes);
            System.Drawing.Image myImage = System.Drawing.Image.FromStream(stream);
            Response.ContentType = "image/jpeg";
            myImage.Save(Response.OutputStream, System.Drawing.Imaging.ImageFormat.Jpeg);
        }
    }
}