
namespace M15_Pokemon
{
    partial class Frm_PokeSearchGen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmb_Gen = new System.Windows.Forms.ComboBox();
            this.chk_NgenNum = new System.Windows.Forms.CheckBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_Gen
            // 
            this.cmb_Gen.FormattingEnabled = true;
            this.cmb_Gen.Location = new System.Drawing.Point(12, 12);
            this.cmb_Gen.Name = "cmb_Gen";
            this.cmb_Gen.Size = new System.Drawing.Size(121, 21);
            this.cmb_Gen.TabIndex = 0;
            this.cmb_Gen.SelectedIndexChanged += new System.EventHandler(this.cmb_Gen_SelectedIndexChanged);
            // 
            // chk_NgenNum
            // 
            this.chk_NgenNum.AutoSize = true;
            this.chk_NgenNum.Location = new System.Drawing.Point(708, 16);
            this.chk_NgenNum.Name = "chk_NgenNum";
            this.chk_NgenNum.Size = new System.Drawing.Size(74, 17);
            this.chk_NgenNum.TabIndex = 1;
            this.chk_NgenNum.Text = "NgenNum";
            this.chk_NgenNum.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 39);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 399);
            this.dataGridView1.TabIndex = 2;
            // 
            // Frm_PokeSearchGen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.chk_NgenNum);
            this.Controls.Add(this.cmb_Gen);
            this.Name = "Frm_PokeSearchGen";
            this.Text = "Frm_PokeSearchGen";
            this.Load += new System.EventHandler(this.Frm_PokeSearchGen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_Gen;
        private System.Windows.Forms.CheckBox chk_NgenNum;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}