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
    public partial class Frm_EditMove : Form
    {
        public Frm_EditMove()
        {
            InitializeComponent();
        }
        BaseDados db = new BaseDados();
        private void Txt_Type_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Txt_ID_TextChanged(object sender, EventArgs e)
        {
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

        private void Frm_EditMove_Load(object sender, EventArgs e)
        {

        }

        private void Txt_Name_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable Data = db.devolve_consulta("Select * From Moves Where Moves.Name = '" + Txt_Name.Text + "'");
                Txt_ID.Text = Data.Rows[0][0].ToString();
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

        private void Btn_Update_Click(object sender, EventArgs e)
        {
            try
            {
                db.executa_SQL("Update Moves Set Name='" + Txt_Name.Text + "', Type='" + Txt_Type.Text + "', Effect='" + Txt_Effect.Text + "', Category='" + comboBox1.Text + "',PP=" + int.Parse(Txt_PP.Text) + ",AttackPower=" + int.Parse(Txt_AttackPower.Text) + ",Accuracy=" + int.Parse(Txt_Accuracy.Text) + "where MoveID=" + Txt_ID.Text + "");
                MessageBox.Show("Move updated with sucess");
            }
            catch (Exception)
            {
                MessageBox.Show("There was a error registering the Move.\n Please Try again", "Error Registering", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
