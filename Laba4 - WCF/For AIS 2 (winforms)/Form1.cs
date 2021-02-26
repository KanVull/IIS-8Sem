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
    public partial class Form1 : Form
    {
        ServiceReference1.ServiceClient client = new ServiceReference1.ServiceClient();
        public Form1()
        {
            InitializeComponent();
        }

        private void ButShowXML_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            var tasks = client.GetTasks();
            foreach (var item in tasks)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = item.id;
                dataGridView1.Rows[n].Cells[1].Value = item.name;
                dataGridView1.Rows[n].Cells[2].Value = item.surname;
                dataGridView1.Rows[n].Cells[3].Value = item.group;
                dataGridView1.Rows[n].Cells[4].Value = item.task_name;
                dataGridView1.Rows[n].Cells[5].Value = item.subject;
                dataGridView1.Rows[n].Cells[6].Value = item.discription;

            }
        }

        private void ButAdd_Click(object sender, EventArgs e)
        {
            string id = client.SearchLastID();
            Add add = new Add(1, new ServiceReference1.TaskRecord
            {
                id = (int.Parse(id) + 1).ToString(),
                name = "",
                surname = "",
                group = "",
                task_name = "",
                subject = "",
                discription = "",

            });
            if (add.ShowDialog() == DialogResult.Cancel)
            {
                ButShowXML_Click(sender, e);
            }
        }
        private int selectedIndex = 0;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > 0 && e.RowIndex+1 < dataGridView1.Rows.Count && e.ColumnIndex > 0 && e.ColumnIndex+1 < dataGridView1.Columns.Count)
            {
                if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex] != null)
                {
                    selectedIndex = e.RowIndex;
                    ButEdit.Enabled = true;
                    ButDelete.Enabled = true;
                }
            }
            else
            {
                ButEdit.Enabled = false;
                ButDelete.Enabled = false;
            }
        }

        private void ButEdit_Click(object sender, EventArgs e)
        {
            var task = new ServiceReference1.TaskRecord
            {
                id = dataGridView1.Rows[selectedIndex].Cells[0].Value.ToString(),
                name = dataGridView1.Rows[selectedIndex].Cells[1].Value.ToString(),
                surname = dataGridView1.Rows[selectedIndex].Cells[2].Value.ToString(),
                group = dataGridView1.Rows[selectedIndex].Cells[3].Value.ToString(),
                task_name = dataGridView1.Rows[selectedIndex].Cells[4].Value.ToString(),
                subject = dataGridView1.Rows[selectedIndex].Cells[5].Value.ToString(),
                discription = dataGridView1.Rows[selectedIndex].Cells[6].Value.ToString(),
            };
            Add add = new Add(2, task);
            if (add.ShowDialog() == DialogResult.Cancel)
            {
                ButShowXML_Click(sender, e);
            }
        }

        private void ButDelete_Click(object sender, EventArgs e)
        {
            client.DeleteTask(dataGridView1.Rows[selectedIndex].Cells[0].Value.ToString());
            ButShowXML_Click(sender, e);
        }

        private void ButSearch_Click(object sender, EventArgs e)
        {
            Searching s = new Searching(this);
            s.Show();
        }
    }
}
