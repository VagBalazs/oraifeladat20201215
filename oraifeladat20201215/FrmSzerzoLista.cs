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
    public partial class FrmSzerzoLista : Form
    {
        OleDbConnection conn;
        public FrmSzerzoLista()
        {
            conn = new OleDbConnection(
            "Provider=Microsoft.ACE.OLEDB.12.0;" +
            @"Data Source=|DataDirectory|Resources\idezetek.accdb");
            InitializeComponent();
        }

        private void FrmSzerzoLista_Load(object sender, EventArgs e)
        {
            conn.Open();
            using (OleDbCommand cmd = new OleDbCommand("SELECT * FROM szerzo", conn))
            {
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
