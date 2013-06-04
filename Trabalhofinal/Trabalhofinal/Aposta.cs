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
    public partial class Aposta : Form
    {
        public Aposta()
        {
            InitializeComponent();
        }

        private void Aposta_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Objecto' table. You can move, or remove it, as needed.
            this.objectoTableAdapter.Fill(this.database1DataSet.Objecto);
            // TODO: This line of code loads data into the 'database1DataSet.Jogador' table. You can move, or remove it, as needed.
            this.jogadorTableAdapter.Fill(this.database1DataSet.Jogador);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
