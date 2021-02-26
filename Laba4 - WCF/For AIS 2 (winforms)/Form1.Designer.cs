namespace For_AIS_2__winforms_
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ButSearch = new System.Windows.Forms.Button();
            this.ButDelete = new System.Windows.Forms.Button();
            this.ButEdit = new System.Windows.Forms.Button();
            this.ButAdd = new System.Windows.Forms.Button();
            this.ButShowXML = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Namee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.group = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.task_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.ButSearch, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.ButDelete, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.ButEdit, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.ButAdd, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.ButShowXML, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(749, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // ButSearch
            // 
            this.ButSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButSearch.Location = new System.Drawing.Point(450, 408);
            this.ButSearch.Name = "ButSearch";
            this.ButSearch.Size = new System.Drawing.Size(143, 39);
            this.ButSearch.TabIndex = 4;
            this.ButSearch.Text = "Search";
            this.ButSearch.UseVisualStyleBackColor = true;
            this.ButSearch.Click += new System.EventHandler(this.ButSearch_Click);
            // 
            // ButDelete
            // 
            this.ButDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButDelete.Enabled = false;
            this.ButDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButDelete.Location = new System.Drawing.Point(301, 408);
            this.ButDelete.Name = "ButDelete";
            this.ButDelete.Size = new System.Drawing.Size(143, 39);
            this.ButDelete.TabIndex = 3;
            this.ButDelete.Text = "Delete";
            this.ButDelete.UseVisualStyleBackColor = true;
            this.ButDelete.Click += new System.EventHandler(this.ButDelete_Click);
            // 
            // ButEdit
            // 
            this.ButEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButEdit.Enabled = false;
            this.ButEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButEdit.Location = new System.Drawing.Point(152, 408);
            this.ButEdit.Name = "ButEdit";
            this.ButEdit.Size = new System.Drawing.Size(143, 39);
            this.ButEdit.TabIndex = 2;
            this.ButEdit.Text = "Edit";
            this.ButEdit.UseVisualStyleBackColor = true;
            this.ButEdit.Click += new System.EventHandler(this.ButEdit_Click);
            // 
            // ButAdd
            // 
            this.ButAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButAdd.Location = new System.Drawing.Point(3, 408);
            this.ButAdd.Name = "ButAdd";
            this.ButAdd.Size = new System.Drawing.Size(143, 39);
            this.ButAdd.TabIndex = 1;
            this.ButAdd.Text = "Add";
            this.ButAdd.UseVisualStyleBackColor = true;
            this.ButAdd.Click += new System.EventHandler(this.ButAdd_Click);
            // 
            // ButShowXML
            // 
            this.ButShowXML.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButShowXML.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButShowXML.Location = new System.Drawing.Point(599, 408);
            this.ButShowXML.Name = "ButShowXML";
            this.ButShowXML.Size = new System.Drawing.Size(147, 39);
            this.ButShowXML.TabIndex = 5;
            this.ButShowXML.Text = "ShowXML";
            this.ButShowXML.UseVisualStyleBackColor = true;
            this.ButShowXML.Click += new System.EventHandler(this.ButShowXML_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Namee,
            this.surname,
            this.group,
            this.task_name,
            this.subject,
            this.discription});
            this.tableLayoutPanel1.SetColumnSpan(this.dataGridView1, 5);
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(743, 399);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // Namee
            // 
            this.Namee.HeaderText = "name";
            this.Namee.Name = "Namee";
            // 
            // surname
            // 
            this.surname.HeaderText = "surname";
            this.surname.Name = "surname";
            // 
            // group
            // 
            this.group.HeaderText = "group";
            this.group.Name = "group";
            // 
            // task_name
            // 
            this.task_name.HeaderText = "task_name";
            this.task_name.Name = "task_name";
            // 
            // subject
            // 
            this.subject.HeaderText = "subject";
            this.subject.Name = "subject";
            // 
            // discription
            // 
            this.discription.HeaderText = "discription";
            this.discription.Name = "discription";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "List of Instituts";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button ButSearch;
        private System.Windows.Forms.Button ButDelete;
        private System.Windows.Forms.Button ButEdit;
        private System.Windows.Forms.Button ButAdd;
        private System.Windows.Forms.Button ButShowXML;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Namee;
        private System.Windows.Forms.DataGridViewTextBoxColumn surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn group;
        private System.Windows.Forms.DataGridViewTextBoxColumn task_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn subject;
        private System.Windows.Forms.DataGridViewTextBoxColumn discription;
    }
}

