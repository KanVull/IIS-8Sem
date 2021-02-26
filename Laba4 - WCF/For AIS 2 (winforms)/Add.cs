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
    public partial class Add : Form
    {
        ServiceReference1.ServiceClient s = new ServiceReference1.ServiceClient();
        public Add(int choice, ServiceReference1.TaskRecord task)
        {
            InitializeComponent();
            if (choice == 1) button1.Text = "Add";
            if (choice == 2) button1.Text = "Edit";
            textBox1.Text = task.id;
            textBox2.Text = task.name;
            textBox3.Text = task.surname;
            textBox4.Text = task.group;
            textBox5.Text = task.task_name;
            textBox6.Text = task.subject;
            textBox7.Text = task.discription;
        }

        private void Do_Click(object sender, EventArgs e)
        {
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ServiceReference1.TaskRecord task = new ServiceReference1.TaskRecord
            {
                id = textBox1.Text,
                name = textBox2.Text,
                surname = textBox3.Text,
                group = textBox4.Text,
                task_name = textBox5.Text,
                subject = textBox6.Text,
                discription = textBox7.Text,

            };
            if (button1.Text == "Add")
            {
                s.AddTask(task);
            }
            if (button1.Text == "Edit")
            {
                s.EditTask(task);
            }
            Close();
        }

        private void TBCity_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(78, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(174, 20);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(177, 243);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(78, 39);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(174, 20);
            this.textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(78, 65);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(174, 20);
            this.textBox3.TabIndex = 4;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(78, 91);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(174, 20);
            this.textBox4.TabIndex = 5;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(78, 117);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(174, 20);
            this.textBox5.TabIndex = 6;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(78, 143);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(174, 20);
            this.textBox6.TabIndex = 7;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(78, 169);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(174, 68);
            this.textBox7.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Surname";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Group";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Task name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Subject";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 172);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Discription";
            // 
            // Add
            // 
            this.ClientSize = new System.Drawing.Size(259, 271);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Add";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

    }
}
