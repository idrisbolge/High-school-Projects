namespace MarketOtomasyonu
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.işlemlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yardımToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCikis = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnSatisGoster = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSatisIslem = new System.Windows.Forms.Button();
            this.btnStokIslem = new System.Windows.Forms.Button();
            this.btnKasiyerIslem = new System.Windows.Forms.Button();
            this.btnUrunIslem = new System.Windows.Forms.Button();
            this.btnMusIslem = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 438);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(807, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem,
            this.işlemlerToolStripMenuItem,
            this.yardımToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(807, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.dosyaToolStripMenuItem.Text = "Dosya";
            // 
            // işlemlerToolStripMenuItem
            // 
            this.işlemlerToolStripMenuItem.Name = "işlemlerToolStripMenuItem";
            this.işlemlerToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.işlemlerToolStripMenuItem.Text = "İşlemler";
            // 
            // yardımToolStripMenuItem
            // 
            this.yardımToolStripMenuItem.Name = "yardımToolStripMenuItem";
            this.yardımToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.yardımToolStripMenuItem.Text = "Yardım";
            // 
            // btnCikis
            // 
            this.btnCikis.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCikis.ImageKey = "cikis.png";
            this.btnCikis.Location = new System.Drawing.Point(592, 47);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(83, 54);
            this.btnCikis.TabIndex = 150;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCikis.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(473, 127);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(96, 20);
            this.dateTimePicker1.TabIndex = 149;
            this.dateTimePicker1.Value = new System.DateTime(2015, 4, 19, 0, 0, 0, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // btnSatisGoster
            // 
            this.btnSatisGoster.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSatisGoster.ImageIndex = 1;
            this.btnSatisGoster.Location = new System.Drawing.Point(679, 107);
            this.btnSatisGoster.Name = "btnSatisGoster";
            this.btnSatisGoster.Size = new System.Drawing.Size(83, 54);
            this.btnSatisGoster.TabIndex = 148;
            this.btnSatisGoster.Text = "Göster";
            this.btnSatisGoster.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSatisGoster.UseVisualStyleBackColor = true;
            this.btnSatisGoster.Click += new System.EventHandler(this.btnSatisGoster_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(208, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 31);
            this.label1.TabIndex = 147;
            this.label1.Text = "Satış Listesi";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.Location = new System.Drawing.Point(40, 167);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.Size = new System.Drawing.Size(722, 242);
            this.dataGridView1.TabIndex = 146;
            // 
            // btnSatisIslem
            // 
            this.btnSatisIslem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSatisIslem.ImageKey = "satış.png";
            this.btnSatisIslem.Location = new System.Drawing.Point(486, 47);
            this.btnSatisIslem.Name = "btnSatisIslem";
            this.btnSatisIslem.Size = new System.Drawing.Size(83, 54);
            this.btnSatisIslem.TabIndex = 145;
            this.btnSatisIslem.Text = "Satış İşlemleri";
            this.btnSatisIslem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSatisIslem.UseVisualStyleBackColor = true;
            this.btnSatisIslem.Click += new System.EventHandler(this.btnSatisIslem_Click);
            // 
            // btnStokIslem
            // 
            this.btnStokIslem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnStokIslem.ImageKey = "stok.png";
            this.btnStokIslem.Location = new System.Drawing.Point(380, 47);
            this.btnStokIslem.Name = "btnStokIslem";
            this.btnStokIslem.Size = new System.Drawing.Size(83, 54);
            this.btnStokIslem.TabIndex = 144;
            this.btnStokIslem.Text = "Stok İşlemleri";
            this.btnStokIslem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnStokIslem.UseVisualStyleBackColor = true;
            this.btnStokIslem.Click += new System.EventHandler(this.btnStokIslem_Click);
            // 
            // btnKasiyerIslem
            // 
            this.btnKasiyerIslem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnKasiyerIslem.ImageKey = "person.png";
            this.btnKasiyerIslem.Location = new System.Drawing.Point(261, 47);
            this.btnKasiyerIslem.Name = "btnKasiyerIslem";
            this.btnKasiyerIslem.Size = new System.Drawing.Size(96, 54);
            this.btnKasiyerIslem.TabIndex = 143;
            this.btnKasiyerIslem.Text = "Kasiyer İşlemleri";
            this.btnKasiyerIslem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnKasiyerIslem.UseVisualStyleBackColor = true;
            this.btnKasiyerIslem.Click += new System.EventHandler(this.btnKasiyerIslem_Click);
            // 
            // btnUrunIslem
            // 
            this.btnUrunIslem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnUrunIslem.ImageIndex = 6;
            this.btnUrunIslem.Location = new System.Drawing.Point(155, 47);
            this.btnUrunIslem.Name = "btnUrunIslem";
            this.btnUrunIslem.Size = new System.Drawing.Size(83, 54);
            this.btnUrunIslem.TabIndex = 142;
            this.btnUrunIslem.Text = "Ürün İşlemleri";
            this.btnUrunIslem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUrunIslem.UseVisualStyleBackColor = true;
            this.btnUrunIslem.Click += new System.EventHandler(this.btnUrunIslem_Click);
            // 
            // btnMusIslem
            // 
            this.btnMusIslem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMusIslem.ImageKey = "musteri.png";
            this.btnMusIslem.Location = new System.Drawing.Point(42, 47);
            this.btnMusIslem.Name = "btnMusIslem";
            this.btnMusIslem.Size = new System.Drawing.Size(90, 54);
            this.btnMusIslem.TabIndex = 141;
            this.btnMusIslem.Text = "Müşteri İşlemleri";
            this.btnMusIslem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMusIslem.UseVisualStyleBackColor = true;
            this.btnMusIslem.Click += new System.EventHandler(this.btnMusIslem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 460);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnSatisGoster);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSatisIslem);
            this.Controls.Add(this.btnStokIslem);
            this.Controls.Add(this.btnKasiyerIslem);
            this.Controls.Add(this.btnUrunIslem);
            this.Controls.Add(this.btnMusIslem);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnSatisGoster;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSatisIslem;
        private System.Windows.Forms.Button btnStokIslem;
        private System.Windows.Forms.Button btnKasiyerIslem;
        private System.Windows.Forms.Button btnUrunIslem;
        private System.Windows.Forms.Button btnMusIslem;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem işlemlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yardımToolStripMenuItem;
    }
}

