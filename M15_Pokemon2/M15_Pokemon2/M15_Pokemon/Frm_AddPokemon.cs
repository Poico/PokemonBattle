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
    public partial class Frm_AddPokemon : Form
    {
        public Frm_AddPokemon()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Frm_AddPokemon_Load(object sender, EventArgs e)
        {
            errorProvider1.Dispose();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt_Name_TextChanged(object sender, EventArgs e)
        {
            if (Txt_Name.Text=="")
            {
                errorProvider1.SetError(Txt_Name, "It needs to be letters and cannot be null");
            }
            else
            {
                errorProvider1.Dispose();
            }
            int parsedValue;
            foreach (var item in Txt_Name.Text)
            {
                if (int.TryParse(Txt_Name.Text, out parsedValue))
                {
                    errorProvider1.SetError(Txt_Name, "It needs to be letters and cannot be empty");
                }
            }
            
        }

        private void Txt_Gen_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!(int.Parse(Txt_Gen.Text) > 0 && int.Parse(Txt_Gen.Text) <= 8))
                {
                    errorProvider1.SetError(Txt_Gen, "It needs to be a number between 1-8 ");
                }
                else
                {
                    errorProvider1.Dispose();
                }
            }
            catch (Exception)
            {
                errorProvider1.SetError(Txt_Gen, "It needs to be a number between 1-8 ");

            }
            
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                if (!(int.Parse(Txt_Height.Text) > 0))
                {
                    errorProvider1.SetError(Txt_Height, "It needs to be a number greater than 0");
                }
                else
                {
                    errorProvider1.Dispose();
                }
            }
            catch (Exception)
            {
                errorProvider1.SetError(Txt_Height, "It needs to be a number greater than 0");

            }
        }

        private void Txt_Weight_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!(int.Parse(Txt_Weight.Text) > 0))
                {
                    errorProvider1.SetError(Txt_Weight, "It needs to be a number greater than 0");
                }
                else
                {
                    errorProvider1.Dispose();
                }
            }
            catch (Exception)
            {
                errorProvider1.SetError(Txt_Weight, "It needs to be a number greater than 0");

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frm_AllMoves frm = new Frm_AllMoves();
            frm.Show();
        }

        private void Btn_Upload_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            try
            {
                pictureBox1.Load(openFileDialog1.FileName);
            }
            catch (Exception)
            {
                MessageBox.Show("Não foi possível carregar a imamgem");
            }
        }

        private void Btn_Register_Click(object sender, EventArgs e)
        {
            
            byte[] dados = null;
            try
            {
                FileStream ficheiro = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);
                dados = new byte[ficheiro.Length];
                ficheiro.Read(dados, 0, (int)ficheiro.Length);
                ficheiro.Close();
            }
            catch (Exception)
            {

            }

            BaseDados bd = new BaseDados();
            string querySql = "Insert into Pokemons(Name,Gen,Height,Weight,Category,Type1,Type2,Classification,Habilities,Image,CharacterID,MoveID1,MoveID2,MoveID3,MoveID4)";
            querySql += "Values (@Name,@Gen,@Height,@Weight,@Category,@Type1,@Type2,@Classification,@Habilities,@Image,@CharacterID,@MoveID1,@MoveID2,@MoveID3,@MoveID4)";

            
                List<SqlParameter> parameters = new List<SqlParameter>();
                parameters.Add(new SqlParameter("@Name", Txt_Name.Text));
                parameters.Add(new SqlParameter("@Gen", int.Parse(Txt_Gen.Text)));
                parameters.Add(new SqlParameter("@Height", Txt_Height.Text));
                parameters.Add(new SqlParameter("@Weight", Txt_Weight.Text));
                parameters.Add(new SqlParameter("@Category", Txt_Category.Text));
                parameters.Add(new SqlParameter("@Type1", Txt_Type1.Text));
                parameters.Add(new SqlParameter("@Type2", Txt_Type2.Text));
                parameters.Add(new SqlParameter("@Classification", Txt_Classification.Text));
                parameters.Add(new SqlParameter("@Habilities", Txt_Habilities.Text));
                parameters.Add(new SqlParameter("@Image", dados));
                parameters.Add(new SqlParameter("@CharacterID", Frm_Login.ID));
                parameters.Add(new SqlParameter("@MoveID1", Txt_Move1.Text));
                parameters.Add(new SqlParameter("@MoveID2", Txt_Move2.Text));
                parameters.Add(new SqlParameter("@MoveID3", Txt_Move3.Text));
                parameters.Add(new SqlParameter("@MoveID4", Txt_Move4.Text));

            bd.executa_SQL(querySql, parameters);
                MessageBox.Show("New Pokemon added with sucess to player: " + Frm_Login.ID);

            
        }
    }
}
