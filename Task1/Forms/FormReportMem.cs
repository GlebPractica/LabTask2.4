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
    public partial class FormReportMem : Form
    {
        public FormReportMem()
        {
            InitializeComponent();
            ShowReport();
        }

        private void ShowReport()
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "gymDbDataSet.MemberTbl". При необходимости она может быть перемещена или удалена.
            this.memberTblTableAdapter.Fill(this.gymDbDataSet.MemberTbl);

            this.reportViewer1.RefreshReport();

        }

        private void FormReportMem_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "gymDbDataSet.MemberTbl". При необходимости она может быть перемещена или удалена.
            this.memberTblTableAdapter.Fill(this.gymDbDataSet.MemberTbl);

        }
    }
}
