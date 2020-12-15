using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oraifeladat20201215
{
    public partial class frmSzerzo : Form
    {
        OleDbConnection conn;
        public frmSzerzo()
        {
            conn = new OleDbConnection(
            "Provider=Microsoft.ACE.OLEDB.12.0;" +
            @"Data Source=|DataDirectory|Resources\idezetek.accdb");
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void frmSzerzo_Load(object sender, EventArgs e)
        {

        }

        private void keresésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSzerzoLista f = new FrmSzerzoLista();
            f.ShowDialog();
        }

        private void mentésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("A név mező kitöltése kötelező!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        /*     
         *     private bool törlésToolStripMenuItem_Click(object sender, EventArgs e)
              {
                  if(textbox2 != null)
                      {
                          törlésToolStripMenuItem.Enabled == true;
                      }
                  else if(String.IsNullOrEmpty(textBox2.Text))
                        {
                            törlésToolStripMenuItem.Enabled == false;
                        }
              }
        

        */
    }
}
