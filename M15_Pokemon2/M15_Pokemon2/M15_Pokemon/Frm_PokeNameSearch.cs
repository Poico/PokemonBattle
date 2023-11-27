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
    public partial class Frm_PokeNameSearch : Form
    {
        public Frm_PokeNameSearch()
        {
            InitializeComponent();
        }
        BaseDados db = new BaseDados();
        private void Txt_Name_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable data = db.devolve_consulta("Select * From Pokemons Where Name like '%" + Txt_Name.Text + "%'");
                dataGridView1.DataSource = data;
            }
            catch (Exception)
            {
    
            }
        }

        private void Frm_PokeNameSearch_Load(object sender, EventArgs e)
        {

        }
    }
}
