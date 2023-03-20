
namespace Singletone_DBManager
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.бД_каталог_відеопродукціїDataSet = new Singletone_DBManager.БД_каталог_відеопродукціїDataSet();
            this.країнаВідеопродукціїBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.країна_відеопродукціїTableAdapter = new Singletone_DBManager.БД_каталог_відеопродукціїDataSetTableAdapters.Країна_відеопродукціїTableAdapter();
            this.бДкаталогвідеопродукціїDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.бД_каталог_відеопродукціїDataSet1 = new Singletone_DBManager.БД_каталог_відеопродукціїDataSet1();
            this.країнаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.країнаTableAdapter = new Singletone_DBManager.БД_каталог_відеопродукціїDataSet1TableAdapters.КраїнаTableAdapter();
            this.кодDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.назваDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.бД_каталог_відеопродукціїDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.країнаВідеопродукціїBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.бДкаталогвідеопродукціїDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.бД_каталог_відеопродукціїDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.країнаBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(435, 399);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 59);
            this.button1.TabIndex = 0;
            this.button1.Text = "Activate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодDataGridViewTextBoxColumn,
            this.назваDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.країнаBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(262, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(451, 249);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.Visible = false;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // бД_каталог_відеопродукціїDataSet
            // 
            this.бД_каталог_відеопродукціїDataSet.DataSetName = "БД_каталог_відеопродукціїDataSet";
            this.бД_каталог_відеопродукціїDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // країнаВідеопродукціїBindingSource
            // 
            this.країнаВідеопродукціїBindingSource.DataMember = "Країна відеопродукції";
            this.країнаВідеопродукціїBindingSource.DataSource = this.бД_каталог_відеопродукціїDataSet;
            // 
            // країна_відеопродукціїTableAdapter
            // 
            this.країна_відеопродукціїTableAdapter.ClearBeforeFill = true;
            // 
            // бДкаталогвідеопродукціїDataSetBindingSource
            // 
            this.бДкаталогвідеопродукціїDataSetBindingSource.DataSource = this.бД_каталог_відеопродукціїDataSet;
            this.бДкаталогвідеопродукціїDataSetBindingSource.Position = 0;
            // 
            // бД_каталог_відеопродукціїDataSet1
            // 
            this.бД_каталог_відеопродукціїDataSet1.DataSetName = "БД_каталог_відеопродукціїDataSet1";
            this.бД_каталог_відеопродукціїDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // країнаBindingSource
            // 
            this.країнаBindingSource.DataMember = "Країна";
            this.країнаBindingSource.DataSource = this.бД_каталог_відеопродукціїDataSet1;
            // 
            // країнаTableAdapter
            // 
            this.країнаTableAdapter.ClearBeforeFill = true;
            // 
            // кодDataGridViewTextBoxColumn
            // 
            this.кодDataGridViewTextBoxColumn.DataPropertyName = "Код";
            this.кодDataGridViewTextBoxColumn.HeaderText = "Код";
            this.кодDataGridViewTextBoxColumn.Name = "кодDataGridViewTextBoxColumn";
            // 
            // назваDataGridViewTextBoxColumn
            // 
            this.назваDataGridViewTextBoxColumn.DataPropertyName = "Назва";
            this.назваDataGridViewTextBoxColumn.HeaderText = "Назва";
            this.назваDataGridViewTextBoxColumn.Name = "назваDataGridViewTextBoxColumn";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(606, 399);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 59);
            this.button2.TabIndex = 2;
            this.button2.Text = "OpenAnotherForm";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 607);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.бД_каталог_відеопродукціїDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.країнаВідеопродукціїBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.бДкаталогвідеопродукціїDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.бД_каталог_відеопродукціїDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.країнаBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private БД_каталог_відеопродукціїDataSet бД_каталог_відеопродукціїDataSet;
        private System.Windows.Forms.BindingSource країнаВідеопродукціїBindingSource;
        private БД_каталог_відеопродукціїDataSetTableAdapters.Країна_відеопродукціїTableAdapter країна_відеопродукціїTableAdapter;
        private System.Windows.Forms.BindingSource бДкаталогвідеопродукціїDataSetBindingSource;
        private БД_каталог_відеопродукціїDataSet1 бД_каталог_відеопродукціїDataSet1;
        private System.Windows.Forms.BindingSource країнаBindingSource;
        private БД_каталог_відеопродукціїDataSet1TableAdapters.КраїнаTableAdapter країнаTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn назваDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button2;
    }
}

