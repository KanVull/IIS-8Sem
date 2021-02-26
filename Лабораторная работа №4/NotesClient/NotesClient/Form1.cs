using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotesClient
{
    public partial class Form1 : Form
    {
        NotesServiceReference.NotesServiceClient n;

        public Form1()
        {
            InitializeComponent();

            n = new NotesServiceReference.NotesServiceClient();
        }

        private void listView1_Resize(object sender, EventArgs e)
        {
            listView1.Columns[1].Width = listView1.ClientRectangle.Width - 1 - listView1.Columns[0].Width - listView1.Columns[2].Width;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Список заметок
            listView1.Items.Clear();

            //List<NotesClient.ServiceReference1.NoteRecord> lst = new List<NotesClient.ServiceReference1.NoteRecord>();
            NotesServiceReference.NoteRecord[] lst;
            lst = n.GetNotes(textBox1.Text);

            foreach (NotesServiceReference.NoteRecord r in lst)
            {
                listView1.Items.Add(r.id);
                listView1.Items[listView1.Items.Count - 1].SubItems.Add(r.record);
                listView1.Items[listView1.Items.Count - 1].SubItems.Add(Convert.ToString(r.done));
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Добавление заметки 
            if (textBox2.Text == "") return;

            NotesServiceReference.NoteRecord r = new NotesServiceReference.NoteRecord();
            r.id = Guid.NewGuid().ToString();
            r.record = textBox2.Text;
            r.done = false;
            
            if (n.AddNote(textBox1.Text, r))
            {
                textBox2.Clear();
                button1_Click(sender, e);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Отметка заметки как исполненной
            if (listView1.SelectedItems.Count < 1) return;

            if (n.SetDone(textBox1.Text, listView1.SelectedItems[0].Text))
            {
                button1_Click(sender, e);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Удаление заметки
            if (listView1.SelectedItems.Count < 1) return;

            if (n.DeleteNote(textBox1.Text, listView1.SelectedItems[0].Text))
            {
                button1_Click(sender, e);
            }
        }
    }
}
