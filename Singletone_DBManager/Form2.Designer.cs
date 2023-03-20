
namespace Singletone_DBManager
{
    partial class Form2
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
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.бД_каталог_відеопродукціїDataSet1 = new Singletone_DBManager.БД_каталог_відеопродукціїDataSet1();
            this.бДкаталогвідеопродукціїDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.бД_каталог_відеопродукціїDataSet = new Singletone_DBManager.БД_каталог_відеопродукціїDataSet();
            this.бДкаталогвідеопродукціїDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.бДкаталогвідеопродукціїDataSet1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.бД_каталог_відеопродукціїDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.бДкаталогвідеопродукціїDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.бД_каталог_відеопродукціїDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.бДкаталогвідеопродукціїDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.бДкаталогвідеопродукціїDataSet1BindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(427, 447);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 62);
            this.button1.TabIndex = 0;
            this.button1.Text = "Activate second table";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(260, 59);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(429, 301);
            this.dataGridView1.TabIndex = 1;
            // 
            // бД_каталог_відеопродукціїDataSet1
            // 
            this.бД_каталог_відеопродукціїDataSet1.DataSetName = "БД_каталог_відеопродукціїDataSet1";
            this.бД_каталог_відеопродукціїDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // бДкаталогвідеопродукціїDataSet1BindingSource
            // 
            this.бДкаталогвідеопродукціїDataSet1BindingSource.DataSource = this.бД_каталог_відеопродукціїDataSet1;
            this.бДкаталогвідеопродукціїDataSet1BindingSource.Position = 0;
            // 
            // бД_каталог_відеопродукціїDataSet
            // 
            this.бД_каталог_відеопродукціїDataSet.DataSetName = "БД_каталог_відеопродукціїDataSet";
            this.бД_каталог_відеопродукціїDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // бДкаталогвідеопродукціїDataSetBindingSource
            // 
            this.бДкаталогвідеопродукціїDataSetBindingSource.DataSource = this.бД_каталог_відеопродукціїDataSet;
            this.бДкаталогвідеопродукціїDataSetBindingSource.Position = 0;
            // 
            // бДкаталогвідеопродукціїDataSet1BindingSource1
            // 
            this.бДкаталогвідеопродукціїDataSet1BindingSource1.DataSource = this.бД_каталог_відеопродукціїDataSet1;
            this.бДкаталогвідеопродукціїDataSet1BindingSource1.Position = 0;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 595);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.бД_каталог_відеопродукціїDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.бДкаталогвідеопродукціїDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.бД_каталог_відеопродукціїDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.бДкаталогвідеопродукціїDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.бДкаталогвідеопродукціїDataSet1BindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource бДкаталогвідеопродукціїDataSet1BindingSource;
        private БД_каталог_відеопродукціїDataSet1 бД_каталог_відеопродукціїDataSet1;
        private System.Windows.Forms.BindingSource бДкаталогвідеопродукціїDataSet1BindingSource1;
        private БД_каталог_відеопродукціїDataSet бД_каталог_відеопродукціїDataSet;
        private System.Windows.Forms.BindingSource бДкаталогвідеопродукціїDataSetBindingSource;
    }
}