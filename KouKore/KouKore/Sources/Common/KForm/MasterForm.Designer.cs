namespace KouKore.Sources.Common.KForm
{
    partial class MasterForm
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
            this.lblTableName = new System.Windows.Forms.Label();
            this.dgvMain = new System.Windows.Forms.DataGridView();
            this.cmbSelectTable = new System.Windows.Forms.ComboBox();
            this.btnAddRow = new System.Windows.Forms.Button();
            this.btnRegist = new System.Windows.Forms.Button();
            this.dsMaster = new KouKore.Sources.Common.KDao.KouKoreDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMaster)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTableName
            // 
            this.lblTableName.AutoSize = true;
            this.lblTableName.Location = new System.Drawing.Point(12, 47);
            this.lblTableName.Name = "lblTableName";
            this.lblTableName.Size = new System.Drawing.Size(55, 12);
            this.lblTableName.TabIndex = 0;
            this.lblTableName.Text = "テーブル名";
            // 
            // dgvMain
            // 
            this.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMain.Location = new System.Drawing.Point(14, 62);
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.RowTemplate.Height = 21;
            this.dgvMain.Size = new System.Drawing.Size(852, 454);
            this.dgvMain.TabIndex = 2;
            // 
            // cmbSelectTable
            // 
            this.cmbSelectTable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSelectTable.FormattingEnabled = true;
            this.cmbSelectTable.Location = new System.Drawing.Point(12, 12);
            this.cmbSelectTable.Name = "cmbSelectTable";
            this.cmbSelectTable.Size = new System.Drawing.Size(396, 20);
            this.cmbSelectTable.TabIndex = 1;
            this.cmbSelectTable.SelectedIndexChanged += new System.EventHandler(this.cmbSelectTable_SelectedIndexChanged);
            // 
            // btnAddRow
            // 
            this.btnAddRow.Location = new System.Drawing.Point(641, 21);
            this.btnAddRow.Name = "btnAddRow";
            this.btnAddRow.Size = new System.Drawing.Size(81, 21);
            this.btnAddRow.TabIndex = 3;
            this.btnAddRow.Text = "行追加";
            this.btnAddRow.UseVisualStyleBackColor = true;
            // 
            // btnRegist
            // 
            this.btnRegist.Location = new System.Drawing.Point(785, 21);
            this.btnRegist.Name = "btnRegist";
            this.btnRegist.Size = new System.Drawing.Size(81, 21);
            this.btnRegist.TabIndex = 4;
            this.btnRegist.Text = "更新";
            this.btnRegist.UseVisualStyleBackColor = true;
            this.btnRegist.Click += new System.EventHandler(this.btnRegist_Click);
            // 
            // dsMaster
            // 
            this.dsMaster.DataSetName = "dsMaster";
            this.dsMaster.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // MasterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 528);
            this.Controls.Add(this.btnRegist);
            this.Controls.Add(this.btnAddRow);
            this.Controls.Add(this.dgvMain);
            this.Controls.Add(this.cmbSelectTable);
            this.Controls.Add(this.lblTableName);
            this.Name = "MasterForm";
            this.Text = "MasterForm";
            this.Load += new System.EventHandler(this.MasterForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMaster)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private KDao.KouKoreDataSet dsMaster;
        private System.Windows.Forms.Label lblTableName;
        private System.Windows.Forms.ComboBox cmbSelectTable;
        private System.Windows.Forms.DataGridView dgvMain;
        private System.Windows.Forms.Button btnAddRow;
        private System.Windows.Forms.Button btnRegist;
    }
}