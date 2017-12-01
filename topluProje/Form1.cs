using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace topluProje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
      private void btnEkle_Click(object sender, EventArgs e)
        {
            TreeNode secilen;
            secilen = treeView1.SelectedNode;
            if (rbKokDugum.Checked)
            {
                treeView1.Nodes.Add(textBox1.Text);
            }
            else if (rbAltDugum.Checked)
            {
                secilen.Nodes.Add(textBox1.Text);
            }

        }

        private void cbKategoriGoster_CheckedChanged(object sender, EventArgs e)
        {
              if (cbKategoriGoster.Checked == true) { 
                treeView1.ExpandAll();
            }
            else
            {
                treeView1.CollapseAll();
            }
        }

        private void btnKategoriSil_Click(object sender, EventArgs e)
        {
            TreeNode secilen;
            secilen = treeView1.SelectedNode;
            if (!(secilen.Parent == null))
            {
                secilen.Parent.Nodes.Remove(secilen);

            }
            else
            {
                treeView1.Nodes.Remove(secilen);
            }
        }

        private void cbSeciliKategori_CheckedChanged(object sender, EventArgs e)
        {
            //if (cbKategoriGoster.Checked == true)
            //{
                TreeNode secilen;
                secilen = treeView1.SelectedNode;
                MessageBox.Show(secilen.Text);
           /* }
            else
            {
                return;
            }*/
        }
    }
    }
