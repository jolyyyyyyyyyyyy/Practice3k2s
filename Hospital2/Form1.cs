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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (logTxt.Text == "Admin" && passTxt.Text == "1234")
            {
                Admin newForm = new Admin();
                newForm.Show();
                this.Hide();
                MessageBox.Show("Вход произведен");
            }
            else if (logTxt.Text == "Doctor" && passTxt.Text == "1234")
            {
                Doctor newForm = new Doctor();
                newForm.Show();
                this.Hide();
                MessageBox.Show("Вход произведен");
            }
            else if (logTxt.Text == "Nurse" && passTxt.Text == "1234")
            {
                Nurse newForm = new Nurse();
                newForm.Show();
                this.Hide();
                MessageBox.Show("Вход произведен");
            }
        }
    }
}
