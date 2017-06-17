namespace Dapper
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grid = new MetroFramework.Controls.MetroGrid();
            this.ıDOGRENCIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aDSOYADDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aDRESDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrenciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtAdSoyad = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtAdres = new MetroFramework.Controls.MetroTextBox();
            this.btnKaydet = new MetroFramework.Controls.MetroButton();
            this.btnSil = new MetroFramework.Controls.MetroButton();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.btnListeleEF = new MetroFramework.Controls.MetroButton();
            this.lblHiz = new MetroFramework.Controls.MetroLabel();
            this.btnListeleDapper = new MetroFramework.Controls.MetroButton();
            this.btnAdonet = new MetroFramework.Controls.MetroButton();
            this.btnLinqToSql = new MetroFramework.Controls.MetroButton();
            this.ogrenciBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ogretmenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnMultipleTest = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogretmenBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // grid
            // 
            this.grid.AllowUserToAddRows = false;
            this.grid.AllowUserToDeleteRows = false;
            this.grid.AllowUserToResizeRows = false;
            this.grid.AutoGenerateColumns = false;
            this.grid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grid.ColumnHeadersHeight = 20;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıDOGRENCIDataGridViewTextBoxColumn,
            this.aDSOYADDataGridViewTextBoxColumn,
            this.aDRESDataGridViewTextBoxColumn});
            this.grid.DataSource = this.ogrenciBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid.DefaultCellStyle = dataGridViewCellStyle2;
            this.grid.EnableHeadersVisualStyles = false;
            this.grid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grid.Location = new System.Drawing.Point(482, 150);
            this.grid.Name = "grid";
            this.grid.ReadOnly = true;
            this.grid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grid.RowHeadersWidth = 15;
            this.grid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid.Size = new System.Drawing.Size(393, 390);
            this.grid.TabIndex = 0;
            // 
            // ıDOGRENCIDataGridViewTextBoxColumn
            // 
            this.ıDOGRENCIDataGridViewTextBoxColumn.DataPropertyName = "ID_OGRENCI";
            this.ıDOGRENCIDataGridViewTextBoxColumn.HeaderText = "ID_OGRENCI";
            this.ıDOGRENCIDataGridViewTextBoxColumn.Name = "ıDOGRENCIDataGridViewTextBoxColumn";
            this.ıDOGRENCIDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aDSOYADDataGridViewTextBoxColumn
            // 
            this.aDSOYADDataGridViewTextBoxColumn.DataPropertyName = "ADSOYAD";
            this.aDSOYADDataGridViewTextBoxColumn.HeaderText = "ADSOYAD";
            this.aDSOYADDataGridViewTextBoxColumn.Name = "aDSOYADDataGridViewTextBoxColumn";
            this.aDSOYADDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aDRESDataGridViewTextBoxColumn
            // 
            this.aDRESDataGridViewTextBoxColumn.DataPropertyName = "ADRES";
            this.aDRESDataGridViewTextBoxColumn.HeaderText = "ADRES";
            this.aDRESDataGridViewTextBoxColumn.Name = "aDRESDataGridViewTextBoxColumn";
            this.aDRESDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ogrenciBindingSource
            // 
            this.ogrenciBindingSource.DataSource = typeof(Dapper.Model.Ogrenci);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(482, 66);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(66, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Ad Soyad";
            // 
            // txtAdSoyad
            // 
            // 
            // 
            // 
            this.txtAdSoyad.CustomButton.Image = null;
            this.txtAdSoyad.CustomButton.Location = new System.Drawing.Point(231, 1);
            this.txtAdSoyad.CustomButton.Name = "";
            this.txtAdSoyad.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtAdSoyad.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAdSoyad.CustomButton.TabIndex = 1;
            this.txtAdSoyad.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAdSoyad.CustomButton.UseSelectable = true;
            this.txtAdSoyad.CustomButton.Visible = false;
            this.txtAdSoyad.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ogrenciBindingSource, "ADSOYAD", true));
            this.txtAdSoyad.Lines = new string[0];
            this.txtAdSoyad.Location = new System.Drawing.Point(569, 63);
            this.txtAdSoyad.MaxLength = 32767;
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.PasswordChar = '\0';
            this.txtAdSoyad.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAdSoyad.SelectedText = "";
            this.txtAdSoyad.SelectionLength = 0;
            this.txtAdSoyad.SelectionStart = 0;
            this.txtAdSoyad.ShortcutsEnabled = true;
            this.txtAdSoyad.Size = new System.Drawing.Size(253, 23);
            this.txtAdSoyad.TabIndex = 2;
            this.txtAdSoyad.UseSelectable = true;
            this.txtAdSoyad.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAdSoyad.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(482, 95);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(43, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Adres";
            // 
            // txtAdres
            // 
            // 
            // 
            // 
            this.txtAdres.CustomButton.Image = null;
            this.txtAdres.CustomButton.Location = new System.Drawing.Point(231, 1);
            this.txtAdres.CustomButton.Name = "";
            this.txtAdres.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtAdres.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAdres.CustomButton.TabIndex = 1;
            this.txtAdres.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAdres.CustomButton.UseSelectable = true;
            this.txtAdres.CustomButton.Visible = false;
            this.txtAdres.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ogrenciBindingSource, "ADRES", true));
            this.txtAdres.Lines = new string[0];
            this.txtAdres.Location = new System.Drawing.Point(569, 92);
            this.txtAdres.MaxLength = 32767;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.PasswordChar = '\0';
            this.txtAdres.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAdres.SelectedText = "";
            this.txtAdres.SelectionLength = 0;
            this.txtAdres.SelectionStart = 0;
            this.txtAdres.ShortcutsEnabled = true;
            this.txtAdres.Size = new System.Drawing.Size(253, 23);
            this.txtAdres.TabIndex = 3;
            this.txtAdres.UseSelectable = true;
            this.txtAdres.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAdres.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(720, 121);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(102, 23);
            this.btnKaydet.Style = MetroFramework.MetroColorStyle.Green;
            this.btnKaydet.TabIndex = 4;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseSelectable = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(612, 121);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(102, 23);
            this.btnSil.TabIndex = 5;
            this.btnSil.Text = "Sil";
            this.btnSil.UseSelectable = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            this.metroStyleManager1.Style = MetroFramework.MetroColorStyle.Green;
            // 
            // btnListeleEF
            // 
            this.btnListeleEF.Location = new System.Drawing.Point(23, 63);
            this.btnListeleEF.Name = "btnListeleEF";
            this.btnListeleEF.Size = new System.Drawing.Size(208, 23);
            this.btnListeleEF.TabIndex = 6;
            this.btnListeleEF.Text = "Listele Entity Framework";
            this.btnListeleEF.UseSelectable = true;
            this.btnListeleEF.Click += new System.EventHandler(this.btnListeleEF_Click);
            // 
            // lblHiz
            // 
            this.lblHiz.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHiz.Location = new System.Drawing.Point(23, 121);
            this.lblHiz.Name = "lblHiz";
            this.lblHiz.Size = new System.Drawing.Size(422, 419);
            this.lblHiz.TabIndex = 7;
            // 
            // btnListeleDapper
            // 
            this.btnListeleDapper.Location = new System.Drawing.Point(237, 95);
            this.btnListeleDapper.Name = "btnListeleDapper";
            this.btnListeleDapper.Size = new System.Drawing.Size(208, 23);
            this.btnListeleDapper.TabIndex = 8;
            this.btnListeleDapper.Text = "Listele Dapper";
            this.btnListeleDapper.UseSelectable = true;
            this.btnListeleDapper.Click += new System.EventHandler(this.btnListeleDapper_Click);
            // 
            // btnAdonet
            // 
            this.btnAdonet.Location = new System.Drawing.Point(23, 95);
            this.btnAdonet.Name = "btnAdonet";
            this.btnAdonet.Size = new System.Drawing.Size(208, 23);
            this.btnAdonet.TabIndex = 9;
            this.btnAdonet.Text = "Listele AdoNet";
            this.btnAdonet.UseSelectable = true;
            this.btnAdonet.Click += new System.EventHandler(this.btnAdonet_Click);
            // 
            // btnLinqToSql
            // 
            this.btnLinqToSql.Location = new System.Drawing.Point(237, 63);
            this.btnLinqToSql.Name = "btnLinqToSql";
            this.btnLinqToSql.Size = new System.Drawing.Size(208, 23);
            this.btnLinqToSql.TabIndex = 10;
            this.btnLinqToSql.Text = "Listele LinqToSql";
            this.btnLinqToSql.UseSelectable = true;
            this.btnLinqToSql.Click += new System.EventHandler(this.btnLinqToSql_Click);
            // 
            // ogrenciBindingSource1
            // 
            this.ogrenciBindingSource1.DataSource = typeof(Dapper.Model.Ogrenci);
            // 
            // btnMultipleTest
            // 
            this.btnMultipleTest.Location = new System.Drawing.Point(628, 23);
            this.btnMultipleTest.Name = "btnMultipleTest";
            this.btnMultipleTest.Size = new System.Drawing.Size(194, 23);
            this.btnMultipleTest.TabIndex = 11;
            this.btnMultipleTest.Text = "Multiple Test";
            this.btnMultipleTest.UseVisualStyleBackColor = true;
            this.btnMultipleTest.Click += new System.EventHandler(this.btnMultipleTest_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 563);
            this.Controls.Add(this.btnMultipleTest);
            this.Controls.Add(this.btnLinqToSql);
            this.Controls.Add(this.btnAdonet);
            this.Controls.Add(this.btnListeleDapper);
            this.Controls.Add(this.lblHiz);
            this.Controls.Add(this.btnListeleEF);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.txtAdSoyad);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.grid);
            this.Name = "Form1";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Öğrenci Bilgileri";
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogretmenBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroGrid grid;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtAdSoyad;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtAdres;
        private MetroFramework.Controls.MetroButton btnKaydet;
        private System.Windows.Forms.BindingSource ogrenciBindingSource;
        private MetroFramework.Controls.MetroButton btnSil;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private System.Windows.Forms.BindingSource ogretmenBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıDOGRENCIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aDSOYADDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aDRESDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource ogrenciBindingSource1;
        private MetroFramework.Controls.MetroButton btnListeleDapper;
        private MetroFramework.Controls.MetroLabel lblHiz;
        private MetroFramework.Controls.MetroButton btnListeleEF;
        private MetroFramework.Controls.MetroButton btnAdonet;
        private MetroFramework.Controls.MetroButton btnLinqToSql;
        private System.Windows.Forms.Button btnMultipleTest;
    }
}

