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
    public partial class Form2 : Form
    {
        Program.Student student =  Program.studen;
        string strRoom;

        public Form2()
        {
            InitializeComponent();

        }

        public void Upload()
        {
            textBox1.Text = Program.studen.Name;
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            this.Hide();
            form5.ShowDialog();
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (Program.studen.Name != null)
                Upload();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string strSt = student.Name + strRoom;
            if (strSt.Length != 0)
            {
                Program.students.Add(strSt);
            }
            
            Form5 form5 = new Form5();
            this.Hide();
            form5.ShowDialog();
            this.Close();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            student.Name = textBox1.Text + "    ";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            strRoom = textBox2.Text + "    ";
        }
    }
}
