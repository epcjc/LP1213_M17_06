using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Trabalhofinal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cancelado");
            Application.Exit();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            this.jogadorTableAdapter.Insert(this.textBox1.Text, this.textBox2.Text, this.dateTimePicker1.Value, 0, 0);

            MessageBox.Show("Registo efectuado com exito");
            Application.Exit();
        }


        private void jogadorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Jogador' table. You can move, or remove it, as needed.
           

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
