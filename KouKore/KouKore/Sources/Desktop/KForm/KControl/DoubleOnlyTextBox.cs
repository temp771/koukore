using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KouKore.Sources.Desktop.KForm.KControl
{
    public partial class DoubleOnlyTextBox : MaskedTextBox
    {
        public DoubleOnlyTextBox()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }

        /// <summary>
        /// 入力完了時の変換処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            // double型に変換できるか確かめる
            if (!e.IsValidInput) {
                MessageBox.Show("数値を入力してください");
                e.Cancel = true;
            }    
        }
    }
}
