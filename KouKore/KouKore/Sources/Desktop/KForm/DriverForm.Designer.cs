﻿namespace KouKore.Sources.Desktop.KForm
{
    partial class DriverForm
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
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.dsMain = new KouKore.Sources.Common.KDao.KouKoreDataSet();
            this.btn3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dsMain)).BeginInit();
            this.SuspendLayout();
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(12, 12);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(77, 32);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "マスタ";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(95, 12);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(77, 32);
            this.btn2.TabIndex = 1;
            this.btn2.Text = "作業工数";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // dsMain
            // 
            this.dsMain.DataSetName = "KouKoreDataSet";
            this.dsMain.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(178, 12);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(77, 32);
            this.btn3.TabIndex = 2;
            this.btn3.Text = "リスト";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // DriverForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 484);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Name = "DriverForm";
            this.Text = "DriverForm";
            this.Load += new System.EventHandler(this.DriverForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private Common.KDao.KouKoreDataSet dsMain;
        private System.Windows.Forms.Button btn3;
    }
}