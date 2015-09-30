using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace tx_mvc_tutorial
{
    public partial class Editor : System.Web.UI.Page
    {
        protected void Button1_Click(object sender, EventArgs e)
        {
            // save the document to a string variable
            var RTFDocument = String.Empty;
            TextControl1.SaveText(out RTFDocument, TXTextControl.Web.StringStreamType.RichTextFormat);

            // create a new WebRequest
            WebRequest request = WebRequest.Create("http://" + Request.Url.Authority + "/Home/SaveTemplate");

            // set the POST data
            var postData = "documentName=" + TextBox1.Text;
                postData += "&document=" + RTFDocument;
            
            // encode the data as an byte[] array
            var data = Encoding.ASCII.GetBytes(postData);

            // set the method, content type and length
            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = data.Length;

            // write the data to the request stream
            using (var stream = request.GetRequestStream())
            {
                stream.Write(data, 0, data.Length);
            }

            // get response from HttpPost method
            WebResponse response = (HttpWebResponse)request.GetResponse();

            // read the data and check for return value "True"
            var dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);

            string sReturnValue = reader.ReadToEnd();

            if (sReturnValue == "True")
                lblInfo.Visible = true;
        }
    }
}