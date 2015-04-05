namespace KouKore.Sources.Desktop.KForm
{
    partial class PerformanceInputForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbWorkType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.btnRegist = new System.Windows.Forms.Button();
            this.dotPerformTime = new KouKore.Sources.Desktop.KForm.KControl.DoubleOnlyTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "実績工数";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(133, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "作業内容";
            // 
            // cmbWorkType
            // 
            this.cmbWorkType.FormattingEnabled = true;
            this.cmbWorkType.Location = new System.Drawing.Point(192, 5);
            this.cmbWorkType.Name = "cmbWorkType";
            this.cmbWorkType.Size = new System.Drawing.Size(97, 20);
            this.cmbWorkType.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "実績工数";
            // 
            // txtComment
            // 
            this.txtComment.Location = new System.Drawing.Point(71, 31);
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(411, 19);
            this.txtComment.TabIndex = 3;
            // 
            // btnRegist
            // 
            this.btnRegist.Location = new System.Drawing.Point(421, 4);
            this.btnRegist.Name = "btnRegist";
            this.btnRegist.Size = new System.Drawing.Size(61, 21);
            this.btnRegist.TabIndex = 4;
            this.btnRegist.Text = "登録";
            this.btnRegist.UseVisualStyleBackColor = true;
            // 
            // dotPerformTime
            // 
            this.dotPerformTime.Location = new System.Drawing.Point(71, 6);
            this.dotPerformTime.Mask = "##.##";
            this.dotPerformTime.Name = "dotPerformTime";
            this.dotPerformTime.Size = new System.Drawing.Size(39, 19);
            this.dotPerformTime.TabIndex = 1;
            // 
            // PerformanceInputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 59);
            this.Controls.Add(this.btnRegist);
            this.Controls.Add(this.txtComment);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbWorkType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dotPerformTime);
            this.Controls.Add(this.label1);
            this.Name = "PerformanceInputForm";
            this.Text = "実績入力";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private KControl.DoubleOnlyTextBox dotPerformTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbWorkType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.Button btnRegist;

    }
}