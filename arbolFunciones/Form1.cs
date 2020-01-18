using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace arbolFunciones
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgrNod_Click(object sender, EventArgs e)
        {
            arbolNod.Nodes.Add(txtNodo.Text);
            txtNodo.Text = " ";
        }

        private void btnAddElm_Click(object sender, EventArgs e)
        {
            arbolNod.SelectedNode.Nodes.Add(txtHijo.Text);
            txtHijo.Text = " ";
        }

        private void btnDelNod_Click(object sender, EventArgs e)
        {
            arbolNod.Nodes.Remove(arbolNod.SelectedNode);
        }

        private void btnDelArb_Click(object sender, EventArgs e)
        {
            arbolNod.Nodes.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            arbolNod.SelectedNode.Name = txtEdit.Text;
            arbolNod.SelectedNode.Text = txtEdit.Text;
            txtEdit.Text = " ";
        }
    }
}
