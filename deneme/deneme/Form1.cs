using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace deneme
{
    public partial class Form1 : Form
    {
        MySqlConnection con = new MySqlConnection("server = localhost; user = root; database = insan_kaynakları; password =; ");
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Eksik Bilgi Girişi");

            }
            else if (textBox1.Text == "Admin" && textBox2.Text == "Admin")
            {

                Form2 frm = new Form2();
                frm.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Yanlış id veya şifre girdiniz");
            }
        }
    }
}
