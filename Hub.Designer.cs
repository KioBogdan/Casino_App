namespace Atestat
{
    partial class Hub
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hub));
            this.conturiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jucătoriDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jucătoriDataSet = new Atestat.JucătoriDataSet();
            this.conturiDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conturiBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.jucătoriDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.conturiTableAdapter = new Atestat.JucătoriDataSetTableAdapters.ConturiTableAdapter();
            this.tableAdapterManager = new Atestat.JucătoriDataSetTableAdapters.TableAdapterManager();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Inregistrari = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parolaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.baniDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.avatarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inregistrariBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jucatoriDataSet3 = new Atestat.JucatoriDataSet3();
            this.inregistrariTableAdapter = new Atestat.JucatoriDataSet3TableAdapters.InregistrariTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.conturiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jucătoriDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jucătoriDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.conturiDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.conturiBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jucătoriDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Inregistrari)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inregistrariBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jucatoriDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // conturiBindingSource
            // 
            this.conturiBindingSource.DataMember = "Conturi";
            this.conturiBindingSource.DataSource = this.jucătoriDataSetBindingSource;
            // 
            // jucătoriDataSetBindingSource
            // 
            this.jucătoriDataSetBindingSource.DataSource = this.jucătoriDataSet;
            this.jucătoriDataSetBindingSource.Position = 0;
            // 
            // jucătoriDataSet
            // 
            this.jucătoriDataSet.DataSetName = "JucătoriDataSet";
            this.jucătoriDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // conturiDataGridView
            // 
            this.conturiDataGridView.AutoGenerateColumns = false;
            this.conturiDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.conturiDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.conturiDataGridView.DataSource = this.conturiBindingSource1;
            this.conturiDataGridView.Location = new System.Drawing.Point(-6, 543);
            this.conturiDataGridView.Name = "conturiDataGridView";
            this.conturiDataGridView.Size = new System.Drawing.Size(10, 10);
            this.conturiDataGridView.TabIndex = 9;
            this.conturiDataGridView.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nume";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nume";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Vârstă";
            this.dataGridViewTextBoxColumn3.HeaderText = "Vârstă";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Parolă";
            this.dataGridViewTextBoxColumn4.HeaderText = "Parolă";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Bani";
            this.dataGridViewTextBoxColumn5.HeaderText = "Bani";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // conturiBindingSource1
            // 
            this.conturiBindingSource1.DataMember = "Conturi";
            this.conturiBindingSource1.DataSource = this.jucătoriDataSet;
            // 
            // jucătoriDataSetBindingSource1
            // 
            this.jucătoriDataSetBindingSource1.DataSource = this.jucătoriDataSet;
            this.jucătoriDataSetBindingSource1.Position = 0;
            // 
            // conturiTableAdapter
            // 
            this.conturiTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClasamentTableAdapter = null;
            this.tableAdapterManager.ConturiTableAdapter = this.conturiTableAdapter;
            this.tableAdapterManager.JocuriTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Atestat.JucătoriDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(95, 144);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(153, 65);
            this.button2.TabIndex = 14;
            this.button2.Text = "REGISTER";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(95, 56);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 65);
            this.button1.TabIndex = 15;
            this.button1.Text = "LOGIN";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Inregistrari
            // 
            this.Inregistrari.AutoGenerateColumns = false;
            this.Inregistrari.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Inregistrari.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.adresaDataGridViewTextBoxColumn,
            this.parolaDataGridViewTextBoxColumn,
            this.baniDataGridViewTextBoxColumn,
            this.avatarDataGridViewTextBoxColumn});
            this.Inregistrari.DataSource = this.inregistrariBindingSource;
            this.Inregistrari.Location = new System.Drawing.Point(291, 303);
            this.Inregistrari.Name = "Inregistrari";
            this.Inregistrari.Size = new System.Drawing.Size(36, 31);
            this.Inregistrari.TabIndex = 17;
            this.Inregistrari.Visible = false;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // adresaDataGridViewTextBoxColumn
            // 
            this.adresaDataGridViewTextBoxColumn.DataPropertyName = "Adresa";
            this.adresaDataGridViewTextBoxColumn.HeaderText = "Adresa";
            this.adresaDataGridViewTextBoxColumn.Name = "adresaDataGridViewTextBoxColumn";
            // 
            // parolaDataGridViewTextBoxColumn
            // 
            this.parolaDataGridViewTextBoxColumn.DataPropertyName = "Parola";
            this.parolaDataGridViewTextBoxColumn.HeaderText = "Parola";
            this.parolaDataGridViewTextBoxColumn.Name = "parolaDataGridViewTextBoxColumn";
            // 
            // baniDataGridViewTextBoxColumn
            // 
            this.baniDataGridViewTextBoxColumn.DataPropertyName = "Bani";
            this.baniDataGridViewTextBoxColumn.HeaderText = "Bani";
            this.baniDataGridViewTextBoxColumn.Name = "baniDataGridViewTextBoxColumn";
            // 
            // avatarDataGridViewTextBoxColumn
            // 
            this.avatarDataGridViewTextBoxColumn.DataPropertyName = "Avatar";
            this.avatarDataGridViewTextBoxColumn.HeaderText = "Avatar";
            this.avatarDataGridViewTextBoxColumn.Name = "avatarDataGridViewTextBoxColumn";
            // 
            // inregistrariBindingSource
            // 
            this.inregistrariBindingSource.DataMember = "Inregistrari";
            this.inregistrariBindingSource.DataSource = this.jucatoriDataSet3;
            // 
            // jucatoriDataSet3
            // 
            this.jucatoriDataSet3.DataSetName = "JucatoriDataSet3";
            this.jucatoriDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // inregistrariTableAdapter
            // 
            this.inregistrariTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(254, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 60);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(29, -2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(60, 60);
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(254, 212);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(60, 60);
            this.pictureBox3.TabIndex = 20;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(29, 212);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(60, 60);
            this.pictureBox4.TabIndex = 21;
            this.pictureBox4.TabStop = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(134, 232);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 22;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // Hub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(325, 278);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Inregistrari);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.conturiDataGridView);
            this.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Hub";
            this.Text = "Hub";
            this.Load += new System.EventHandler(this.Hub_Load);
            ((System.ComponentModel.ISupportInitialize)(this.conturiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jucătoriDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jucătoriDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.conturiDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.conturiBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jucătoriDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Inregistrari)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inregistrariBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jucatoriDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridView conturiDataGridView;
        private System.Windows.Forms.BindingSource jucătoriDataSetBindingSource;
        private JucătoriDataSet jucătoriDataSet;
        private System.Windows.Forms.BindingSource jucătoriDataSetBindingSource1;
        private System.Windows.Forms.BindingSource conturiBindingSource;
        private JucătoriDataSetTableAdapters.ConturiTableAdapter conturiTableAdapter;
        private System.Windows.Forms.BindingSource conturiBindingSource1;
        private JucătoriDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView Inregistrari;
        private JucatoriDataSet3 jucatoriDataSet3;
        private System.Windows.Forms.BindingSource inregistrariBindingSource;
        private JucatoriDataSet3TableAdapters.InregistrariTableAdapter inregistrariTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn parolaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn baniDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn avatarDataGridViewTextBoxColumn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button button3;
    }
}

