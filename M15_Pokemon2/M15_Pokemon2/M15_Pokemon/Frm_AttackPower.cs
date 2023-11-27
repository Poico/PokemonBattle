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
    public partial class Frm_AttackPower : Form
    {
        public Frm_AttackPower()
        {
            InitializeComponent();
        }
        BaseDados db = new BaseDados();
        private void Txt_Minimum_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Txt_Minimum.Text != "" && Txt_Max.Text != "")
                {
                    DataTable data = db.devolve_consulta("Select * From Moves Where AttackPower>" + Txt_Minimum.Text + "and AttackPower<" + Txt_Max.Text);
                    dataGridView1.DataSource = data;
                }
                else
                {
                    DataTable data = db.devolve_consulta("Select * From Moves Where AttackPower>" + Txt_Minimum.Text);
                    dataGridView1.DataSource = data;
                }
            }
            catch (Exception)
            {

                
            }
        }

        private void Txt_Max_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Txt_Minimum.Text != "" && Txt_Max.Text != "")
                {
                    DataTable data = db.devolve_consulta("Select * From Moves Where AttackPower>" + Txt_Minimum.Text + "and AttackPower<" + Txt_Max.Text);
                    dataGridView1.DataSource = data;
                }
                else
                {
                    DataTable data = db.devolve_consulta("Select * From Moves Where AttackPower>" + Txt_Minimum.Text);
                    dataGridView1.DataSource = data;
                }
            }
            catch (Exception)
            {


            }
        }
    }
}
