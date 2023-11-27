using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace M15_Pokemon
{
    public partial class Frm_RemovePokemon : Form
    {
        public Frm_RemovePokemon()
        {
            InitializeComponent();
        }
        BaseDados db = new BaseDados();
        private void Frm_RemovePokemon_Load(object sender, EventArgs e)
        {
            
        }

        private void Txt_ID_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable data = db.devolve_consulta("Select * From Pokemons where ID='"+Txt_ID.Text+"'");
                Txt_Name.Text = data.Rows[0][1].ToString();
                Txt_Gen.Text = data.Rows[0][2].ToString();
                Txt_Height.Text= data.Rows[0][3].ToString();
                Txt_Weight.Text = data.Rows[0][4].ToString();
                Txt_Category.Text = data.Rows[0][5].ToString();
                Txt_Type1.Text = data.Rows[0][6].ToString();
                Txt_Type2.Text = data.Rows[0][7].ToString();
                Txt_Classification.Text = data.Rows[0][8].ToString();
                Txt_Habilities.Text = data.Rows[0][9].ToString();

                byte[] imagem = (byte[])data.Rows[0][11];
                var ms = new MemoryStream(imagem);
                Image imagem2 = Image.FromStream(ms);
                pictureBox1.Image=imagem2;
                Txt_Move1.Text = data.Rows[0][12].ToString();
                Txt_Move2.Text = data.Rows[0][13].ToString();
                Txt_Move3.Text = data.Rows[0][14].ToString();
                Txt_Move4.Text = data.Rows[0][15].ToString();
            }
            catch (Exception)
            {


            }
        }

        private void Btn_Remove_Click(object sender, EventArgs e)
        {
            try
            {
                db.devolve_consulta("DELETE FROM Pokemons WHERE ID=" + Txt_ID.Text);
                MessageBox.Show("Pokemon deleted with sucess");
            }
            catch (Exception)
            {
                MessageBox.Show("There was a error deleting the Pokemon.\n Please Try again", "Error Registering", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Txt_Name_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable data = db.devolve_consulta("Select * From Pokemons where Name='" + Txt_Name.Text + "'");
                Txt_ID.Text = data.Rows[0][0].ToString();
                Txt_Gen.Text = data.Rows[0][2].ToString();
                Txt_Height.Text = data.Rows[0][3].ToString();
                Txt_Weight.Text = data.Rows[0][4].ToString();
                Txt_Category.Text = data.Rows[0][5].ToString();
                Txt_Type1.Text = data.Rows[0][6].ToString();
                Txt_Type2.Text = data.Rows[0][7].ToString();
                Txt_Classification.Text = data.Rows[0][8].ToString();
                Txt_Habilities.Text = data.Rows[0][9].ToString();

                byte[] imagem = (byte[])data.Rows[0][10];
                var ms = new MemoryStream(imagem);
                Image imagem2 = Image.FromStream(ms);

                Txt_Move1.Text = data.Rows[0][11].ToString();
                Txt_Move2.Text = data.Rows[0][12].ToString();
                Txt_Move3.Text = data.Rows[0][13].ToString();
                Txt_Move4.Text = data.Rows[0][14].ToString();
            }
            catch (Exception)
            {


            }
        }
    }
}
