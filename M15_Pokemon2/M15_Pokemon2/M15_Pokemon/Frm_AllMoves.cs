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
    public partial class Frm_AllMoves : Form
    {
        public Frm_AllMoves()
        {
            InitializeComponent();
        }
        BaseDados db = new BaseDados();
        private void Frm_AllMoves_Load(object sender, EventArgs e)
        {
            DataTable data = db.devolve_consulta("Select * From Moves");
            dataGridView1.DataSource = data;
        }
    }
}
