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
using System.Data.SqlClient;

namespace M15_Pokemon
{
    public partial class Frm_Login : Form
    {
        public Frm_Login()
        {
            InitializeComponent();
        }
        static public string ID;
        private void button2_Click(object sender, EventArgs e)
        {
            string UserID = Txt_UserID.Text;
            string Password = Txt_Password.Text;

            try
            {
                BaseDados bd = new BaseDados();
                DataTable dados = bd.devolve_consulta("Select * from Players where Name='" + UserID + "' and Password='" + Password + "'");
                if (dados.Rows[0][1].ToString() ==UserID && dados.Rows[0][2].ToString() == Password)
                {
                    ID = dados.Rows[0][0].ToString();
                    MessageBox.Show("Logged with Success","Congratulation");
                }
                else
                {
                    MessageBox.Show("There was a problem with the login.\n Please Try again", "Error Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Txt_UserID.Text = "";
                    Txt_Password.Text = "";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("There was a problem with the login.\n Please Try again", "Error Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Txt_UserID.Text = "";
                Txt_Password.Text = "";
            }
            Frm_Menu frm = new Frm_Menu();
            this.Hide();
            frm.Show();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();

            string UserID = Txt_UserID.Text;
            string Password = Txt_Password.Text;

            BaseDados bd = new BaseDados();
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

            try
            {
                if (UserID != null && Password != null)
                {
                    string sqlText = "Insert into Players(Name,Password,Image)";
                    sqlText += " values (@Name,@Password,@Image)";
                    List<SqlParameter> parameters = new List<SqlParameter>();
                    parameters.Add(new SqlParameter("@Name", UserID));
                    parameters.Add(new SqlParameter("@Password", Password));
                    parameters.Add(new SqlParameter("@Image", dados));

                    bd.executa_SQL(sqlText, parameters);
                }
                MessageBox.Show("Player registered with success");
            }
            catch (Exception)
            {
                MessageBox.Show("There was a error registering the Player.\n Please Try again","Error Registering", MessageBoxButtons.OK,MessageBoxIcon.Error);
                throw;
            }
            
        }

        private void Frm_Login_Load(object sender, EventArgs e)
        {

        }
    }
}
