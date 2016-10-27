using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ClientPFHD
{
    public partial class FormClientPFHD : Form
    {
        public FormClientPFHD()
        {
            InitializeComponent();
        }

        public static HttpWebResponse PostMethod(string postedData, string postUrl, string boundary, byte[] boundarybytes, NameValueCollection nvc, string filename, FileStream fileStream)
        {
            //string boundary = "--" + DateTime.Now.Ticks.ToString("x");
            //byte[] boundarybytes = System.Text.Encoding.ASCII.GetBytes("\r\n--" + boundary + "\r\n");


            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(postUrl);
            request.ContentType = "multipart/form-data; boundary=" + boundary;
            //request.ContentType = "multipart/form-data; boundary=--8ba90904-d8f4-4a64-9e80-8e6e87983e6f--";
            request.Method = "POST";
            //request.Credentials = CredentialCache.DefaultCredentials;
            request.Host = "pfhd.edu.ru";
            request.KeepAlive = false;
            
            using (Stream rs = request.GetRequestStream())
            {
                string formdataTemplate = "Content-Disposition: form-data; name=\"{0}\"\r\n\r\n{1}";

                foreach (string key in nvc.Keys)
                {
                    rs.Write(boundarybytes, 0, boundarybytes.Length);
                    string formitem = string.Format(formdataTemplate, key, nvc[key]);
                    byte[] formitembytes = System.Text.Encoding.UTF8.GetBytes(formitem);
                    rs.Write(formitembytes, 0, formitembytes.Length);

                }
                rs.Write(boundarybytes, 0, boundarybytes.Length);

                string headerTemplate = "Content-Disposition: form-data; name=\"{0}\"; filename=\"{1}\"\r\nContent-Type: {2}\r\n\r\n";
                string header = string.Format(headerTemplate, "content", filename, "text/xml");
                byte[] headerbytes = System.Text.Encoding.UTF8.GetBytes(header);
                rs.Write(headerbytes, 0, headerbytes.Length);

                //FileStream fileStream = new FileStream(pathfile + "/" + filename, FileMode.Open, FileAccess.Read);
                byte[] buffer = new byte[4096];
                int bytesRead = 0;
                while ((bytesRead = fileStream.Read(buffer, 0, buffer.Length)) != 0)
                {
                    rs.Write(buffer, 0, bytesRead);
                }
                fileStream.Close();
                byte[] trailer = System.Text.Encoding.ASCII.GetBytes("\r\n--" + boundary + "--\r\n");
                rs.Write(trailer, 0, trailer.Length);
                rs.Close();
                HttpWebResponse wresp = null;
                try
                {
                    wresp = (HttpWebResponse)request.GetResponse();
                    //Stream stream2 = wresp.GetResponseStream();
                    return wresp;
                    //StreamReader reader2 = new StreamReader(stream2,Encoding.UTF8);
                    //return string.Format("File uploaded, server response is: {0}", reader2.ReadToEnd());

                }
                catch (WebException wex)
                {
                    if (wresp != null)
                    {
                        wresp.Close();
                        wresp = null;
                        if (wex.Status == WebExceptionStatus.ProtocolError)
                            return (HttpWebResponse)wex.Response;                   
                    }
                    return (HttpWebResponse)wex.Response;

                }
                finally
                {
                    request = null;
                }
            }
            


            /*UTF8Encoding encoding = new UTF8Encoding();
            var bytes = encoding.GetBytes(postedData);

            request.ContentLength = bytes.Length;
            HttpRequestCachePolicy noCachePolicy = new HttpRequestCachePolicy(HttpRequestCacheLevel.NoCacheNoStore);
            request.CachePolicy = noCachePolicy;

            using (var newStream = request.GetRequestStream())
            {
                newStream.Write(bytes, 0, bytes.Length);
                newStream.Close();
            }
            try
            {
                return (HttpWebResponse)request.GetResponse();
            }
            catch (WebException wex)
            {
                if (wex.Status == WebExceptionStatus.ProtocolError)
                    return (HttpWebResponse)wex.Response;
                else
                    throw;
            }*/
            
        }
        private void buttonOpenXML_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                System.IO.StreamReader sr = new System.IO.StreamReader(openFileDialog1.FileName);
                string sxml = sr.ReadToEnd().ToString();
                // string newsxml = "";
                //string newsxml = ProcessData(sxml);
                // this.textBox3.Text = newsxml;
                this.textBoxXML.Text = sxml;
                sr.Close();
                string put = openFileDialog1.FileName;
                this.filenameTB.Text = openFileDialog1.SafeFileName;
                // this.textBox7.Text = put;
                this.pathFileTB.Text = put;
            }
            string s = this.textBoxXML.Text;
            if (String.IsNullOrWhiteSpace(s))
                s = "<Root></Root>";
            XElement xElement = null;
            try
            {
                xElement = XElement.Load(new StringReader(s));
            }
            catch (Exception)
            {
                MessageBox.Show("Неверный XML");
                return;
            }
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {

            string postedData,host, ApiUrl;
            string boundaryText = "--" + DateTime.Now.Ticks.ToString("x");
            byte[] boundarybytes = System.Text.Encoding.ASCII.GetBytes("\r\n--" + boundaryText + "\r\n");

            host = "http://pfhd.edu.ru";
            ApiUrl = host + this.methodCB.Text;
            //boundaryText = "--8ba90904-d8f4-4a64-9e80-8e6e87983e6f";
            postedData = boundaryText+ "\r\n";
            postedData += "Content-Disposition: form-data; name=\"AC.Login\"\r\n\r\n";
            postedData += this.loginTB.Text + "\r\n";
            postedData += boundaryText + "\r\n";
            postedData += "Content-Disposition: form-data; name =\"AC.Password\"\r\n\r\n";
            postedData += this.passwordTB.Text + "\r\n";
            postedData += boundaryText + "\r\n";
            postedData += "Content-Disposition: form-data; name =\"URI\"\r\n\r\n";
            postedData += this.uriCB.Text + "\r\n";
            postedData += boundaryText + "\r\n";
            postedData += "Content-Disposition: form-data; name =\"content\"; filename=\""+ this.filenameTB.Text  + "\"\r\n\r\n";
            postedData += "Content-Type: text/xml\r\n\r\n";
            postedData += this.textBoxXML.Text;
            postedData += boundaryText + "--\r\n";

            NameValueCollection myCol = new NameValueCollection();
            myCol.Add("AC.Login", this.loginTB.Text);
            myCol.Add("AC.Password", this.passwordTB.Text);
            myCol.Add("URI", this.uriCB.Text);

            FileStream fileStream = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);

            var response = PostMethod(postedData,ApiUrl,boundaryText,boundarybytes,myCol,this.filenameTB.Text,fileStream);
            if (response != null)
            {
                var strreader = new StreamReader(response.GetResponseStream(), Encoding.UTF8);
                var responseToString = strreader.ReadToEnd();
                tBresponse.Text = responseToString;
            }
            
        }
    }
}
