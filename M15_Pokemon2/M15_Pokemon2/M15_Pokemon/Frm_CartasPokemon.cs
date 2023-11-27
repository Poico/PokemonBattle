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
using System.Drawing.Printing;

namespace M15_Pokemon
{
    public partial class Frm_CartasPokemon : Form
    {
        public Frm_CartasPokemon()
        {
            InitializeComponent();
        }
        PictureBox[] pictureBox;
        DataTable dt;
        private void Frm_CartasPokemon_Load(object sender, EventArgs e)
        {
            BaseDados db = new BaseDados();
            string  SQLtext = "Select Image From Pokemons";
             dt = db.devolve_consulta(SQLtext);
            
            pictureBox = new PictureBox[dt.Rows.Count];
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                pictureBox[i] = new PictureBox();
                pictureBox[i].SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox[i].Location = new Point(200*i,100);
                pictureBox[i ].Width = 150;
                pictureBox[i ].Height = 200;
                byte[] imagem = (byte[])dt.Rows[i][0];
                var ms = new MemoryStream(imagem);
                Image imagem2 = Image.FromStream(ms);
                pictureBox[i].Image = imagem2;
                this.Controls.Add(pictureBox[i]);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += printDocument1_PrintPage;
            pd.Print();
        }
        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {
            
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                System.Drawing.Image img = pictureBox[i].Image;
                Point loc = new Point(100, 100);
                e.Graphics.DrawImage(img, loc);
            }

        }
    }
}
