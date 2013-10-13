namespace WindowsFormsApplication4
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
            this.add = new System.Windows.Forms.Button();
            this.remove = new System.Windows.Forms.Button();
            this.toDoListDataSet = new WindowsFormsApplication4.ToDoListDataSet();
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableTableAdapter = new WindowsFormsApplication4.ToDoListDataSetTableAdapters.TableTableAdapter();
            this.toDoListDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workAssignedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkassignmentofworksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nkman_todo_dbDataSet = new WindowsFormsApplication4.nkman_todo_dbDataSet();
            this.check_assignment_of_worksTableAdapter = new WindowsFormsApplication4.nkman_todo_dbDataSetTableAdapters.check_assignment_of_worksTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.toDoListDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toDoListDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkassignmentofworksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nkman_todo_dbDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(26, 26);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(154, 23);
            this.add.TabIndex = 0;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // remove
            // 
            this.remove.Location = new System.Drawing.Point(203, 26);
            this.remove.Name = "remove";
            this.remove.Size = new System.Drawing.Size(169, 23);
            this.remove.TabIndex = 1;
            this.remove.Text = "Modify";
            this.remove.UseVisualStyleBackColor = true;
            this.remove.Click += new System.EventHandler(this.remove_Click);
            // 
            // toDoListDataSet
            // 
            this.toDoListDataSet.DataSetName = "ToDoListDataSet";
            this.toDoListDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableBindingSource
            // 
            this.tableBindingSource.DataMember = "Table";
            this.tableBindingSource.DataSource = this.toDoListDataSet;
            // 
            // tableTableAdapter
            // 
            this.tableTableAdapter.ClearBeforeFill = true;
            // 
            // toDoListDataSetBindingSource
            // 
            this.toDoListDataSetBindingSource.DataSource = this.toDoListDataSet;
            this.toDoListDataSetBindingSource.Position = 0;
            // 
            // tableBindingSource1
            // 
            this.tableBindingSource1.DataMember = "Table";
            this.tableBindingSource1.DataSource = this.toDoListDataSetBindingSource;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.workAssignedDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.checkassignmentofworksBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(26, 70);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(346, 290);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // workAssignedDataGridViewTextBoxColumn
            // 
            this.workAssignedDataGridViewTextBoxColumn.DataPropertyName = "Work_Assigned";
            this.workAssignedDataGridViewTextBoxColumn.HeaderText = "Work_Assigned";
            this.workAssignedDataGridViewTextBoxColumn.Name = "workAssignedDataGridViewTextBoxColumn";
            this.workAssignedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // checkassignmentofworksBindingSource
            // 
            this.checkassignmentofworksBindingSource.DataMember = "check_assignment_of_works";
            this.checkassignmentofworksBindingSource.DataSource = this.nkman_todo_dbDataSet;
            // 
            // nkman_todo_dbDataSet
            // 
            this.nkman_todo_dbDataSet.DataSetName = "nkman_todo_dbDataSet";
            this.nkman_todo_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // check_assignment_of_worksTableAdapter
            // 
            this.check_assignment_of_worksTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 372);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.remove);
            this.Controls.Add(this.add);
            this.Name = "Form1";
            this.Text = "To Do List Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.toDoListDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toDoListDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkassignmentofworksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nkman_todo_dbDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button remove;
        private ToDoListDataSet toDoListDataSet;
        private System.Windows.Forms.BindingSource tableBindingSource;
        private ToDoListDataSetTableAdapters.TableTableAdapter tableTableAdapter;
        private System.Windows.Forms.BindingSource toDoListDataSetBindingSource;
        private System.Windows.Forms.BindingSource tableBindingSource1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private nkman_todo_dbDataSet nkman_todo_dbDataSet;
        private System.Windows.Forms.BindingSource checkassignmentofworksBindingSource;
        private nkman_todo_dbDataSetTableAdapters.check_assignment_of_worksTableAdapter check_assignment_of_worksTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn workAssignedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
    }
}

