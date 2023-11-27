
namespace M15_Pokemon
{
    partial class Frm_RemoveMove
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
            this.Txt_ID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Btn_Delete = new System.Windows.Forms.Button();
            this.Txt_Name = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Txt_Accuracy = new System.Windows.Forms.TextBox();
            this.Txt_AttackPower = new System.Windows.Forms.TextBox();
            this.Txt_PP = new System.Windows.Forms.TextBox();
            this.Txt_Effect = new System.Windows.Forms.TextBox();
            this.Txt_Type = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Txt_ID
            // 
            this.Txt_ID.Location = new System.Drawing.Point(46, 6);
            this.Txt_ID.Name = "Txt_ID";
            this.Txt_ID.Size = new System.Drawing.Size(100, 20);
            this.Txt_ID.TabIndex = 47;
            this.Txt_ID.TextChanged += new System.EventHandler(this.Txt_ID_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 13);
            this.label8.TabIndex = 46;
            this.label8.Text = "ID";
            // 
            // Btn_Delete
            // 
            this.Btn_Delete.Location = new System.Drawing.Point(9, 223);
            this.Btn_Delete.Name = "Btn_Delete";
            this.Btn_Delete.Size = new System.Drawing.Size(75, 23);
            this.Btn_Delete.TabIndex = 45;
            this.Btn_Delete.Text = "Delete";
            this.Btn_Delete.UseVisualStyleBackColor = true;
            this.Btn_Delete.Click += new System.EventHandler(this.Btn_Delete_Click);
            // 
            // Txt_Name
            // 
            this.Txt_Name.Location = new System.Drawing.Point(46, 28);
            this.Txt_Name.Name = "Txt_Name";
            this.Txt_Name.Size = new System.Drawing.Size(100, 20);
            this.Txt_Name.TabIndex = 44;
            this.Txt_Name.TextChanged += new System.EventHandler(this.Txt_Name_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 43;
            this.label7.Text = "Name";
            // 
            // comboBox1
            // 
            this.comboBox1.Enabled = false;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Special",
            "Physical",
            "Status"});
            this.comboBox1.Location = new System.Drawing.Point(58, 75);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 42;
            // 
            // Txt_Accuracy
            // 
            this.Txt_Accuracy.Enabled = false;
            this.Txt_Accuracy.Location = new System.Drawing.Point(67, 168);
            this.Txt_Accuracy.Name = "Txt_Accuracy";
            this.Txt_Accuracy.Size = new System.Drawing.Size(100, 20);
            this.Txt_Accuracy.TabIndex = 41;
            // 
            // Txt_AttackPower
            // 
            this.Txt_AttackPower.Enabled = false;
            this.Txt_AttackPower.Location = new System.Drawing.Point(83, 145);
            this.Txt_AttackPower.Name = "Txt_AttackPower";
            this.Txt_AttackPower.Size = new System.Drawing.Size(100, 20);
            this.Txt_AttackPower.TabIndex = 40;
            // 
            // Txt_PP
            // 
            this.Txt_PP.Enabled = false;
            this.Txt_PP.Location = new System.Drawing.Point(36, 119);
            this.Txt_PP.Name = "Txt_PP";
            this.Txt_PP.Size = new System.Drawing.Size(100, 20);
            this.Txt_PP.TabIndex = 39;
            // 
            // Txt_Effect
            // 
            this.Txt_Effect.Enabled = false;
            this.Txt_Effect.Location = new System.Drawing.Point(58, 98);
            this.Txt_Effect.Name = "Txt_Effect";
            this.Txt_Effect.Size = new System.Drawing.Size(300, 20);
            this.Txt_Effect.TabIndex = 38;
            // 
            // Txt_Type
            // 
            this.Txt_Type.Enabled = false;
            this.Txt_Type.Location = new System.Drawing.Point(46, 53);
            this.Txt_Type.Name = "Txt_Type";
            this.Txt_Type.Size = new System.Drawing.Size(100, 20);
            this.Txt_Type.TabIndex = 37;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 36;
            this.label6.Text = "Accuracy";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 35;
            this.label5.Text = "AttackPower";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "PP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "Effect";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Category";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Type";
            // 
            // Frm_RemoveMove
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 247);
            this.Controls.Add(this.Txt_ID);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Btn_Delete);
            this.Controls.Add(this.Txt_Name);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Txt_Accuracy);
            this.Controls.Add(this.Txt_AttackPower);
            this.Controls.Add(this.Txt_PP);
            this.Controls.Add(this.Txt_Effect);
            this.Controls.Add(this.Txt_Type);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Frm_RemoveMove";
            this.Text = "Frm_RemoveMove";
            this.Load += new System.EventHandler(this.Frm_RemoveMove_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_ID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button Btn_Delete;
        private System.Windows.Forms.TextBox Txt_Name;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox Txt_Accuracy;
        private System.Windows.Forms.TextBox Txt_AttackPower;
        private System.Windows.Forms.TextBox Txt_PP;
        private System.Windows.Forms.TextBox Txt_Effect;
        private System.Windows.Forms.TextBox Txt_Type;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}