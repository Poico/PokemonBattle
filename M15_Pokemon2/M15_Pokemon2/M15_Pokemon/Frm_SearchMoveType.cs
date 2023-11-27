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
    public partial class Frm_SearchMoveType : Form
    {
        public Frm_SearchMoveType()
        {
            InitializeComponent();
        }
        BaseDados db = new BaseDados();
        private void button1_Click(object sender, EventArgs e)
        {
            DataTable data = db.devolve_consulta("Select * From Moves Where Type='"+Txt_Type.Text+"'");
            dataGridView1.DataSource = data;
        }

        private void Frm_SearchMoveType_Load(object sender, EventArgs e)
        {

        }
    }
}
