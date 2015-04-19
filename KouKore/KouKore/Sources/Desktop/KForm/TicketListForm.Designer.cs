namespace KouKore.Sources.Desktop.KForm
{
    partial class TicketListForm
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
            if (disposing && (components != null)) {
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
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.bsList = new System.Windows.Forms.BindingSource(this.components);
            this.dsMain = new KouKore.Sources.Common.KDao.KouKoreDataSet();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trackeridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projectidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duedateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assignedtoidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priorityidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fixedversionidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authoridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lockversionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updatedonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doneratioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estimatedhoursDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parentidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rootidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lftDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rgtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isprivateDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.closedonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.issuesTableAdapter = new KouKore.Sources.Common.KDao.KouKoreDataSetTableAdapters.issuesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMain)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvList
            // 
            this.dgvList.AllowUserToAddRows = false;
            this.dgvList.AllowUserToDeleteRows = false;
            this.dgvList.AutoGenerateColumns = false;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.trackeridDataGridViewTextBoxColumn,
            this.projectidDataGridViewTextBoxColumn,
            this.subjectDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.duedateDataGridViewTextBoxColumn,
            this.categoryidDataGridViewTextBoxColumn,
            this.statusidDataGridViewTextBoxColumn,
            this.assignedtoidDataGridViewTextBoxColumn,
            this.priorityidDataGridViewTextBoxColumn,
            this.fixedversionidDataGridViewTextBoxColumn,
            this.authoridDataGridViewTextBoxColumn,
            this.lockversionDataGridViewTextBoxColumn,
            this.createdonDataGridViewTextBoxColumn,
            this.updatedonDataGridViewTextBoxColumn,
            this.startdateDataGridViewTextBoxColumn,
            this.doneratioDataGridViewTextBoxColumn,
            this.estimatedhoursDataGridViewTextBoxColumn,
            this.parentidDataGridViewTextBoxColumn,
            this.rootidDataGridViewTextBoxColumn,
            this.lftDataGridViewTextBoxColumn,
            this.rgtDataGridViewTextBoxColumn,
            this.isprivateDataGridViewCheckBoxColumn,
            this.closedonDataGridViewTextBoxColumn});
            this.dgvList.DataSource = this.bsList;
            this.dgvList.Location = new System.Drawing.Point(12, 209);
            this.dgvList.MultiSelect = false;
            this.dgvList.Name = "dgvList";
            this.dgvList.ReadOnly = true;
            this.dgvList.RowTemplate.Height = 21;
            this.dgvList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvList.Size = new System.Drawing.Size(1059, 389);
            this.dgvList.TabIndex = 0;
            this.dgvList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvList_CellDoubleClick);
            // 
            // bsList
            // 
            this.bsList.DataMember = "issues";
            this.bsList.DataSource = this.dsMain;
            // 
            // dsMain
            // 
            this.dsMain.DataSetName = "KouKoreDataSet";
            this.dsMain.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // trackeridDataGridViewTextBoxColumn
            // 
            this.trackeridDataGridViewTextBoxColumn.DataPropertyName = "tracker_id";
            this.trackeridDataGridViewTextBoxColumn.HeaderText = "tracker_id";
            this.trackeridDataGridViewTextBoxColumn.Name = "trackeridDataGridViewTextBoxColumn";
            this.trackeridDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // projectidDataGridViewTextBoxColumn
            // 
            this.projectidDataGridViewTextBoxColumn.DataPropertyName = "project_id";
            this.projectidDataGridViewTextBoxColumn.HeaderText = "project_id";
            this.projectidDataGridViewTextBoxColumn.Name = "projectidDataGridViewTextBoxColumn";
            this.projectidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // subjectDataGridViewTextBoxColumn
            // 
            this.subjectDataGridViewTextBoxColumn.DataPropertyName = "subject";
            this.subjectDataGridViewTextBoxColumn.HeaderText = "subject";
            this.subjectDataGridViewTextBoxColumn.Name = "subjectDataGridViewTextBoxColumn";
            this.subjectDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // duedateDataGridViewTextBoxColumn
            // 
            this.duedateDataGridViewTextBoxColumn.DataPropertyName = "due_date";
            this.duedateDataGridViewTextBoxColumn.HeaderText = "due_date";
            this.duedateDataGridViewTextBoxColumn.Name = "duedateDataGridViewTextBoxColumn";
            this.duedateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // categoryidDataGridViewTextBoxColumn
            // 
            this.categoryidDataGridViewTextBoxColumn.DataPropertyName = "category_id";
            this.categoryidDataGridViewTextBoxColumn.HeaderText = "category_id";
            this.categoryidDataGridViewTextBoxColumn.Name = "categoryidDataGridViewTextBoxColumn";
            this.categoryidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusidDataGridViewTextBoxColumn
            // 
            this.statusidDataGridViewTextBoxColumn.DataPropertyName = "status_id";
            this.statusidDataGridViewTextBoxColumn.HeaderText = "status_id";
            this.statusidDataGridViewTextBoxColumn.Name = "statusidDataGridViewTextBoxColumn";
            this.statusidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // assignedtoidDataGridViewTextBoxColumn
            // 
            this.assignedtoidDataGridViewTextBoxColumn.DataPropertyName = "assigned_to_id";
            this.assignedtoidDataGridViewTextBoxColumn.HeaderText = "assigned_to_id";
            this.assignedtoidDataGridViewTextBoxColumn.Name = "assignedtoidDataGridViewTextBoxColumn";
            this.assignedtoidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priorityidDataGridViewTextBoxColumn
            // 
            this.priorityidDataGridViewTextBoxColumn.DataPropertyName = "priority_id";
            this.priorityidDataGridViewTextBoxColumn.HeaderText = "priority_id";
            this.priorityidDataGridViewTextBoxColumn.Name = "priorityidDataGridViewTextBoxColumn";
            this.priorityidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fixedversionidDataGridViewTextBoxColumn
            // 
            this.fixedversionidDataGridViewTextBoxColumn.DataPropertyName = "fixed_version_id";
            this.fixedversionidDataGridViewTextBoxColumn.HeaderText = "fixed_version_id";
            this.fixedversionidDataGridViewTextBoxColumn.Name = "fixedversionidDataGridViewTextBoxColumn";
            this.fixedversionidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // authoridDataGridViewTextBoxColumn
            // 
            this.authoridDataGridViewTextBoxColumn.DataPropertyName = "author_id";
            this.authoridDataGridViewTextBoxColumn.HeaderText = "author_id";
            this.authoridDataGridViewTextBoxColumn.Name = "authoridDataGridViewTextBoxColumn";
            this.authoridDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lockversionDataGridViewTextBoxColumn
            // 
            this.lockversionDataGridViewTextBoxColumn.DataPropertyName = "lock_version";
            this.lockversionDataGridViewTextBoxColumn.HeaderText = "lock_version";
            this.lockversionDataGridViewTextBoxColumn.Name = "lockversionDataGridViewTextBoxColumn";
            this.lockversionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // createdonDataGridViewTextBoxColumn
            // 
            this.createdonDataGridViewTextBoxColumn.DataPropertyName = "created_on";
            this.createdonDataGridViewTextBoxColumn.HeaderText = "created_on";
            this.createdonDataGridViewTextBoxColumn.Name = "createdonDataGridViewTextBoxColumn";
            this.createdonDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // updatedonDataGridViewTextBoxColumn
            // 
            this.updatedonDataGridViewTextBoxColumn.DataPropertyName = "updated_on";
            this.updatedonDataGridViewTextBoxColumn.HeaderText = "updated_on";
            this.updatedonDataGridViewTextBoxColumn.Name = "updatedonDataGridViewTextBoxColumn";
            this.updatedonDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // startdateDataGridViewTextBoxColumn
            // 
            this.startdateDataGridViewTextBoxColumn.DataPropertyName = "start_date";
            this.startdateDataGridViewTextBoxColumn.HeaderText = "start_date";
            this.startdateDataGridViewTextBoxColumn.Name = "startdateDataGridViewTextBoxColumn";
            this.startdateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // doneratioDataGridViewTextBoxColumn
            // 
            this.doneratioDataGridViewTextBoxColumn.DataPropertyName = "done_ratio";
            this.doneratioDataGridViewTextBoxColumn.HeaderText = "done_ratio";
            this.doneratioDataGridViewTextBoxColumn.Name = "doneratioDataGridViewTextBoxColumn";
            this.doneratioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // estimatedhoursDataGridViewTextBoxColumn
            // 
            this.estimatedhoursDataGridViewTextBoxColumn.DataPropertyName = "estimated_hours";
            this.estimatedhoursDataGridViewTextBoxColumn.HeaderText = "estimated_hours";
            this.estimatedhoursDataGridViewTextBoxColumn.Name = "estimatedhoursDataGridViewTextBoxColumn";
            this.estimatedhoursDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // parentidDataGridViewTextBoxColumn
            // 
            this.parentidDataGridViewTextBoxColumn.DataPropertyName = "parent_id";
            this.parentidDataGridViewTextBoxColumn.HeaderText = "parent_id";
            this.parentidDataGridViewTextBoxColumn.Name = "parentidDataGridViewTextBoxColumn";
            this.parentidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rootidDataGridViewTextBoxColumn
            // 
            this.rootidDataGridViewTextBoxColumn.DataPropertyName = "root_id";
            this.rootidDataGridViewTextBoxColumn.HeaderText = "root_id";
            this.rootidDataGridViewTextBoxColumn.Name = "rootidDataGridViewTextBoxColumn";
            this.rootidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lftDataGridViewTextBoxColumn
            // 
            this.lftDataGridViewTextBoxColumn.DataPropertyName = "lft";
            this.lftDataGridViewTextBoxColumn.HeaderText = "lft";
            this.lftDataGridViewTextBoxColumn.Name = "lftDataGridViewTextBoxColumn";
            this.lftDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rgtDataGridViewTextBoxColumn
            // 
            this.rgtDataGridViewTextBoxColumn.DataPropertyName = "rgt";
            this.rgtDataGridViewTextBoxColumn.HeaderText = "rgt";
            this.rgtDataGridViewTextBoxColumn.Name = "rgtDataGridViewTextBoxColumn";
            this.rgtDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // isprivateDataGridViewCheckBoxColumn
            // 
            this.isprivateDataGridViewCheckBoxColumn.DataPropertyName = "is_private";
            this.isprivateDataGridViewCheckBoxColumn.HeaderText = "is_private";
            this.isprivateDataGridViewCheckBoxColumn.Name = "isprivateDataGridViewCheckBoxColumn";
            this.isprivateDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // closedonDataGridViewTextBoxColumn
            // 
            this.closedonDataGridViewTextBoxColumn.DataPropertyName = "closed_on";
            this.closedonDataGridViewTextBoxColumn.HeaderText = "closed_on";
            this.closedonDataGridViewTextBoxColumn.Name = "closedonDataGridViewTextBoxColumn";
            this.closedonDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // issuesTableAdapter
            // 
            this.issuesTableAdapter.ClearBeforeFill = true;
            // 
            // TicketListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 610);
            this.Controls.Add(this.dgvList);
            this.Name = "TicketListForm";
            this.Text = "TicketList";
            this.Load += new System.EventHandler(this.TicketListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvList;
        private Common.KDao.KouKoreDataSet dsMain;
        private System.Windows.Forms.BindingSource bsList;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trackeridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn projectidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn duedateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn assignedtoidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priorityidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fixedversionidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn authoridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lockversionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn updatedonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doneratioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estimatedhoursDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn parentidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rootidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lftDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rgtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isprivateDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn closedonDataGridViewTextBoxColumn;
        private Common.KDao.KouKoreDataSetTableAdapters.issuesTableAdapter issuesTableAdapter;
    }
}