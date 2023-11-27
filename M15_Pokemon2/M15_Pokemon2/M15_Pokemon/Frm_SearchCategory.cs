using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M15_Pokemon
{
    public partial class Frm_SearchCategory : Form
    {
        public Frm_SearchCategory()
        {
            InitializeComponent();
        }
        BaseDados db = new BaseDados();
        private void button1_Click(object sender, EventArgs e)
        {

            DataTable data = db.devolve_consulta("Select * From Moves Where Category='" + comboBox1.Text + "'");
            dataGridView1.DataSource = data;
        }

        private void Frm_SearchCategory_Load(object sender, EventArgs e)
        {
            DataTable data = db.devolve_consulta("Select distinct Category From Moves");
            for (int i = 0; i < data.Rows.Count; i++)
            {
                comboBox1.Items.Add(data.Rows[i][0].ToString());
            }
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
