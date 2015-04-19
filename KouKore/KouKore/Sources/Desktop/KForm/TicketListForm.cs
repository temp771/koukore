using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KouKore.Sources.Common.KDao;

namespace KouKore.Sources.Desktop.KForm
{
    public partial class TicketListForm : Form
    {
        public TicketListForm(KouKoreDataSet ds)
        {
            InitializeComponent();

            // データセット設定
            this.dsMain = ds;
            this.bsList.DataSource = this.dsMain;
        }

        private void dgvList_CellDoubleClick(object sender, DataGridViewCellEventArgs e) 
        {
            System.Text.StringBuilder messageBoxCS = new System.Text.StringBuilder();
            messageBoxCS.AppendFormat("{0} = {1}", "ColumnIndex", e.ColumnIndex );
            messageBoxCS.AppendLine();
            messageBoxCS.AppendFormat("{0} = {1}", "RowIndex", e.RowIndex );
            messageBoxCS.AppendLine();
            MessageBox.Show(messageBoxCS.ToString(), "CellDoubleClick Event" );
        }

        private void TicketListForm_Load(object sender, EventArgs e)
        {
            // TODO: このコード行はデータを 'dsMain.issues' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.issuesTableAdapter.Fill(this.dsMain.issues);

        }
    }
}
