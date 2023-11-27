
namespace M15_Pokemon
{
    partial class Frm_EditMove
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
            this.Txt_Name = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Btn_Update = new System.Windows.Forms.Button();
            this.Txt_ID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Special",
            "Physical",
            "Status"});
            this.comboBox1.Location = new System.Drawing.Point(61, 74);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 25;
            // 
            // Txt_Accuracy
            // 
            this.Txt_Accuracy.Location = new System.Drawing.Point(70, 167);
            this.Txt_Accuracy.Name = "Txt_Accuracy";
            this.Txt_Accuracy.Size = new System.Drawing.Size(100, 20);
            this.Txt_Accuracy.TabIndex = 24;
            // 
            // Txt_AttackPower
            // 
            this.Txt_AttackPower.Location = new System.Drawing.Point(86, 144);
            this.Txt_AttackPower.Name = "Txt_AttackPower";
            this.Txt_AttackPower.Size = new System.Drawing.Size(100, 20);
            this.Txt_AttackPower.TabIndex = 23;
            // 
            // Txt_PP
            // 
            this.Txt_PP.Location = new System.Drawing.Point(39, 118);
            this.Txt_PP.Name = "Txt_PP";
            this.Txt_PP.Size = new System.Drawing.Size(100, 20);
            this.Txt_PP.TabIndex = 22;
            // 
            // Txt_Effect
            // 
            this.Txt_Effect.Location = new System.Drawing.Point(61, 97);
            this.Txt_Effect.Name = "Txt_Effect";
            this.Txt_Effect.Size = new System.Drawing.Size(300, 20);
            this.Txt_Effect.TabIndex = 21;
            // 
            // Txt_Type
            // 
            this.Txt_Type.Location = new System.Drawing.Point(49, 52);
            this.Txt_Type.Name = "Txt_Type";
            this.Txt_Type.Size = new System.Drawing.Size(100, 20);
            this.Txt_Type.TabIndex = 20;
            this.Txt_Type.TextChanged += new System.EventHandler(this.Txt_Type_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Accuracy";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "AttackPower";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "PP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Effect";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Category";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Type";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Txt_Name
            // 
            this.Txt_Name.Location = new System.Drawing.Point(49, 27);
            this.Txt_Name.Name = "Txt_Name";
            this.Txt_Name.Size = new System.Drawing.Size(100, 20);
            this.Txt_Name.TabIndex = 27;
            this.Txt_Name.TextChanged += new System.EventHandler(this.Txt_Name_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Name";
            // 
            // Btn_Update
            // 
            this.Btn_Update.Location = new System.Drawing.Point(12, 222);
            this.Btn_Update.Name = "Btn_Update";
            this.Btn_Update.Size = new System.Drawing.Size(75, 23);
            this.Btn_Update.TabIndex = 28;
            this.Btn_Update.Text = "Update";
            this.Btn_Update.UseVisualStyleBackColor = true;
            this.Btn_Update.Click += new System.EventHandler(this.Btn_Update_Click);
            // 
            // Txt_ID
            // 
            this.Txt_ID.Location = new System.Drawing.Point(49, 5);
            this.Txt_ID.Name = "Txt_ID";
            this.Txt_ID.Size = new System.Drawing.Size(100, 20);
            this.Txt_ID.TabIndex = 30;
            this.Txt_ID.TextChanged += new System.EventHandler(this.Txt_ID_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 13);
            this.label8.TabIndex = 29;
            this.label8.Text = "ID";
            // 
            // Frm_EditMove
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 257);
            this.Controls.Add(this.Txt_ID);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Btn_Update);
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
            this.Name = "Frm_EditMove";
            this.Text = "Frm_EditMove";
            this.Load += new System.EventHandler(this.Frm_EditMove_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.TextBox Txt_Name;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Btn_Update;
        private System.Windows.Forms.TextBox Txt_ID;
        private System.Windows.Forms.Label label8;
    }
}