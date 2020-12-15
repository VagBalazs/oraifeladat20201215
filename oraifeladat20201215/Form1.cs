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
    public partial class Form1 : Form
    {
        OleDbConnection conn;
        public Form1()
        {
            conn = new OleDbConnection(
          "Provider=Microsoft.ACE.OLEDB.12.0;" +
          @"Data Source=|DataDirectory|Resources\idezetek.accdb");
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conn.Open();
            using (OleDbCommand cmd = new OleDbCommand(
                "SELECT tema.megnevezes AS 'Téma'," +
                " utalas.temaID AS 'Idézetek száma' " +
                " FROM tema, utalas " +
                " WHERE tema.temaID = utalas.temaID  ", conn))
            {
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }

            using (OleDbCommand cmd = new OleDbCommand(
                "SELECT szerzo.nev AS 'Szerző'," +
                " idezet.forrasID AS 'Idézetek száma' " +
                "FROM szerzo, idezet " +
                "WHERE idezet.forrasID=szerzo.szerzoID ", conn))
            {
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView2.DataSource = dt;
            }

/*
            using (OleDbCommand cmd = new OleDbCommand("SELECT szoveg FROM idezet ORDER BY RAND() LIMIT 1", conn))
            {
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                label4.Text = ds.Tables[0].Rows.ToString(); ;
            }
*/

            label2.Text = DateTime.Now.ToString();


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void keresésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSzerzo f = new frmSzerzo();
            f.ShowDialog();
        }
    }
}
