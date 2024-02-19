using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Employee_Management_system
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-FCFL24RH\SQLEXPRESS;Initial Catalog=EmployeeWF;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("DELETE Employee_Table WHERE Employee_Id = '"+textBox1.Text+"'",con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("deleted data successfully");
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Employee_Table VALUES('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','"+comboBox1.Text+"')",con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("INserted data successfully");
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = "";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE Employee_Table SET Employee_Name='"+textBox2.Text+"',Address = '"+textBox3.Text+"',Salary = '"+textBox4.Text+"' WHERE Employee_Id = '"+textBox1.Text+"'",con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("updated data successfully");
            con.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = "";
        }
    }
}
