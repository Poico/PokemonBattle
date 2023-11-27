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
    public partial class Frm_PokeTudo : Form
    {
        BaseDados db = new BaseDados();
        public Frm_PokeTudo()
        {
            InitializeComponent();
        }

        private void Frm_PokeTudo_Load(object sender, EventArgs e)
        {
            DataTable data = db.devolve_consulta("Select ID,Pokemons.Name,Gen,Height,Weight,Pokemons.Category,Type1,Type2,Classification,Habilities,FoundDate,Players.Name,Moves.Name as Ataque From Pokemons Inner join Players ON Pokemons.CharacterID = Players.CharacterID Inner join Moves ON Pokemons.MoveID1 = Moves.MoveID");
            dataGridView1.DataSource = data;
        }
    }
}
