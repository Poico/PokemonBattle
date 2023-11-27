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
    public partial class Frm_SearchMoveID : Form
    {
        public Frm_SearchMoveID()
        {
            InitializeComponent();
        }

        private void Txt_ID_TextChanged(object sender, EventArgs e)
        {
            BaseDados db = new BaseDados();
            try
            {
                DataTable Data = db.devolve_consulta("Select * From Moves Where Moves.MoveID = '" + Txt_ID.Text + "'");
                Txt_Name.Text = Data.Rows[0][1].ToString();
                Txt_Type.Text = Data.Rows[0][2].ToString();
                Txt_Effect.Text = Data.Rows[0][3].ToString();
                comboBox1.Text = Data.Rows[0][4].ToString();
                Txt_PP.Text = Data.Rows[0][5].ToString();
                Txt_AttackPower.Text = Data.Rows[0][6].ToString();
                Txt_Accuracy.Text = Data.Rows[0][7].ToString();
            }
            catch (Exception)
            {


            }
        }
    }
}
