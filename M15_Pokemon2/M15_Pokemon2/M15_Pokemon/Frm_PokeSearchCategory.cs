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
    public partial class Frm_PokeSearchCategory : Form
    {
        public Frm_PokeSearchCategory()
        {
            InitializeComponent();
        }
        BaseDados db = new BaseDados();
        private void Frm_PokeSearchCategory_Load(object sender, EventArgs e)
        {
            DataTable data = db.devolve_consulta("Select distinct Category From Pokemons");
            for (int i = 0; i < data.Rows.Count; i++)
            {
                comboBox1.Items.Add(data.Rows[i][0].ToString());
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = db.devolve_consulta("Select * From Pokemons Where Category='" + comboBox1.Text+"'");
            }
            catch (Exception)
            {

                
            }
        }
    }
}
