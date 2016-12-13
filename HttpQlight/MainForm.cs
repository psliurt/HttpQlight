using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HttpRS;
namespace HttpQlight
{
    public partial class MainForm : Form
    {
        
        public MainForm()
        {
            InitializeComponent();
            schemaCmb.SelectedIndex = 0;
        }

        private void sendRqBtn_Click(object sender, EventArgs e)
        {
            httpRespHeaderTxt.Clear();
            if (string.IsNullOrEmpty(schemaCmb.Text))
            {
                MessageBox.Show("請選擇要使用 [ Http ] 或是 [ Https ] !");
            }

            if (string.IsNullOrEmpty(urlTxt.Text))
            {
                MessageBox.Show("請填寫 URL !");
            }

            HttpSender http = new HttpSender();
            http.SetRequestEncoding(Encoding.UTF8);
            try
            {
                http.SetUrl(string.Format("{0}{1}", schemaCmb.Text.Trim(), urlTxt.Text.Trim()));
            }
            catch (Exception ecp)
            {
                MessageBox.Show("請檢查Url是否有填寫或是否填寫正確!");
            }
            HttpHeaderList headers = new HttpHeaderList();
            foreach (DataGridViewRow r in headerGrdVw.Rows)
            {
                if (r.Cells[0].Value != null)
                {
                    headers.AddHeader(r.Cells[0].Value.ToString(), r.Cells[1].Value.ToString());
                }
            }

            ResponseResult result = http.SendRequest(http.ParseHttpMethod(methodCmb.Text.ToUpper()), httpBodyTxt.Text.Trim(), headers);

            HttpHeaderList respHeaders = http.GetResponseHeaders();
            if (respHeaders != null)
            {
                httpRespHeaderTxt.Clear();
                foreach (KeyValuePair<string, string> h in respHeaders.GetHeaderCollection())
                {
                    httpRespHeaderTxt.AppendText(
                        string.Format("{0} : {1}\r\n", h.Key, h.Value));
                }
            }
            httpRespBodyTxt.Text = result.ResponseBody;
        }

        private void addHeaderBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(reqHeaderKeyCmb.Text))
            { return; }

            if (string.IsNullOrEmpty(reqHeaderValTxt.Text))
            { return; }

            foreach (DataGridViewRow r in headerGrdVw.Rows)
            {                
                if (r.Cells[0].Value != null &&
                    r.Cells[0].Value.ToString() == reqHeaderKeyCmb.Text)
                {
                    MessageBox.Show("該Header已存在!");
                    return;
                }
            }

            DataGridViewRow row = new DataGridViewRow();
            row.CreateCells(headerGrdVw);
            row.Cells[0].Value = reqHeaderKeyCmb.Text;
            row.Cells[1].Value = reqHeaderValTxt.Text;
            headerGrdVw.Rows.Add(row);

            reqHeaderKeyCmb.SelectedIndex = 0;
            reqHeaderValTxt.Text = string.Empty;
        }

        private void urlTxt_TextChanged(object sender, EventArgs e)
        {
            if (urlTxt.Text.Trim().StartsWith("http://"))
            {
                urlTxt.Text = urlTxt.Text.Trim().TrimStart("http://".ToCharArray());
            }
            if (urlTxt.Text.Trim().StartsWith("https://"))
            {
                urlTxt.Text = urlTxt.Text.Trim().TrimStart("https://".ToCharArray());
            }
        }

        private void clearHeaderBtn_Click(object sender, EventArgs e)
        {
            reqHeaderKeyCmb.SelectedIndex = 0;
            reqHeaderValTxt.Text = string.Empty;
            headerGrdVw.Rows.Clear();
        }

        private void methodCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(methodCmb.Text))
            { return; }

            httpBodyTxt.Enabled = methodCmb.Text.Trim() == "GET" ? false : true;
        }
    }    
}
