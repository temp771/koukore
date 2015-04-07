using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using KouKore.Sources.Common.KDao;

namespace KouKore.Sources.Desktop.KForm
{
    public partial class PerformanceInputForm : Form
    {

        public PerformanceInputForm(KouKoreDataSet ds)
        {
            InitializeComponent();

            // データセット設定
            this.dsMain = ds;
            this.bsWorkType.DataSource = this.dsMain;
        }

        private void PerformanceInputForm_Load(object sender, EventArgs e)
        {
        }
    }
}
