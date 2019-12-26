using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Automat_comendant
{
    public partial class Form5 : Form
    {
        
        public Form5()
        {

            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Main_Form form1 = new Main_Form();
            this.Hide();
            form1.ShowDialog();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            var st = listBox1.SelectedIndex;
            Form2 form2 = new Form2();
            this.Hide();
            form2.ShowDialog();
            this.Close();
            Program.studen.F = st;
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            UploadStudentsList();
        }
        public void UploadStudentsList()
        {
            listBox1.Items.Clear();
            var list = Program.students;
            if (!list.Contains(null))
                foreach (var st in list)
                    listBox1.Items.Add(st); 
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            this.Hide();
            form2.ShowDialog();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {

            var st = listBox1.SelectedIndex;
            Program.students.RemoveAt(st);
            UploadStudentsList();
        }
    }
}
