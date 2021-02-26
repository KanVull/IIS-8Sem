using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace For_AIS_2__winforms_
{
    public partial class Searching : Form
    {
        public Form1 d;
        ServiceReference1.ServiceClient client = new ServiceReference1.ServiceClient();
        public Searching(Form1 f)
        {
            d = f;
            InitializeComponent();
        }
        private void ClearAndBlockTB()
        {
            textBox1.Text = "";
            textBox1.ReadOnly = true;
            textBox2.Text = "";
            textBox2.ReadOnly = true;
            textBox3.Text = "";
            textBox3.ReadOnly = true;
            textBox4.Text = "";
            textBox4.ReadOnly = true;
            textBox5.Text = "";
            textBox5.ReadOnly = true;
            textBox6.Text = "";
            textBox6.ReadOnly = true;
        }
        string selectedCell = "";
        private void ChangeFocus(string choice)
        {
            ClearAndBlockTB();
            selectedCell = choice;
            switch (choice)
            {
                case "ID":
                    textBox1.ReadOnly = false;
                    break;
                case "Name":
                    textBox2.ReadOnly = false;
                    break;
                case "Surname":
                    textBox3.ReadOnly = false;
                    break;
                case "Group":
                    textBox4.ReadOnly = false;
                    break;
                case "Task_name":
                    textBox5.ReadOnly = false;
                    break;
                case "Subject":
                    textBox5.ReadOnly = false;
                    break;
                default:
                    break;
            }
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton.Checked)
            {
                ChangeFocus(radioButton.Text);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            d.dataGridView1.Rows.Clear();
            var tasks = client.Search(new ServiceReference1.TaskRecord
            {
                id = textBox1.Text,
                name = textBox2.Text,
                surname = textBox3.Text,
                group = textBox4.Text,
                task_name = textBox5.Text,
                subject = textBox6.Text,

            });
            foreach (var item in tasks)
            {
                int n = d.dataGridView1.Rows.Add();
                d.dataGridView1.Rows[n].Cells[0].Value = item.id;
                d.dataGridView1.Rows[n].Cells[1].Value = item.name;
                d.dataGridView1.Rows[n].Cells[2].Value = item.surname;
                d.dataGridView1.Rows[n].Cells[3].Value = item.group;
                d.dataGridView1.Rows[n].Cells[4].Value = item.task_name;
                d.dataGridView1.Rows[n].Cells[5].Value = item.subject;
                d.dataGridView1.Rows[n].Cells[6].Value = item.discription;
            }
            Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
