using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital2
{
    public partial class AddAppointment : Form
    {
        public AddAppointment()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    // Создаем новый экземпляр TableAdapter
            //    HospitalDBDataSetTableAdapters.PatientsTableAdapter adapter =
            //        new HospitalDBDataSetTableAdapters.PatientsTableAdapter();

            //    // Используем метод TableAdapter для добавления новой записи
            //    adapter.Insert(textBox1.Text, textBox2.Text, textBox3.Text);

            //    MessageBox.Show("Patient information saved successfully.");
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error occurred: " + ex.Message);
            //}

            textBox3.Clear();
            MessageBox.Show("Новая запись добавлена");
            Appointments menu = new Appointments();
            menu.Show();
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddAppointment_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hospitalDBDataSet.Doctors". При необходимости она может быть перемещена или удалена.
            this.doctorsTableAdapter.Fill(this.hospitalDBDataSet.Doctors);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hospitalDBDataSet.Patients". При необходимости она может быть перемещена или удалена.
            this.patientsTableAdapter.Fill(this.hospitalDBDataSet.Patients);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
