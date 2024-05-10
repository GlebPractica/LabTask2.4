using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task1
{
    public partial class FormReportPayments : Form
    {
        public FormReportPayments()
        {
            InitializeComponent();
        }

        private void FormReportPayments_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "gymDbDataSet.PaymentTbl". При необходимости она может быть перемещена или удалена.
            this.paymentTblTableAdapter.Fill(this.gymDbDataSet.PaymentTbl);

            this.reportViewer1.RefreshReport();
        }
    }
}
