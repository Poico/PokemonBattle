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
    public partial class Frm_Menu : Form
    {
        public Frm_Menu()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Frm_Login frm = new Frm_Login();
            this.Hide();
            frm.Show();
            
        }

        private void Frm_Menu_Load(object sender, EventArgs e)
        {

            try
            {
                BaseDados bd = new BaseDados();
                DataTable dados = bd.devolve_consulta("Select * from Players where CharacterID='" + Frm_Login.ID + "'");
                if (dados.Rows[0][0] != null)
                {
                    menuStrip1.Visible = true;
                }
                byte[] imagem = (byte[])dados.Rows[0][3];
                var ms = new MemoryStream(imagem);
                Image imagem2=Image.FromStream(ms);
                
                toolStripButton3.Image = imagem2;
            }
            catch (Exception)
            {

                
            }
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void categoryToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frm_PokeSearchCategory frm_PokeSearchCategory = new Frm_PokeSearchCategory();
            frm_PokeSearchCategory.Show();
        }

        private void addMoveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_AddMove frm = new Frm_AddMove();
            frm.Show();
        }

        private void editMoveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_EditMove frm = new Frm_EditMove();
            frm.Show();
        }

        private void removeMoveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_RemoveMove frm = new Frm_RemoveMove();
            frm.Show();
        }

        private void moveIDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_SearchMoveID frm = new Frm_SearchMoveID();
            frm.Show();
        }

        private void typeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_SearchMoveType frm = new Frm_SearchMoveType();
            frm.Show();
        }

        private void categoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_SearchCategory frm = new Frm_SearchCategory();
            frm.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void attackPowerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_AttackPower frm = new Frm_AttackPower();
            frm.Show();
        }

        private void addPokemonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_AddPokemon frm = new Frm_AddPokemon();
            frm.Show();
        }

        private void removePokemonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_RemovePokemon frm = new Frm_RemovePokemon();
            frm.Show();
        }

        private void updatePokemonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_UpdatePokemon frm = new Frm_UpdatePokemon();
            frm.Show();
        }

        private void nameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_PokeNameSearch frm = new Frm_PokeNameSearch();
            frm.Show();
        }

        private void typeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frm_PokeSearchType frm_PokeSearchType = new Frm_PokeSearchType();
            frm_PokeSearchType.Show();
        }

        private void generationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_PokeSearchGen frm_PokeSearchGen = new Frm_PokeSearchGen();
            frm_PokeSearchGen.Show();
        }

        private void allPokemonsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_PokeTudo frm_PokeTudo = new Frm_PokeTudo();
            frm_PokeTudo.Show();
        }

        private void cartasPokemonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_CartasPokemon frm_CartasPokemon = new Frm_CartasPokemon();
            frm_CartasPokemon.Show();
        }
    }
}
