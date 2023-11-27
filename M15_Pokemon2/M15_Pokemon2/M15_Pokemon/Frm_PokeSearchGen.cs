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
    public partial class Frm_PokeSearchGen : Form
    {
        BaseDados db = new BaseDados();
        public Frm_PokeSearchGen()
        {
            InitializeComponent();
        }

        private void cmb_Gen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (chk_NgenNum.Checked)
            {
                dataGridView1.DataSource = db.devolve_consulta("Select Gen,COUNT(ID) as 'Num Pokemons' From Pokemons where Gen = " + cmb_Gen.Text+"Group by Gen");
                //Consulta do Num da dada geração
            }
            else
            {
                
                dataGridView1.DataSource= db.devolve_consulta("Select * From Pokemons where Gen=" + cmb_Gen.Text);
                //Consulta de todas da dada geração
            }
        }

        private void Frm_PokeSearchGen_Load(object sender, EventArgs e)
        {
            DataTable data = db.devolve_consulta("Select distinct Gen From Pokemons");
            for (int i = 0; i < data.Rows.Count; i++)
            {
                cmb_Gen.Items.Add(data.Rows[i][0].ToString());
            }
        }
    }
}
