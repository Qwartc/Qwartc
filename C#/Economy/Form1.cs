using MySql.Data.MySqlClient;
using System;
//using System.Collections.Generic;
//using System.ComponentModel;
using System.Data;
//using System.Data.SqlClient;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;

namespace Economy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Set to no text.
            textBox2.Text = "";
            // The password character is an asterisk.
            textBox2.PasswordChar = '*';
            // The control will allow no more than 11 characters.
            textBox2.MaxLength = 20;
        }
        bool a, i ;
        int b ;
        
        string query = "SELECT `id` FROM `aut` WHERE `login` = @uL AND `password` = @uP";
        private void Form1_Load(object sender, EventArgs e)
        {
            a = false;
            button1.Enabled = a;
            button2.Enabled = a;
            button3.Enabled = a;
            button4.Enabled = a;
            button5.Enabled = a;
            button6.Enabled = a;
            button7.Enabled = a;
            button10.Enabled = a;
            button11.Enabled = a;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Аналіз системи впровадження управління витрат
            Form4 newForm = new Form4();
            newForm.Show();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            // Аналіз скорочення штату
            Form2 newForm = new Form2();
            newForm.Show();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            // Аналіз збільшення штату
            Form5 newForm = new Form5();
            newForm.Show();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            // Аналіз перебудови управлінських структур
            Form3 newForm = new Form3();
            newForm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Аналіз доцільності збільшення основних виробничих фондів
            Form6 newForm = new Form6();
            newForm.Show();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            // Аналіз доцільності скорочення основних виробничих фондів
            Form8 newForm = new Form8();
            newForm.Show();
        }
        private void button7_Click(object sender, EventArgs e)
        {
            //Аналіз доцільності модернізації основних виробничих фондів
            Form7 newForm = new Form7();
            newForm.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            a = false;
            label3.Visible = a;
            button9.Visible = a;
            button1.Enabled = a;
            button2.Enabled = a;
            button3.Enabled = a;
            button4.Enabled = a;
            button5.Enabled = a;
            button6.Enabled = a;
            button7.Enabled = a;
            button10.Enabled = a;
            button11.Enabled = a;
            label1.Visible = true;
            label2.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            button8.Visible = true;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //Ризики за 2ма проектами
            Form9 newForm = new Form9();
            newForm.Show();

        }
        private void button11_Click(object sender, EventArgs e)
        {
            //Ризики за 3ма проектами
            Form10 newForm = new Form10();
            newForm.Show();
        }
        private void button8_Click(object sender, EventArgs e)
        {
            //Авторизація
            /*a = Convert.ToBoolean(b);
            if (a == true) 
            { 
                a = false;
            } 
            else 
            {
                a = true; 
            }
            */
            
            Class1 db = new Class1();
            MySqlCommand command = new MySqlCommand(query, db.getConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = textBox1.Text;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = textBox2.Text;//.GetHashCode()
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                db.openConnection();                
                MySqlCommand command2 = new MySqlCommand("SELECT access FROM `aut` WHERE `login` = @uL AND `password` = @uP", db.getConnection());
                command2.Parameters.Add("@uL", MySqlDbType.VarChar).Value = textBox1.Text;
                command2.Parameters.Add("@uP", MySqlDbType.VarChar).Value = textBox2.Text;//.GetHashCode()
                //MessageBox.Show(textBox2.Text.GetHashCode());
                b = (Int32)command2.ExecuteScalar();
                if ( b == 1)
                {
                    MessageBox.Show("Авторизовано: Вам надано доступ до програми");
                    a = true;
                    i = true;
                    MySqlCommand command3 = new MySqlCommand("SELECT Name FROM `aut` WHERE `login` = @uL AND `password` = @uP", db.getConnection());
                    command3.Parameters.Add("@uL", MySqlDbType.VarChar).Value = textBox1.Text;
                    command3.Parameters.Add("@uP", MySqlDbType.VarChar).Value = textBox2.Text;//.GetHashCode()
                    label3.Text = (String)command3.ExecuteScalar();
                    button8.Visible = false;
                    textBox1.Visible = false;
                    textBox2.Visible = false;
                    label1.Visible = false;
                    label2.Visible = false;
                }
                else
                {
                    MessageBox.Show("Авторизовано: У вас нема доступа до прорами. Ви можете купити її на нашому сайті");
                    a = false;
                    i = true;
                    MySqlCommand command3 = new MySqlCommand("SELECT Name FROM `aut` WHERE `login` = @uL AND `password` = @uP", db.getConnection());
                    command3.Parameters.Add("@uL", MySqlDbType.VarChar).Value = textBox1.Text;
                    command3.Parameters.Add("@uP", MySqlDbType.VarChar).Value = textBox2.Text;//.GetHashCode()
                    label3.Text = (String)command3.ExecuteScalar();
                    button8.Visible = false;
                    textBox1.Visible = false;
                    textBox2.Visible = false;
                    label1.Visible = false;
                    label2.Visible = false;
                }
                db.closeConnection();
                // b = Convert.ToString(command2.ExecuteScalar());
            }
            else
            {
                MessageBox.Show("Такого користувача нема. Вам потрібно створити акаунт на нашому сайті");
                a = false;
                i = false;
            }

            label3.Visible = i;
            button9.Visible = i;
            button1.Enabled = a;
            button2.Enabled = a;
            button3.Enabled = a;
            button4.Enabled = a;
            button5.Enabled = a;
            button6.Enabled = a;
            button7.Enabled = a;
            button10.Enabled = a;
            button11.Enabled = a;

        }


    }
}
