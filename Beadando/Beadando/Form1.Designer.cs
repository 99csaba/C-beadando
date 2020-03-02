namespace Beadando
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
            this.addnew = new System.Windows.Forms.Button();
            this.album_cb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.searc = new System.Windows.Forms.TextBox();
            this.kepek = new System.Windows.Forms.PictureBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.datas = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lenghtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.albumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urlDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tracksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.musicDataSet = new Beadando.musicDataSet();
            this.tracksTableAdapter = new Beadando.musicDataSetTableAdapters.TracksTableAdapter();
            this.eloadok_cb = new System.Windows.Forms.ComboBox();
            this.albumBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.musicDataSet1 = new Beadando.musicDataSet1();
            this.albumTableAdapter = new Beadando.musicDataSet1TableAdapters.AlbumTableAdapter();
            this.eloadoToolStrip = new System.Windows.Forms.ToolStrip();
            this.eloadoToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.musicDataSet2 = new Beadando.musicDataSet2();
            this.albumBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.albumTableAdapter1 = new Beadando.musicDataSet2TableAdapters.AlbumTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.addurl = new System.Windows.Forms.Button();
            this.edit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.kepek)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tracksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musicDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musicDataSet1)).BeginInit();
            this.eloadoToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.musicDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // addnew
            // 
            this.addnew.Location = new System.Drawing.Point(366, 364);
            this.addnew.Name = "addnew";
            this.addnew.Size = new System.Drawing.Size(122, 63);
            this.addnew.TabIndex = 0;
            this.addnew.Text = "Add discography";
            this.addnew.UseVisualStyleBackColor = true;
            // 
            // album_cb
            // 
            this.album_cb.DataSource = this.albumBindingSource1;
            this.album_cb.Enabled = false;
            this.album_cb.FormattingEnabled = true;
            this.album_cb.Location = new System.Drawing.Point(193, 58);
            this.album_cb.Name = "album_cb";
            this.album_cb.Size = new System.Drawing.Size(157, 21);
            this.album_cb.TabIndex = 2;
            this.album_cb.ValueMember = "title";
            this.album_cb.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(363, 315);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "URL (if any):";
            // 
            // searc
            // 
            this.searc.Location = new System.Drawing.Point(27, 99);
            this.searc.Name = "searc";
            this.searc.Size = new System.Drawing.Size(323, 20);
            this.searc.TabIndex = 4;
            this.searc.TextChanged += new System.EventHandler(this.searc_TextChanged);
            // 
            // kepek
            // 
            this.kepek.Image = global::Beadando.Properties.Resources.at;
            this.kepek.Location = new System.Drawing.Point(366, 157);
            this.kepek.Name = "kepek";
            this.kepek.Size = new System.Drawing.Size(122, 107);
            this.kepek.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.kepek.TabIndex = 5;
            this.kepek.TabStop = false;
            this.kepek.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(521, 157);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(267, 107);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "";
            // 
            // datas
            // 
            this.datas.AutoGenerateColumns = false;
            this.datas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.lenghtDataGridViewTextBoxColumn,
            this.albumDataGridViewTextBoxColumn,
            this.urlDataGridViewTextBoxColumn});
            this.datas.DataSource = this.tracksBindingSource;
            this.datas.Location = new System.Drawing.Point(27, 155);
            this.datas.Name = "datas";
            this.datas.Size = new System.Drawing.Size(323, 283);
            this.datas.TabIndex = 7;
            this.datas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            // 
            // lenghtDataGridViewTextBoxColumn
            // 
            this.lenghtDataGridViewTextBoxColumn.DataPropertyName = "lenght";
            this.lenghtDataGridViewTextBoxColumn.HeaderText = "lenght";
            this.lenghtDataGridViewTextBoxColumn.Name = "lenghtDataGridViewTextBoxColumn";
            // 
            // albumDataGridViewTextBoxColumn
            // 
            this.albumDataGridViewTextBoxColumn.DataPropertyName = "album";
            this.albumDataGridViewTextBoxColumn.HeaderText = "album";
            this.albumDataGridViewTextBoxColumn.Name = "albumDataGridViewTextBoxColumn";
            // 
            // urlDataGridViewTextBoxColumn
            // 
            this.urlDataGridViewTextBoxColumn.DataPropertyName = "url";
            this.urlDataGridViewTextBoxColumn.HeaderText = "url";
            this.urlDataGridViewTextBoxColumn.Name = "urlDataGridViewTextBoxColumn";
            // 
            // tracksBindingSource
            // 
            this.tracksBindingSource.DataMember = "Tracks";
            this.tracksBindingSource.DataSource = this.musicDataSet;
            // 
            // musicDataSet
            // 
            this.musicDataSet.DataSetName = "musicDataSet";
            this.musicDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tracksTableAdapter
            // 
            this.tracksTableAdapter.ClearBeforeFill = true;
            // 
            // eloadok_cb
            // 
            this.eloadok_cb.DataSource = this.albumBindingSource;
            this.eloadok_cb.FormattingEnabled = true;
            this.eloadok_cb.Location = new System.Drawing.Point(27, 58);
            this.eloadok_cb.Name = "eloadok_cb";
            this.eloadok_cb.Size = new System.Drawing.Size(160, 21);
            this.eloadok_cb.TabIndex = 8;
            this.eloadok_cb.ValueMember = "artist";
            this.eloadok_cb.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // albumBindingSource
            // 
            this.albumBindingSource.DataMember = "Album";
            this.albumBindingSource.DataSource = this.musicDataSet1;
            // 
            // musicDataSet1
            // 
            this.musicDataSet1.DataSetName = "musicDataSet1";
            this.musicDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // albumTableAdapter
            // 
            this.albumTableAdapter.ClearBeforeFill = true;
            // 
            // eloadoToolStrip
            // 
            this.eloadoToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.eloadoToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.eloadoToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eloadoToolStripButton});
            this.eloadoToolStrip.Location = new System.Drawing.Point(0, 0);
            this.eloadoToolStrip.Name = "eloadoToolStrip";
            this.eloadoToolStrip.Size = new System.Drawing.Size(50, 25);
            this.eloadoToolStrip.TabIndex = 9;
            this.eloadoToolStrip.Text = "eloadoToolStrip";
            // 
            // eloadoToolStripButton
            // 
            this.eloadoToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.eloadoToolStripButton.Name = "eloadoToolStripButton";
            this.eloadoToolStripButton.Size = new System.Drawing.Size(47, 22);
            this.eloadoToolStripButton.Text = "eloado";
            this.eloadoToolStripButton.Click += new System.EventHandler(this.eloadoToolStripButton_Click_1);
            // 
            // musicDataSet2
            // 
            this.musicDataSet2.DataSetName = "musicDataSet2";
            this.musicDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // albumBindingSource1
            // 
            this.albumBindingSource1.DataMember = "Album";
            this.albumBindingSource1.DataSource = this.musicDataSet2;
            // 
            // albumTableAdapter1
            // 
            this.albumTableAdapter1.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Artist";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(217, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Albums";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Searc in track\'s title";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(490, 315);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(55, 13);
            this.linkLabel1.TabIndex = 13;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "linkLabel1";
            // 
            // addurl
            // 
            this.addurl.Location = new System.Drawing.Point(521, 364);
            this.addurl.Name = "addurl";
            this.addurl.Size = new System.Drawing.Size(115, 63);
            this.addurl.TabIndex = 14;
            this.addurl.Text = "Add url";
            this.addurl.UseVisualStyleBackColor = true;
            // 
            // edit
            // 
            this.edit.Location = new System.Drawing.Point(671, 364);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(117, 63);
            this.edit.TabIndex = 15;
            this.edit.Text = "Edit selecterd";
            this.edit.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 458);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.addurl);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.eloadoToolStrip);
            this.Controls.Add(this.eloadok_cb);
            this.Controls.Add(this.datas);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.kepek);
            this.Controls.Add(this.searc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.album_cb);
            this.Controls.Add(this.addnew);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kepek)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tracksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musicDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musicDataSet1)).EndInit();
            this.eloadoToolStrip.ResumeLayout(false);
            this.eloadoToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.musicDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addnew;
        private System.Windows.Forms.ComboBox album_cb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searc;
        private System.Windows.Forms.PictureBox kepek;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.DataGridView datas;
        private musicDataSet musicDataSet;
        private System.Windows.Forms.BindingSource tracksBindingSource;
        private musicDataSetTableAdapters.TracksTableAdapter tracksTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lenghtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn albumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urlDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox eloadok_cb;
        private musicDataSet1 musicDataSet1;
        private System.Windows.Forms.BindingSource albumBindingSource;
        private musicDataSet1TableAdapters.AlbumTableAdapter albumTableAdapter;
        private System.Windows.Forms.ToolStrip eloadoToolStrip;
        private System.Windows.Forms.ToolStripButton eloadoToolStripButton;
        private musicDataSet2 musicDataSet2;
        private System.Windows.Forms.BindingSource albumBindingSource1;
        private musicDataSet2TableAdapters.AlbumTableAdapter albumTableAdapter1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button addurl;
        private System.Windows.Forms.Button edit;
    }
}

