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


namespace WORLDSKILLS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.BackColor = Color.FromArgb(192, 255, 192);
            button5.BackColor = SystemColors.Control;
            button4.BackColor = SystemColors.Control;
            button6.BackColor = SystemColors.Control;

            label11.Visible = false;
            pictureBox4.Visible = false;
            polzovatelDataGridView.Visible = false;

            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true; 
            label4.Visible = true;
            label5.Visible = true;
            dateTimePicker1.Visible = true;
            dateTimePicker2.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            pictureBox1.Visible = true;
            checkBox1.Visible = true;

            label6.Visible = false;
            label7.Visible = false;
            listBox1.Visible = false;
            listBox2.Visible = false;
            button9.Visible = false;
            pictureBox2.Visible = false;

            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            groupBox1.Visible = false;
            comboBox1.Visible = false;
            pictureBox3.Visible = false;
            checkBox2.Visible = false;
            checkBox3.Visible = false;
            checkBox4.Visible = false;
            checkBox5.Visible = false;
            checkBox6.Visible = false;
            /* checkBox7.Visible = false;
            checkBox8.Visible = false;
            checkBox9.Visible = false;
            checkBox10.Visible = false;
            checkBox11.Visible = false;
            checkBox12.Visible = false;
            checkBox13.Visible = false;
            checkBox14.Visible = false;
            checkBox15.Visible = false;*/
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string connectionString = @"Data Source=LIGHT-ПК\SQLEXPRESS;Initial Catalog=Atelier;Integrated Security=True"; 
            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();
                var cmd = new SqlCommand("insert into Polzovatel(Login, Parol, Rol, Naimenovanie) values('Igfgfgfogr', '12g3a', 'Menedzher', 'loh')", conn);
                var reader = cmd.ExecuteReader();
                polzovatelTableAdapter.Fill(atelierDataSet.Polzovatel);
                conn.Close();
            }
                
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.BackColor = Color.FromArgb(192, 255, 192);
            button3.BackColor = SystemColors.ActiveBorder;
            button4.BackColor = SystemColors.Control;
            button6.BackColor = SystemColors.Control;

            label11.Visible = false;
            pictureBox4.Visible = false;
            polzovatelDataGridView.Visible = false;

            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            dateTimePicker1.Visible = false;
            dateTimePicker2.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            pictureBox1.Visible = false;
            checkBox1.Visible = false;

            label6.Visible = true;
            label7.Visible = true;
            listBox1.Visible = true;
            listBox2.Visible = true;
            button9.Visible = true;
            pictureBox2.Visible = true;

            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            groupBox1.Visible = false;
            comboBox1.Visible = false;
            pictureBox3.Visible = false;
            checkBox2.Visible = false;
            checkBox3.Visible = false;
            checkBox4.Visible = false;
            checkBox5.Visible = false;
            checkBox6.Visible = false;
            /* checkBox7.Visible = false;
            checkBox8.Visible = false;
            checkBox9.Visible = false;
            checkBox10.Visible = false;
            checkBox11.Visible = false;
            checkBox12.Visible = false;
            checkBox13.Visible = false;
            checkBox14.Visible = false;
            checkBox15.Visible = false;*/

        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.BackColor = Color.FromArgb(192, 255, 192);
            button3.BackColor = SystemColors.ActiveBorder;
            button5.BackColor = SystemColors.ActiveBorder;
            button6.BackColor = SystemColors.Control;

            label11.Visible = false;
            pictureBox4.Visible = false;
            polzovatelDataGridView.Visible = false;

            label6.Visible = false;
            label7.Visible = false;
            listBox1.Visible = false;
            listBox2.Visible = false;
            button9.Visible = false;
            pictureBox2.Visible = false;

            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            dateTimePicker1.Visible = false;
            dateTimePicker2.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            pictureBox1.Visible = false;
            checkBox1.Visible = false;

            label8.Visible = true;
            label9.Visible = true;
            label10.Visible = true;
            groupBox1.Visible = true;
            comboBox1.Visible = true;
            pictureBox3.Visible = true;
            checkBox2.Visible = true;
            checkBox3.Visible = true;
            checkBox4.Visible = true;
            checkBox5.Visible = true;
            checkBox6.Visible = true;
            /* checkBox7.Visible = true;
            checkBox8.Visible = true;
            checkBox9.Visible = true;
            checkBox10.Visible = true;
            checkBox11.Visible = true;
            checkBox12.Visible = true;
            checkBox13.Visible = true;
            checkBox14.Visible = true;
            checkBox15.Visible = true;*/
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.BackColor = Color.FromArgb(192, 255, 192);
            button4.BackColor = SystemColors.ActiveBorder;
            button5.BackColor = SystemColors.ActiveBorder;
            button3.BackColor = SystemColors.ActiveBorder;

            label11.Visible = true;
            pictureBox4.Visible = true;
            polzovatelDataGridView.Visible = true;

            label6.Visible = false;
            label7.Visible = false;
            listBox1.Visible = false;
            listBox2.Visible = false;
            button9.Visible = false;
            pictureBox2.Visible = false;

            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            dateTimePicker1.Visible = false;
            dateTimePicker2.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            pictureBox1.Visible = false;
            checkBox1.Visible = false;

            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            groupBox1.Visible = false;
            comboBox1.Visible = false;
            pictureBox3.Visible = false;
            checkBox2.Visible = false;
            checkBox3.Visible = false;
            checkBox4.Visible = false;
            checkBox5.Visible = false;
            checkBox6.Visible = false;
            /* checkBox7.Visible = false;
            checkBox8.Visible = false;
            checkBox9.Visible = false;
            checkBox10.Visible = false;
            checkBox11.Visible = false;
            checkBox12.Visible = false;
            checkBox13.Visible = false;
            checkBox14.Visible = false;
            checkBox15.Visible = false;*/
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(listBox1.SelectedItem);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            checkBox2.Checked = true;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            checkBox2.Checked = true;
            checkBox3.Checked = true;
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            checkBox2.Checked = true;
            checkBox3.Checked = true;
            checkBox4.Checked = true;
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            checkBox2.Checked = true;
            checkBox3.Checked = true;
            checkBox4.Checked = true;
            checkBox5.Checked = true;
        }

        private void polzovatelBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.polzovatelBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.atelierDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "atelierDataSet.Polzovatel". При необходимости она может быть перемещена или удалена.
            this.polzovatelTableAdapter.Fill(this.atelierDataSet.Polzovatel);

        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            Konstruktor f = new Konstruktor();
            f.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=LIGHT-ПК\SQLEXPRESS;Initial Catalog=Atelier;Integrated Security=True";
            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();
                var cmd = new SqlCommand("delete from Polzovatel where rol = 'menedzher'", conn);
                var reader = cmd.ExecuteReader();
                polzovatelTableAdapter.Fill(atelierDataSet.Polzovatel);
                conn.Close();
            }
        }
    }
}
