using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace M15_Pokemon
{
    public partial class Frm_AddMove : Form
    {
        public Frm_AddMove()
        {
            InitializeComponent();
        }

        private void Btn_Register_Click(object sender, EventArgs e)
        {
            try
            {
                BaseDados bd = new BaseDados();
                string querySql = "Insert into Moves(Name,Type,Category,Effect,PP,AttackPower,Accuracy)";
                querySql += "Values (@Name,@Type,@Category,@Effect,@PP,@AttackPower,@Accuracy)";

                List<SqlParameter> parameters = new List<SqlParameter>();
                parameters.Add(new SqlParameter("@Name", Txt_Name.Text));
                parameters.Add(new SqlParameter("@Type", Txt_Type.Text));
                parameters.Add(new SqlParameter("@Category", comboBox1.Text));
                parameters.Add(new SqlParameter("@Effect", Txt_Effect.Text));
                parameters.Add(new SqlParameter("@PP", Txt_PP.Text));
                parameters.Add(new SqlParameter("@AttackPower", Txt_AttackPower.Text));
                parameters.Add(new SqlParameter("@Accuracy", Txt_Accuracy.Text));
                bd.executa_SQL(querySql, parameters);
                MessageBox.Show("New Move added with sucess");
                this.Hide();
                
            }
            catch (Exception)
            {
                MessageBox.Show("There was a error registering the Move.\n Please Try again", "Error Registering", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Txt_Accuracy_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(Txt_Accuracy.Text) > 100 || int.Parse(Txt_Accuracy.Text) < 0)
                {
                    errorProvider1.SetError(Txt_Accuracy, "The number needs to be between 0 and 100");
                }
            }
            catch (Exception)
            {
                
                if (Txt_Accuracy.Text!="")
                {
                    errorProvider1.SetError(Txt_Accuracy, "The number needs to be between 0 and 100");
                }
                if (Txt_Accuracy.Text == "")
                {
                    errorProvider1.Dispose();
                }
            }
            
        }

        private void Frm_AddMove_Load(object sender, EventArgs e)
        {
            errorProvider1.Dispose();
        }

        private void Txt_AttackPower_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int yes = int.Parse(Txt_AttackPower.Text);
                errorProvider1.Dispose();
            }
            catch (Exception)
            {
                if (Txt_AttackPower.Text!="")
                {
                    errorProvider1.SetError(Txt_AttackPower, "It needs to be a number");
                }
                else
                {
                    errorProvider1.Dispose();
                }
            }
        }

        private void Txt_PP_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int yes = int.Parse(Txt_PP.Text);
                errorProvider1.Dispose();
            }
            catch (Exception)
            {
                if (Txt_PP.Text != "")
                {
                    errorProvider1.SetError(Txt_PP, "It needs to be a number");
                }
                else
                {
                    errorProvider1.Dispose();
                }
            }
        }

        private void Txt_Name_TextChanged(object sender, EventArgs e)
        {
            if (Txt_Name.Text=="")
            {
                errorProvider1.SetError(Txt_Name, "This Camp is required");
            }
            else
            {
                errorProvider1.Dispose();
            }
        }
    }
}
