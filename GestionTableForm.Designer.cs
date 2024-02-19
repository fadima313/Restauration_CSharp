/*
 * Created by SharpDevelop.
 * User: bmd-tech
 * Date: 13/08/2023
 * Time: 10:41
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Projet_Resto
{
    partial class GestionTableForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
        	System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionTableForm));
        	this.TextBoxGuest = new System.Windows.Forms.TextBox();
        	this.TextBoxTable = new System.Windows.Forms.TextBox();
        	this.TextBoxSearch = new System.Windows.Forms.TextBox();
        	this.ButtonDelete = new System.Windows.Forms.Button();
        	this.ButtonReturn = new System.Windows.Forms.Button();
        	this.ButtonSave = new System.Windows.Forms.Button();
        	this.dgvTables = new System.Windows.Forms.DataGridView();
        	this.label1 = new System.Windows.Forms.Label();
        	this.label2 = new System.Windows.Forms.Label();
        	this.pictureBox1 = new System.Windows.Forms.PictureBox();
        	this.panel1 = new System.Windows.Forms.Panel();
        	this.label6 = new System.Windows.Forms.Label();
        	this.Date = new System.Windows.Forms.TextBox();
        	this.label5 = new System.Windows.Forms.Label();
        	this.ID = new System.Windows.Forms.TextBox();
        	this.label4 = new System.Windows.Forms.Label();
        	this.Nom_table = new System.Windows.Forms.TextBox();
        	this.label3 = new System.Windows.Forms.Label();
        	this.button1 = new System.Windows.Forms.Button();
        	((System.ComponentModel.ISupportInitialize)(this.dgvTables)).BeginInit();
        	((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
        	this.panel1.SuspendLayout();
        	this.SuspendLayout();
        	// 
        	// TextBoxGuest
        	// 
        	this.TextBoxGuest.Location = new System.Drawing.Point(270, 352);
        	this.TextBoxGuest.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
        	this.TextBoxGuest.Multiline = true;
        	this.TextBoxGuest.Name = "TextBoxGuest";
        	this.TextBoxGuest.Size = new System.Drawing.Size(206, 37);
        	this.TextBoxGuest.TabIndex = 0;
        	// 
        	// TextBoxTable
        	// 
        	this.TextBoxTable.Location = new System.Drawing.Point(270, 278);
        	this.TextBoxTable.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
        	this.TextBoxTable.Multiline = true;
        	this.TextBoxTable.Name = "TextBoxTable";
        	this.TextBoxTable.Size = new System.Drawing.Size(206, 38);
        	this.TextBoxTable.TabIndex = 1;
        	// 
        	// TextBoxSearch
        	// 
        	this.TextBoxSearch.Location = new System.Drawing.Point(8, 33);
        	this.TextBoxSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
        	this.TextBoxSearch.Multiline = true;
        	this.TextBoxSearch.Name = "TextBoxSearch";
        	this.TextBoxSearch.Size = new System.Drawing.Size(329, 40);
        	this.TextBoxSearch.TabIndex = 2;
        	this.TextBoxSearch.TextChanged += new System.EventHandler(this.TextBoxSearchTextChanged);
        	// 
        	// ButtonDelete
        	// 
        	this.ButtonDelete.BackColor = System.Drawing.Color.RosyBrown;
        	this.ButtonDelete.Location = new System.Drawing.Point(222, 568);
        	this.ButtonDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
        	this.ButtonDelete.Name = "ButtonDelete";
        	this.ButtonDelete.Size = new System.Drawing.Size(112, 35);
        	this.ButtonDelete.TabIndex = 3;
        	this.ButtonDelete.Text = "Supprimer";
        	this.ButtonDelete.UseVisualStyleBackColor = false;
        	this.ButtonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
        	// 
        	// ButtonReturn
        	// 
        	this.ButtonReturn.BackColor = System.Drawing.Color.RosyBrown;
        	this.ButtonReturn.Location = new System.Drawing.Point(603, 626);
        	this.ButtonReturn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
        	this.ButtonReturn.Name = "ButtonReturn";
        	this.ButtonReturn.Size = new System.Drawing.Size(112, 35);
        	this.ButtonReturn.TabIndex = 4;
        	this.ButtonReturn.Text = "Retour";
        	this.ButtonReturn.UseVisualStyleBackColor = false;
        	this.ButtonReturn.Click += new System.EventHandler(this.ButtonReturn_Click);
        	// 
        	// ButtonSave
        	// 
        	this.ButtonSave.BackColor = System.Drawing.Color.RosyBrown;
        	this.ButtonSave.Location = new System.Drawing.Point(228, 626);
        	this.ButtonSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
        	this.ButtonSave.Name = "ButtonSave";
        	this.ButtonSave.Size = new System.Drawing.Size(109, 35);
        	this.ButtonSave.TabIndex = 5;
        	this.ButtonSave.Text = "Details";
        	this.ButtonSave.UseVisualStyleBackColor = false;
        	this.ButtonSave.Click += new System.EventHandler(this.ButtonDetail_Click);
        	// 
        	// dgvTables
        	// 
        	this.dgvTables.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
        	this.dgvTables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        	this.dgvTables.Location = new System.Drawing.Point(8, 105);
        	this.dgvTables.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
        	this.dgvTables.Name = "dgvTables";
        	this.dgvTables.Size = new System.Drawing.Size(956, 477);
        	this.dgvTables.TabIndex = 6;
        	this.dgvTables.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTables_CellDoubleClick);
        	// 
        	// label1
        	// 
        	this.label1.BackColor = System.Drawing.Color.Orange;
        	this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label1.Location = new System.Drawing.Point(19, 290);
        	this.label1.Name = "label1";
        	this.label1.Size = new System.Drawing.Size(191, 26);
        	this.label1.TabIndex = 7;
        	this.label1.Text = "Number of the Table";
        	// 
        	// label2
        	// 
        	this.label2.BackColor = System.Drawing.Color.Orange;
        	this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label2.Location = new System.Drawing.Point(19, 363);
        	this.label2.Name = "label2";
        	this.label2.Size = new System.Drawing.Size(163, 26);
        	this.label2.TabIndex = 8;
        	this.label2.Text = "Number of Guest";
        	// 
        	// pictureBox1
        	// 
        	this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
        	this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
        	this.pictureBox1.Location = new System.Drawing.Point(290, 33);
        	this.pictureBox1.Name = "pictureBox1";
        	this.pictureBox1.Size = new System.Drawing.Size(47, 40);
        	this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
        	this.pictureBox1.TabIndex = 9;
        	this.pictureBox1.TabStop = false;
        	// 
        	// panel1
        	// 
        	this.panel1.BackColor = System.Drawing.Color.Orange;
        	this.panel1.Controls.Add(this.label6);
        	this.panel1.Controls.Add(this.Date);
        	this.panel1.Controls.Add(this.label5);
        	this.panel1.Controls.Add(this.ID);
        	this.panel1.Controls.Add(this.label4);
        	this.panel1.Controls.Add(this.Nom_table);
        	this.panel1.Controls.Add(this.label3);
        	this.panel1.Controls.Add(this.ButtonDelete);
        	this.panel1.Controls.Add(this.label2);
        	this.panel1.Controls.Add(this.label1);
        	this.panel1.Controls.Add(this.TextBoxTable);
        	this.panel1.Controls.Add(this.TextBoxGuest);
        	this.panel1.Location = new System.Drawing.Point(963, 0);
        	this.panel1.Name = "panel1";
        	this.panel1.Size = new System.Drawing.Size(530, 707);
        	this.panel1.TabIndex = 10;
        	// 
        	// label6
        	// 
        	this.label6.BackColor = System.Drawing.Color.Orange;
        	this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label6.Location = new System.Drawing.Point(19, 441);
        	this.label6.Name = "label6";
        	this.label6.Size = new System.Drawing.Size(163, 26);
        	this.label6.TabIndex = 14;
        	this.label6.Text = "Date of Save";
        	// 
        	// Date
        	// 
        	this.Date.Location = new System.Drawing.Point(270, 430);
        	this.Date.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
        	this.Date.Multiline = true;
        	this.Date.Name = "Date";
        	this.Date.Size = new System.Drawing.Size(206, 37);
        	this.Date.TabIndex = 13;
        	// 
        	// label5
        	// 
        	this.label5.BackColor = System.Drawing.Color.Orange;
        	this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label5.Location = new System.Drawing.Point(19, 153);
        	this.label5.Name = "label5";
        	this.label5.Size = new System.Drawing.Size(109, 26);
        	this.label5.TabIndex = 12;
        	this.label5.Text = "ID";
        	// 
        	// ID
        	// 
        	this.ID.Location = new System.Drawing.Point(270, 141);
        	this.ID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
        	this.ID.Multiline = true;
        	this.ID.Name = "ID";
        	this.ID.Size = new System.Drawing.Size(206, 38);
        	this.ID.TabIndex = 11;
        	// 
        	// label4
        	// 
        	this.label4.BackColor = System.Drawing.Color.Orange;
        	this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label4.Location = new System.Drawing.Point(19, 224);
        	this.label4.Name = "label4";
        	this.label4.Size = new System.Drawing.Size(173, 26);
        	this.label4.TabIndex = 10;
        	this.label4.Text = "Name of the table";
        	// 
        	// Nom_table
        	// 
        	this.Nom_table.Location = new System.Drawing.Point(270, 212);
        	this.Nom_table.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
        	this.Nom_table.Multiline = true;
        	this.Nom_table.Name = "Nom_table";
        	this.Nom_table.Size = new System.Drawing.Size(206, 38);
        	this.Nom_table.TabIndex = 9;
        	// 
        	// label3
        	// 
        	this.label3.BackColor = System.Drawing.Color.Orange;
        	this.label3.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label3.Location = new System.Drawing.Point(89, 57);
        	this.label3.Name = "label3";
        	this.label3.Size = new System.Drawing.Size(368, 66);
        	this.label3.TabIndex = 8;
        	this.label3.Text = "Table Information";
        	// 
        	// button1
        	// 
        	this.button1.BackColor = System.Drawing.Color.RosyBrown;
        	this.button1.Location = new System.Drawing.Point(426, 33);
        	this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
        	this.button1.Name = "button1";
        	this.button1.Size = new System.Drawing.Size(112, 35);
        	this.button1.TabIndex = 11;
        	this.button1.Text = "Rafraichir";
        	this.button1.UseVisualStyleBackColor = false;
        	this.button1.Click += new System.EventHandler(this.ButtonUpdate_Click);
        	// 
        	// GestionTableForm
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.BackColor = System.Drawing.SystemColors.ActiveCaption;
        	this.ClientSize = new System.Drawing.Size(1490, 702);
        	this.Controls.Add(this.button1);
        	this.Controls.Add(this.pictureBox1);
        	this.Controls.Add(this.TextBoxSearch);
        	this.Controls.Add(this.panel1);
        	this.Controls.Add(this.ButtonReturn);
        	this.Controls.Add(this.dgvTables);
        	this.Controls.Add(this.ButtonSave);
        	this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
        	this.Name = "GestionTableForm";
        	this.Text = "Gestion des Tables";
        	((System.ComponentModel.ISupportInitialize)(this.dgvTables)).EndInit();
        	((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
        	this.panel1.ResumeLayout(false);
        	this.panel1.PerformLayout();
        	this.ResumeLayout(false);
        	this.PerformLayout();

        }

        #endregion

       // private System.Windows.Forms.TextBox TextBoxGuest;
       // private System.Windows.Forms.TextBox TextBoxTable;
        private System.Windows.Forms.TextBox TextBoxSearch;
        private System.Windows.Forms.Button ButtonDelete;
        private System.Windows.Forms.Button ButtonReturn;
        private System.Windows.Forms.Button ButtonSave;
        //private System.Windows.Forms.DataGridView dgvTables;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
       // private System.Windows.Forms.TextBox Date;
        private System.Windows.Forms.Label label5;
        //private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.Label label4;
       // private System.Windows.Forms.TextBox Nom_table;
    }
}

