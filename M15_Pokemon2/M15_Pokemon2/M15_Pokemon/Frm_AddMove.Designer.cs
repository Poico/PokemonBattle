
namespace M15_Pokemon
{
    partial class Frm_AddMove
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Txt_Type = new System.Windows.Forms.TextBox();
            this.Txt_Effect = new System.Windows.Forms.TextBox();
            this.Txt_PP = new System.Windows.Forms.TextBox();
            this.Txt_AttackPower = new System.Windows.Forms.TextBox();
            this.Txt_Accuracy = new System.Windows.Forms.TextBox();
            this.Btn_Register = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Txt_Name = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Category";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Effect";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "PP";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "AttackPower";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Accuracy";
            // 
            // Txt_Type
            // 
            this.Txt_Type.Location = new System.Drawing.Point(49, 28);
            this.Txt_Type.Name = "Txt_Type";
            this.Txt_Type.Size = new System.Drawing.Size(100, 20);
            this.Txt_Type.TabIndex = 6;
            // 
            // Txt_Effect
            // 
            this.Txt_Effect.Location = new System.Drawing.Point(61, 73);
            this.Txt_Effect.Name = "Txt_Effect";
            this.Txt_Effect.Size = new System.Drawing.Size(300, 20);
            this.Txt_Effect.TabIndex = 8;
            // 
            // Txt_PP
            // 
            this.Txt_PP.Location = new System.Drawing.Point(39, 94);
            this.Txt_PP.Name = "Txt_PP";
            this.Txt_PP.Size = new System.Drawing.Size(100, 20);
            this.Txt_PP.TabIndex = 9;
            this.Txt_PP.TextChanged += new System.EventHandler(this.Txt_PP_TextChanged);
            // 
            // Txt_AttackPower
            // 
            this.Txt_AttackPower.Location = new System.Drawing.Point(86, 120);
            this.Txt_AttackPower.Name = "Txt_AttackPower";
            this.Txt_AttackPower.Size = new System.Drawing.Size(100, 20);
            this.Txt_AttackPower.TabIndex = 10;
            this.Txt_AttackPower.TextChanged += new System.EventHandler(this.Txt_AttackPower_TextChanged);
            // 
            // Txt_Accuracy
            // 
            this.Txt_Accuracy.Location = new System.Drawing.Point(70, 143);
            this.Txt_Accuracy.Name = "Txt_Accuracy";
            this.Txt_Accuracy.Size = new System.Drawing.Size(100, 20);
            this.Txt_Accuracy.TabIndex = 11;
            this.Txt_Accuracy.TextChanged += new System.EventHandler(this.Txt_Accuracy_TextChanged);
            // 
            // Btn_Register
            // 
            this.Btn_Register.Location = new System.Drawing.Point(5, 204);
            this.Btn_Register.Name = "Btn_Register";
            this.Btn_Register.Size = new System.Drawing.Size(75, 23);
            this.Btn_Register.TabIndex = 12;
            this.Btn_Register.Text = "Register";
            this.Btn_Register.UseVisualStyleBackColor = true;
            this.Btn_Register.Click += new System.EventHandler(this.Btn_Register_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Special",
            "Physical",
            "Status"});
            this.comboBox1.Location = new System.Drawing.Point(61, 50);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 13;
            // 
            // Txt_Name
            // 
            this.Txt_Name.Location = new System.Drawing.Point(49, 2);
            this.Txt_Name.Name = "Txt_Name";
            this.Txt_Name.Size = new System.Drawing.Size(100, 20);
            this.Txt_Name.TabIndex = 15;
            this.Txt_Name.TextChanged += new System.EventHandler(this.Txt_Name_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Name";
            // 
            // Frm_AddMove
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 233);
            this.Controls.Add(this.Txt_Name);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Btn_Register);
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
            this.Name = "Frm_AddMove";
            this.Text = "Frm_AddMove";
            this.Load += new System.EventHandler(this.Frm_AddMove_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Txt_Type;
        private System.Windows.Forms.TextBox Txt_Effect;
        private System.Windows.Forms.TextBox Txt_PP;
        private System.Windows.Forms.TextBox Txt_AttackPower;
        private System.Windows.Forms.TextBox Txt_Accuracy;
        private System.Windows.Forms.Button Btn_Register;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox Txt_Name;
        private System.Windows.Forms.Label label7;
    }
}