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
    public partial class Frm_RemoveMove : Form
    {
        public Frm_RemoveMove()
        {
            InitializeComponent();
        }
        BaseDados db = new BaseDados();
        private void Frm_RemoveMove_Load(object sender, EventArgs e)
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

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                db.devolve_consulta("DELETE FROM Moves WHERE MoveID=" + Txt_ID.Text);
                MessageBox.Show("Move deleted with sucess");
            }
            catch (Exception)
            {
                MessageBox.Show("There was a error deleting the Move.\n Please Try again", "Error Registering", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
