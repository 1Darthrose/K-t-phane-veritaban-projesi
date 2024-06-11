using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kitap_evi_projesi
{
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }

        private void Form13_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı '___listboxtanvtye_DataSet3.sipariş' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.siparişTableAdapter.Fill(this.___listboxtanvtye_DataSet3.sipariş);

            this.reportViewer1.RefreshReport();
        }
    }
}
