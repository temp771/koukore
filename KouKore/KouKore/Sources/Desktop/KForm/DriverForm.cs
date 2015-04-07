using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KouKore.Sources.Common.KForm;
using System.IO;

namespace KouKore.Sources.Desktop.KForm
{
    public partial class DriverForm : Form
    {

        private string xmlFilename = "XmlDocument.xml";

        public DriverForm()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            MasterForm f = new MasterForm();
            f.Show();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            PerformanceInputForm f = new PerformanceInputForm(this.dsMain);
            f.Show();
        }

        private void DriverForm_Load(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(this.xmlFilename)) {
                FileStream fs = new FileStream(this.xmlFilename, FileMode.Open);
                this.dsMain.ReadXml(fs);
                fs.Close();
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            TicketListForm f = new TicketListForm(this.dsMain);
            f.Show();
        }
    }
}
