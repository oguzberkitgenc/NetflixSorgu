namespace NetflixSorgu
{
    partial class Form1
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSorgulamaSayfasi = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnKod = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnIp = new System.Windows.Forms.Button();
            this.lblIp = new System.Windows.Forms.Label();
            this.listKodlar = new System.Windows.Forms.ListBox();
            this.webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.webView21, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1385, 770);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.listKodlar, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 542);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 225F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1379, 225);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSorgulamaSayfasi);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnKod);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.btnIp);
            this.panel1.Controls.Add(this.lblIp);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(683, 219);
            this.panel1.TabIndex = 0;
            // 
            // btnSorgulamaSayfasi
            // 
            this.btnSorgulamaSayfasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSorgulamaSayfasi.Location = new System.Drawing.Point(6, 124);
            this.btnSorgulamaSayfasi.Name = "btnSorgulamaSayfasi";
            this.btnSorgulamaSayfasi.Size = new System.Drawing.Size(212, 39);
            this.btnSorgulamaSayfasi.TabIndex = 7;
            this.btnSorgulamaSayfasi.Text = "Sorgulama Sayfası";
            this.btnSorgulamaSayfasi.UseVisualStyleBackColor = true;
            this.btnSorgulamaSayfasi.Click += new System.EventHandler(this.btnSorgulamaSayfasi_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(235, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(212, 39);
            this.button1.TabIndex = 4;
            this.button1.Text = "yaz";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnKod
            // 
            this.btnKod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKod.Location = new System.Drawing.Point(466, 36);
            this.btnKod.Name = "btnKod";
            this.btnKod.Size = new System.Drawing.Size(212, 39);
            this.btnKod.TabIndex = 3;
            this.btnKod.Text = "Kod Sorgula";
            this.btnKod.UseVisualStyleBackColor = true;
            this.btnKod.Click += new System.EventHandler(this.btnKod_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(6, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(672, 27);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "NAA3QU2VZH88WR4C";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnIp
            // 
            this.btnIp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIp.Location = new System.Drawing.Point(6, 79);
            this.btnIp.Name = "btnIp";
            this.btnIp.Size = new System.Drawing.Size(212, 39);
            this.btnIp.TabIndex = 5;
            this.btnIp.Text = "IP Sorgula";
            this.btnIp.UseVisualStyleBackColor = true;
            this.btnIp.Click += new System.EventHandler(this.btnIp_Click);
            // 
            // lblIp
            // 
            this.lblIp.AutoSize = true;
            this.lblIp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIp.Location = new System.Drawing.Point(17, 43);
            this.lblIp.Name = "lblIp";
            this.lblIp.Size = new System.Drawing.Size(157, 22);
            this.lblIp.TabIndex = 3;
            this.lblIp.Text = "IP Sorgulanıyor ....";
            // 
            // listKodlar
            // 
            this.listKodlar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listKodlar.FormattingEnabled = true;
            this.listKodlar.ItemHeight = 16;
            this.listKodlar.Location = new System.Drawing.Point(692, 3);
            this.listKodlar.Name = "listKodlar";
            this.listKodlar.Size = new System.Drawing.Size(684, 219);
            this.listKodlar.TabIndex = 1;
            // 
            // webView21
            // 
            this.webView21.AllowExternalDrop = true;
            this.webView21.CreationProperties = null;
            this.webView21.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webView21.Location = new System.Drawing.Point(3, 3);
            this.webView21.Name = "webView21";
            this.webView21.Size = new System.Drawing.Size(1379, 533);
            this.webView21.TabIndex = 0;
            this.webView21.ZoomFactor = 1D;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1385, 770);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1403, 817);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1403, 817);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnIp;
        private System.Windows.Forms.Button btnKod;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.ListBox listKodlar;
        private System.Windows.Forms.Button btnSorgulamaSayfasi;
        public System.Windows.Forms.Label lblIp;
        public Microsoft.Web.WebView2.WinForms.WebView2 webView21;
    }
}

