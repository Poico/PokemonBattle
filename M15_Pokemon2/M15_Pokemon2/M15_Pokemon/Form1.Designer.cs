
namespace M15_Pokemon
{
    partial class Frm_Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Menu));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.movesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addMoveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editMoveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeMoveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchMoveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moveIDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.typeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.attackPowerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pokemonsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addPokemonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removePokemonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updatePokemonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchPokemonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoryToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.typeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.allPokemonsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cartasPokemonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3});
            this.toolStrip1.Location = new System.Drawing.Point(126, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(687, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::M15_Pokemon.Properties.Resources.icons8_delete_50;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "-";
            this.toolStripButton1.ToolTipText = "Leave";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click_1);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::M15_Pokemon.Properties.Resources.icons8_minus_48;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "toolStripButton2";
            this.toolStripButton2.ToolTipText = "Minimize";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "toolStripButton3";
            this.toolStripButton3.ToolTipText = "Login/Register";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.movesToolStripMenuItem,
            this.pokemonsToolStripMenuItem,
            this.cartasPokemonToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(126, 503);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.Visible = false;
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // movesToolStripMenuItem
            // 
            this.movesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addMoveToolStripMenuItem,
            this.editMoveToolStripMenuItem,
            this.removeMoveToolStripMenuItem,
            this.searchMoveToolStripMenuItem});
            this.movesToolStripMenuItem.Name = "movesToolStripMenuItem";
            this.movesToolStripMenuItem.Size = new System.Drawing.Size(113, 19);
            this.movesToolStripMenuItem.Text = "Moves";
            // 
            // addMoveToolStripMenuItem
            // 
            this.addMoveToolStripMenuItem.Name = "addMoveToolStripMenuItem";
            this.addMoveToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.addMoveToolStripMenuItem.Text = "AddMove";
            this.addMoveToolStripMenuItem.Click += new System.EventHandler(this.addMoveToolStripMenuItem_Click);
            // 
            // editMoveToolStripMenuItem
            // 
            this.editMoveToolStripMenuItem.Name = "editMoveToolStripMenuItem";
            this.editMoveToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.editMoveToolStripMenuItem.Text = "EditMove";
            this.editMoveToolStripMenuItem.Click += new System.EventHandler(this.editMoveToolStripMenuItem_Click);
            // 
            // removeMoveToolStripMenuItem
            // 
            this.removeMoveToolStripMenuItem.Name = "removeMoveToolStripMenuItem";
            this.removeMoveToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.removeMoveToolStripMenuItem.Text = "RemoveMove";
            this.removeMoveToolStripMenuItem.Click += new System.EventHandler(this.removeMoveToolStripMenuItem_Click);
            // 
            // searchMoveToolStripMenuItem
            // 
            this.searchMoveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.moveIDToolStripMenuItem,
            this.typeToolStripMenuItem,
            this.categoryToolStripMenuItem,
            this.attackPowerToolStripMenuItem});
            this.searchMoveToolStripMenuItem.Name = "searchMoveToolStripMenuItem";
            this.searchMoveToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.searchMoveToolStripMenuItem.Text = "SearchMove";
            // 
            // moveIDToolStripMenuItem
            // 
            this.moveIDToolStripMenuItem.Name = "moveIDToolStripMenuItem";
            this.moveIDToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.moveIDToolStripMenuItem.Text = "MoveID";
            this.moveIDToolStripMenuItem.Click += new System.EventHandler(this.moveIDToolStripMenuItem_Click);
            // 
            // typeToolStripMenuItem
            // 
            this.typeToolStripMenuItem.Name = "typeToolStripMenuItem";
            this.typeToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.typeToolStripMenuItem.Text = "Type";
            this.typeToolStripMenuItem.Click += new System.EventHandler(this.typeToolStripMenuItem_Click);
            // 
            // categoryToolStripMenuItem
            // 
            this.categoryToolStripMenuItem.Name = "categoryToolStripMenuItem";
            this.categoryToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.categoryToolStripMenuItem.Text = "Category";
            this.categoryToolStripMenuItem.Click += new System.EventHandler(this.categoryToolStripMenuItem_Click);
            // 
            // attackPowerToolStripMenuItem
            // 
            this.attackPowerToolStripMenuItem.Name = "attackPowerToolStripMenuItem";
            this.attackPowerToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.attackPowerToolStripMenuItem.Text = "AttackPower";
            this.attackPowerToolStripMenuItem.Click += new System.EventHandler(this.attackPowerToolStripMenuItem_Click);
            // 
            // pokemonsToolStripMenuItem
            // 
            this.pokemonsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addPokemonToolStripMenuItem,
            this.removePokemonToolStripMenuItem,
            this.updatePokemonToolStripMenuItem,
            this.searchPokemonToolStripMenuItem});
            this.pokemonsToolStripMenuItem.Name = "pokemonsToolStripMenuItem";
            this.pokemonsToolStripMenuItem.Size = new System.Drawing.Size(113, 19);
            this.pokemonsToolStripMenuItem.Text = "Pokemons";
            // 
            // addPokemonToolStripMenuItem
            // 
            this.addPokemonToolStripMenuItem.Name = "addPokemonToolStripMenuItem";
            this.addPokemonToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addPokemonToolStripMenuItem.Text = "AddPokemon";
            this.addPokemonToolStripMenuItem.Click += new System.EventHandler(this.addPokemonToolStripMenuItem_Click);
            // 
            // removePokemonToolStripMenuItem
            // 
            this.removePokemonToolStripMenuItem.Name = "removePokemonToolStripMenuItem";
            this.removePokemonToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.removePokemonToolStripMenuItem.Text = "RemovePokemon";
            this.removePokemonToolStripMenuItem.Click += new System.EventHandler(this.removePokemonToolStripMenuItem_Click);
            // 
            // updatePokemonToolStripMenuItem
            // 
            this.updatePokemonToolStripMenuItem.Name = "updatePokemonToolStripMenuItem";
            this.updatePokemonToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.updatePokemonToolStripMenuItem.Text = "UpdatePokemon";
            this.updatePokemonToolStripMenuItem.Click += new System.EventHandler(this.updatePokemonToolStripMenuItem_Click);
            // 
            // searchPokemonToolStripMenuItem
            // 
            this.searchPokemonToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nameToolStripMenuItem,
            this.generationToolStripMenuItem,
            this.categoryToolStripMenuItem1,
            this.typeToolStripMenuItem1,
            this.allPokemonsToolStripMenuItem});
            this.searchPokemonToolStripMenuItem.Name = "searchPokemonToolStripMenuItem";
            this.searchPokemonToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.searchPokemonToolStripMenuItem.Text = "SearchPokemon";
            // 
            // nameToolStripMenuItem
            // 
            this.nameToolStripMenuItem.Name = "nameToolStripMenuItem";
            this.nameToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.nameToolStripMenuItem.Text = "Name";
            this.nameToolStripMenuItem.Click += new System.EventHandler(this.nameToolStripMenuItem_Click);
            // 
            // generationToolStripMenuItem
            // 
            this.generationToolStripMenuItem.Name = "generationToolStripMenuItem";
            this.generationToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.generationToolStripMenuItem.Text = "Generation";
            this.generationToolStripMenuItem.Click += new System.EventHandler(this.generationToolStripMenuItem_Click);
            // 
            // categoryToolStripMenuItem1
            // 
            this.categoryToolStripMenuItem1.Name = "categoryToolStripMenuItem1";
            this.categoryToolStripMenuItem1.Size = new System.Drawing.Size(144, 22);
            this.categoryToolStripMenuItem1.Text = "Category";
            this.categoryToolStripMenuItem1.Click += new System.EventHandler(this.categoryToolStripMenuItem1_Click);
            // 
            // typeToolStripMenuItem1
            // 
            this.typeToolStripMenuItem1.Name = "typeToolStripMenuItem1";
            this.typeToolStripMenuItem1.Size = new System.Drawing.Size(144, 22);
            this.typeToolStripMenuItem1.Text = "Type";
            this.typeToolStripMenuItem1.Click += new System.EventHandler(this.typeToolStripMenuItem1_Click);
            // 
            // allPokemonsToolStripMenuItem
            // 
            this.allPokemonsToolStripMenuItem.Name = "allPokemonsToolStripMenuItem";
            this.allPokemonsToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.allPokemonsToolStripMenuItem.Text = "AllPokemons";
            this.allPokemonsToolStripMenuItem.Click += new System.EventHandler(this.allPokemonsToolStripMenuItem_Click);
            // 
            // cartasPokemonToolStripMenuItem
            // 
            this.cartasPokemonToolStripMenuItem.Name = "cartasPokemonToolStripMenuItem";
            this.cartasPokemonToolStripMenuItem.Size = new System.Drawing.Size(113, 19);
            this.cartasPokemonToolStripMenuItem.Text = "CartasPokemon";
            this.cartasPokemonToolStripMenuItem.Click += new System.EventHandler(this.cartasPokemonToolStripMenuItem_Click);
            // 
            // Frm_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::M15_Pokemon.Properties.Resources.wallhaven_3k3kyy;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(813, 503);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Frm_Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Frm_Menu_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem movesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addMoveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editMoveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeMoveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchMoveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moveIDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem typeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem attackPowerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pokemonsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addPokemonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removePokemonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updatePokemonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchPokemonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoryToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem typeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem allPokemonsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cartasPokemonToolStripMenuItem;
    }
}

