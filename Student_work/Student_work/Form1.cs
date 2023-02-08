using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_work
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student stud = new Student();
            stud.name = textBox1.Text;
            stud.rost = (int)numericUpDown1.Value;
            MessageBox.Show(string.Format($"Студент: {stud.name}\nРост: {stud.rost}\nВес: {stud.GetEat()}"));

            // съел 6 кг
            stud.SetEat(6);
            MessageBox.Show(string.Format($"Студент: {stud.name}\nРост: {stud.rost}\nВес: {stud.GetEat()}"));

            // съел 11 кг
            stud.SetEat(11);
            MessageBox.Show(string.Format($"Студент: {stud.name}\nРост: {stud.rost}\nВес: {stud.GetEat()}"));
        }
    }
}
