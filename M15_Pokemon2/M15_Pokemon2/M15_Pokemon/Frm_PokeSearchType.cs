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
    public partial class Frm_PokeSearchType : Form
    {
        BaseDados db = new BaseDados();
        public Frm_PokeSearchType()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = db.devolve_consulta("Select * From Pokemons where Type1='" + comboBox1.Text+"' OR Type2='"+comboBox1.Text+"'");
            }
            catch (Exception)
            {

                
            }
        }

        private void Frm_PokeSearchType_Load(object sender, EventArgs e)
        {
            DataTable data = db.devolve_consulta("Select distinct Type1 From Pokemons");
            DataTable data1 = db.devolve_consulta("Select distinct Type2 From Pokemons");
            for (int i = 0; i < data.Rows.Count; i++)
            {
                comboBox1.Items.Add(data.Rows[i][0].ToString());
            }
            for (int i = 0; i < data1.Rows.Count; i++)
            {
                comboBox1.Items.Add(data1.Rows[i][0].ToString());
            }
        }
    }
}
