using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task1
{
    public partial class Clients : Form
    {
        Thread th;

        public Clients()
        {
            InitializeComponent();
        }

        private void memberTblBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.memberTblBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gymDbDataSet);
            MessageBox.Show("Успешно сохранено!", "Результат");
        }

        private void Clients_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "gymDbDataSet.MemberTbl". При необходимости она может быть перемещена или удалена.
            this.memberTblTableAdapter.Fill(this.gymDbDataSet.MemberTbl);
        }

        private void Clients_FormClosed(object sender, FormClosedEventArgs e)
        {
            OpenMenu();
        }

        private void OpenMenu()
        {
            th = new Thread(Menu);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void Menu()
        {
            Application.Run(new Form1());
        }
    }
}
