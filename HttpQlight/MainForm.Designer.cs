namespace HttpQlight
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.urlTxt = new System.Windows.Forms.TextBox();
            this.schemaCmb = new System.Windows.Forms.ComboBox();
            this.urlLbl = new System.Windows.Forms.Label();
            this.sendRqBtn = new System.Windows.Forms.Button();
            this.reqHeaderKeyCmb = new System.Windows.Forms.ComboBox();
            this.requestHeaderLbl = new System.Windows.Forms.Label();
            this.headerValLbl = new System.Windows.Forms.Label();
            this.reqHeaderValTxt = new System.Windows.Forms.TextBox();
            this.headerGrdVw = new System.Windows.Forms.DataGridView();
            this.headerKeyCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.headerValCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addHeaderBtn = new System.Windows.Forms.Button();
            this.methodCmb = new System.Windows.Forms.ComboBox();
            this.methodLbl = new System.Windows.Forms.Label();
            this.httpBodyTxt = new System.Windows.Forms.TextBox();
            this.httpBodyLbl = new System.Windows.Forms.Label();
            this.functionTabCtrl = new System.Windows.Forms.TabControl();
            this.httpSettingTab = new System.Windows.Forms.TabPage();
            this.clearHeaderBtn = new System.Windows.Forms.Button();
            this.requestTab = new System.Windows.Forms.TabPage();
            this.responseTab = new System.Windows.Forms.TabPage();
            this.httpRespHeaderTxt = new System.Windows.Forms.TextBox();
            this.httpRespHeaderLbl = new System.Windows.Forms.Label();
            this.httpRespBodyLbl = new System.Windows.Forms.Label();
            this.httpRespBodyTxt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.headerGrdVw)).BeginInit();
            this.functionTabCtrl.SuspendLayout();
            this.httpSettingTab.SuspendLayout();
            this.responseTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // urlTxt
            // 
            this.urlTxt.AutoCompleteCustomSource.AddRange(new string[] {
            "localhost",
            "127.0.0.1"});
            this.urlTxt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.urlTxt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.urlTxt.Location = new System.Drawing.Point(128, 3);
            this.urlTxt.Name = "urlTxt";
            this.urlTxt.Size = new System.Drawing.Size(669, 22);
            this.urlTxt.TabIndex = 1;
            this.urlTxt.TextChanged += new System.EventHandler(this.urlTxt_TextChanged);
            // 
            // schemaCmb
            // 
            this.schemaCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.schemaCmb.FormattingEnabled = true;
            this.schemaCmb.Items.AddRange(new object[] {
            "http://",
            "https://"});
            this.schemaCmb.Location = new System.Drawing.Point(62, 3);
            this.schemaCmb.Name = "schemaCmb";
            this.schemaCmb.Size = new System.Drawing.Size(60, 20);
            this.schemaCmb.TabIndex = 0;
            // 
            // urlLbl
            // 
            this.urlLbl.Location = new System.Drawing.Point(6, 3);
            this.urlLbl.Name = "urlLbl";
            this.urlLbl.Size = new System.Drawing.Size(50, 23);
            this.urlLbl.TabIndex = 8;
            this.urlLbl.Text = "URL";
            this.urlLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sendRqBtn
            // 
            this.sendRqBtn.Location = new System.Drawing.Point(170, 31);
            this.sendRqBtn.Name = "sendRqBtn";
            this.sendRqBtn.Size = new System.Drawing.Size(104, 23);
            this.sendRqBtn.TabIndex = 3;
            this.sendRqBtn.Text = "Send Request";
            this.sendRqBtn.UseVisualStyleBackColor = true;
            this.sendRqBtn.Click += new System.EventHandler(this.sendRqBtn_Click);
            // 
            // reqHeaderKeyCmb
            // 
            this.reqHeaderKeyCmb.FormattingEnabled = true;
            this.reqHeaderKeyCmb.Items.AddRange(new object[] {
            "Accept",
            "Accept-Charset",
            "Accept-Encoding",
            "Accept-Language",
            "Accept-Ranges",
            "Age",
            "Allow",
            "Authorization",
            "Cache-Control",
            "Connection",
            "Content-Encoding",
            "Content-Language",
            "Content-Langth",
            "Content-Location",
            "Content-MD5",
            "Content-Range",
            "Content-Type",
            "Date",
            "ETag",
            "Expect",
            "Expires",
            "From",
            "Host",
            "If-Match",
            "If-Modified-Since",
            "If-None-Match",
            "If-Range",
            "If-Unmodified-Since",
            "Last-Modified",
            "Location",
            "Max-Forwards",
            "Pragma",
            "Proxy-Authenticate",
            "Proxy-Authorization",
            "Range",
            "Refer",
            "Retry-After",
            "Server",
            "TE",
            "Trailer",
            "Transfer-Encoding",
            "Upgrade",
            "User-Agent",
            "Vary",
            "Via",
            "Warning",
            "WWW-Authenticate"});
            this.reqHeaderKeyCmb.Location = new System.Drawing.Point(92, 61);
            this.reqHeaderKeyCmb.Name = "reqHeaderKeyCmb";
            this.reqHeaderKeyCmb.Size = new System.Drawing.Size(226, 20);
            this.reqHeaderKeyCmb.TabIndex = 4;
            // 
            // requestHeaderLbl
            // 
            this.requestHeaderLbl.Location = new System.Drawing.Point(6, 60);
            this.requestHeaderLbl.Name = "requestHeaderLbl";
            this.requestHeaderLbl.Size = new System.Drawing.Size(80, 20);
            this.requestHeaderLbl.TabIndex = 10;
            this.requestHeaderLbl.Text = "Request Header";
            this.requestHeaderLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // headerValLbl
            // 
            this.headerValLbl.Location = new System.Drawing.Point(324, 61);
            this.headerValLbl.Name = "headerValLbl";
            this.headerValLbl.Size = new System.Drawing.Size(80, 20);
            this.headerValLbl.TabIndex = 11;
            this.headerValLbl.Text = "Header Value";
            this.headerValLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // reqHeaderValTxt
            // 
            this.reqHeaderValTxt.AutoCompleteCustomSource.AddRange(new string[] {
            "application/json",
            "application/json; charset=utf-8"});
            this.reqHeaderValTxt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.reqHeaderValTxt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.reqHeaderValTxt.Location = new System.Drawing.Point(410, 61);
            this.reqHeaderValTxt.Name = "reqHeaderValTxt";
            this.reqHeaderValTxt.Size = new System.Drawing.Size(387, 22);
            this.reqHeaderValTxt.TabIndex = 5;
            // 
            // headerGrdVw
            // 
            this.headerGrdVw.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.headerGrdVw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.headerGrdVw.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.headerKeyCol,
            this.headerValCol});
            this.headerGrdVw.Location = new System.Drawing.Point(8, 116);
            this.headerGrdVw.Name = "headerGrdVw";
            this.headerGrdVw.RowHeadersVisible = false;
            this.headerGrdVw.RowTemplate.Height = 24;
            this.headerGrdVw.Size = new System.Drawing.Size(789, 150);
            this.headerGrdVw.TabIndex = 8;
            // 
            // headerKeyCol
            // 
            this.headerKeyCol.HeaderText = "header";
            this.headerKeyCol.Name = "headerKeyCol";
            this.headerKeyCol.ReadOnly = true;
            // 
            // headerValCol
            // 
            this.headerValCol.HeaderText = "header value";
            this.headerValCol.Name = "headerValCol";
            this.headerValCol.ReadOnly = true;
            // 
            // addHeaderBtn
            // 
            this.addHeaderBtn.Location = new System.Drawing.Point(8, 87);
            this.addHeaderBtn.Name = "addHeaderBtn";
            this.addHeaderBtn.Size = new System.Drawing.Size(116, 23);
            this.addHeaderBtn.TabIndex = 6;
            this.addHeaderBtn.Text = "Add Header";
            this.addHeaderBtn.UseVisualStyleBackColor = true;
            this.addHeaderBtn.Click += new System.EventHandler(this.addHeaderBtn_Click);
            // 
            // methodCmb
            // 
            this.methodCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.methodCmb.FormattingEnabled = true;
            this.methodCmb.Items.AddRange(new object[] {
            "GET",
            "POST",
            "PUT",
            "DELETE",
            "OPTIONS",
            "TRACE",
            "CONNECT",
            "HEAD",
            "SAFE",
            "IDEMPOTENT"});
            this.methodCmb.Location = new System.Drawing.Point(62, 33);
            this.methodCmb.Name = "methodCmb";
            this.methodCmb.Size = new System.Drawing.Size(102, 20);
            this.methodCmb.TabIndex = 2;
            this.methodCmb.SelectedIndexChanged += new System.EventHandler(this.methodCmb_SelectedIndexChanged);
            // 
            // methodLbl
            // 
            this.methodLbl.Location = new System.Drawing.Point(8, 31);
            this.methodLbl.Name = "methodLbl";
            this.methodLbl.Size = new System.Drawing.Size(48, 23);
            this.methodLbl.TabIndex = 9;
            this.methodLbl.Text = "Method";
            this.methodLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // httpBodyTxt
            // 
            this.httpBodyTxt.Location = new System.Drawing.Point(8, 295);
            this.httpBodyTxt.Multiline = true;
            this.httpBodyTxt.Name = "httpBodyTxt";
            this.httpBodyTxt.Size = new System.Drawing.Size(789, 297);
            this.httpBodyTxt.TabIndex = 7;
            // 
            // httpBodyLbl
            // 
            this.httpBodyLbl.Location = new System.Drawing.Point(8, 269);
            this.httpBodyLbl.Name = "httpBodyLbl";
            this.httpBodyLbl.Size = new System.Drawing.Size(80, 23);
            this.httpBodyLbl.TabIndex = 12;
            this.httpBodyLbl.Text = "Http Body";
            this.httpBodyLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // functionTabCtrl
            // 
            this.functionTabCtrl.Controls.Add(this.httpSettingTab);
            this.functionTabCtrl.Controls.Add(this.requestTab);
            this.functionTabCtrl.Controls.Add(this.responseTab);
            this.functionTabCtrl.Location = new System.Drawing.Point(12, 12);
            this.functionTabCtrl.Name = "functionTabCtrl";
            this.functionTabCtrl.SelectedIndex = 0;
            this.functionTabCtrl.Size = new System.Drawing.Size(819, 622);
            this.functionTabCtrl.TabIndex = 14;
            // 
            // httpSettingTab
            // 
            this.httpSettingTab.Controls.Add(this.clearHeaderBtn);
            this.httpSettingTab.Controls.Add(this.urlLbl);
            this.httpSettingTab.Controls.Add(this.httpBodyLbl);
            this.httpSettingTab.Controls.Add(this.urlTxt);
            this.httpSettingTab.Controls.Add(this.httpBodyTxt);
            this.httpSettingTab.Controls.Add(this.schemaCmb);
            this.httpSettingTab.Controls.Add(this.methodLbl);
            this.httpSettingTab.Controls.Add(this.sendRqBtn);
            this.httpSettingTab.Controls.Add(this.methodCmb);
            this.httpSettingTab.Controls.Add(this.reqHeaderKeyCmb);
            this.httpSettingTab.Controls.Add(this.addHeaderBtn);
            this.httpSettingTab.Controls.Add(this.requestHeaderLbl);
            this.httpSettingTab.Controls.Add(this.headerGrdVw);
            this.httpSettingTab.Controls.Add(this.headerValLbl);
            this.httpSettingTab.Controls.Add(this.reqHeaderValTxt);
            this.httpSettingTab.Location = new System.Drawing.Point(4, 22);
            this.httpSettingTab.Name = "httpSettingTab";
            this.httpSettingTab.Padding = new System.Windows.Forms.Padding(3);
            this.httpSettingTab.Size = new System.Drawing.Size(811, 596);
            this.httpSettingTab.TabIndex = 0;
            this.httpSettingTab.Text = "Http Setting";
            this.httpSettingTab.UseVisualStyleBackColor = true;
            // 
            // clearHeaderBtn
            // 
            this.clearHeaderBtn.Location = new System.Drawing.Point(130, 87);
            this.clearHeaderBtn.Name = "clearHeaderBtn";
            this.clearHeaderBtn.Size = new System.Drawing.Size(115, 23);
            this.clearHeaderBtn.TabIndex = 13;
            this.clearHeaderBtn.Text = "Clear Header";
            this.clearHeaderBtn.UseVisualStyleBackColor = true;
            this.clearHeaderBtn.Click += new System.EventHandler(this.clearHeaderBtn_Click);
            // 
            // requestTab
            // 
            this.requestTab.Location = new System.Drawing.Point(4, 22);
            this.requestTab.Name = "requestTab";
            this.requestTab.Padding = new System.Windows.Forms.Padding(3);
            this.requestTab.Size = new System.Drawing.Size(811, 596);
            this.requestTab.TabIndex = 1;
            this.requestTab.Text = "Request";
            this.requestTab.UseVisualStyleBackColor = true;
            // 
            // responseTab
            // 
            this.responseTab.Controls.Add(this.httpRespHeaderTxt);
            this.responseTab.Controls.Add(this.httpRespHeaderLbl);
            this.responseTab.Controls.Add(this.httpRespBodyLbl);
            this.responseTab.Controls.Add(this.httpRespBodyTxt);
            this.responseTab.Location = new System.Drawing.Point(4, 22);
            this.responseTab.Name = "responseTab";
            this.responseTab.Size = new System.Drawing.Size(811, 596);
            this.responseTab.TabIndex = 2;
            this.responseTab.Text = "Response";
            this.responseTab.UseVisualStyleBackColor = true;
            // 
            // httpRespHeaderTxt
            // 
            this.httpRespHeaderTxt.Location = new System.Drawing.Point(5, 35);
            this.httpRespHeaderTxt.Multiline = true;
            this.httpRespHeaderTxt.Name = "httpRespHeaderTxt";
            this.httpRespHeaderTxt.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.httpRespHeaderTxt.Size = new System.Drawing.Size(803, 151);
            this.httpRespHeaderTxt.TabIndex = 3;
            // 
            // httpRespHeaderLbl
            // 
            this.httpRespHeaderLbl.Location = new System.Drawing.Point(3, 9);
            this.httpRespHeaderLbl.Name = "httpRespHeaderLbl";
            this.httpRespHeaderLbl.Size = new System.Drawing.Size(113, 23);
            this.httpRespHeaderLbl.TabIndex = 2;
            this.httpRespHeaderLbl.Text = "Http Response Header";
            this.httpRespHeaderLbl.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // httpRespBodyLbl
            // 
            this.httpRespBodyLbl.Location = new System.Drawing.Point(3, 189);
            this.httpRespBodyLbl.Name = "httpRespBodyLbl";
            this.httpRespBodyLbl.Size = new System.Drawing.Size(113, 23);
            this.httpRespBodyLbl.TabIndex = 1;
            this.httpRespBodyLbl.Text = "Http Response Body";
            this.httpRespBodyLbl.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // httpRespBodyTxt
            // 
            this.httpRespBodyTxt.Location = new System.Drawing.Point(3, 215);
            this.httpRespBodyTxt.Multiline = true;
            this.httpRespBodyTxt.Name = "httpRespBodyTxt";
            this.httpRespBodyTxt.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.httpRespBodyTxt.Size = new System.Drawing.Size(805, 378);
            this.httpRespBodyTxt.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 646);
            this.Controls.Add(this.functionTabCtrl);
            this.Name = "MainForm";
            this.Text = "HttpQlight";
            ((System.ComponentModel.ISupportInitialize)(this.headerGrdVw)).EndInit();
            this.functionTabCtrl.ResumeLayout(false);
            this.httpSettingTab.ResumeLayout(false);
            this.httpSettingTab.PerformLayout();
            this.responseTab.ResumeLayout(false);
            this.responseTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox urlTxt;
        private System.Windows.Forms.ComboBox schemaCmb;
        private System.Windows.Forms.Label urlLbl;
        private System.Windows.Forms.Button sendRqBtn;
        private System.Windows.Forms.ComboBox reqHeaderKeyCmb;
        private System.Windows.Forms.Label requestHeaderLbl;
        private System.Windows.Forms.Label headerValLbl;
        private System.Windows.Forms.TextBox reqHeaderValTxt;
        private System.Windows.Forms.DataGridView headerGrdVw;
        private System.Windows.Forms.Button addHeaderBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn headerKeyCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn headerValCol;
        private System.Windows.Forms.ComboBox methodCmb;
        private System.Windows.Forms.Label methodLbl;
        private System.Windows.Forms.TextBox httpBodyTxt;
        private System.Windows.Forms.Label httpBodyLbl;
        private System.Windows.Forms.TabControl functionTabCtrl;
        private System.Windows.Forms.TabPage httpSettingTab;
        private System.Windows.Forms.TabPage requestTab;
        private System.Windows.Forms.TabPage responseTab;
        private System.Windows.Forms.TextBox httpRespBodyTxt;
        private System.Windows.Forms.Label httpRespBodyLbl;
        private System.Windows.Forms.TextBox httpRespHeaderTxt;
        private System.Windows.Forms.Label httpRespHeaderLbl;
        private System.Windows.Forms.Button clearHeaderBtn;
    }
}

