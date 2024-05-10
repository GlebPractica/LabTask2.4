using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Threading;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Runtime.Remoting.Contexts;
using System.IO;
using System.Data;
using System.Diagnostics;

namespace Task1
{
    public partial class Form1 : Form
    {
        private Thread th;

        public Form1()
        {
            InitializeComponent();
        }

        private void OpenClients()
        {
            this.Close();
            th = new Thread(Cliens);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void Cliens()
        {
            Application.Run(new Clients());
        }

        private void OpenPayments()
        {
            this.Close();
            th = new Thread(Paymens);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void Paymens()
        {
            Application.Run(new Payments());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenClients();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenPayments();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            if (!DataBaseExist())
            {
                MessageBox.Show("База данных не найдена.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(1);
            }
        }

        private bool DataBaseExist()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Task1.Properties.Settings.GymDbConnectionString"].ConnectionString))
                {
                    connection.Open();
                    return true;
                }
            }
            catch (SqlException)
            {
                return false;
            }
        }

        private void клиентыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form reportMem = new FormReportMem();
            reportMem.Show();
        }

        private void оплатаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form reportP = new FormReportPayments();
            reportP.Show();
        }
    }
}
