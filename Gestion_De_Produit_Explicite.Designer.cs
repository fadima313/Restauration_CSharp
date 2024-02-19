/*
 * Created by SharpDevelop.
 * User: bmd-tech
 * Date: 20/08/2023
 * Time: 14:57
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Projet_Resto
{
    partial class Gestion_De_Produit_Explicite
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

        private void InitializeComponent()
        {
        	System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gestion_De_Produit_Explicite));
        	this.labelNom = new System.Windows.Forms.Label();
        	this.labelPrix = new System.Windows.Forms.Label();
        	this.btnRafraichir = new System.Windows.Forms.Button();
        	this.pictureBox1 = new System.Windows.Forms.PictureBox();
        	this.TextBoxSearch = new System.Windows.Forms.TextBox();
        	this.panel1 = new System.Windows.Forms.Panel();
        	this.textBoxPrix = new System.Windows.Forms.TextBox();
        	this.label4 = new System.Windows.Forms.Label();
        	this.textboxNomProd = new System.Windows.Forms.TextBox();
        	this.label3 = new System.Windows.Forms.Label();
        	this.ButtonDelete = new System.Windows.Forms.Button();
        	this.label1 = new System.Windows.Forms.Label();
        	this.dgvProducts = new System.Windows.Forms.DataGridView();
        	this.button1 = new System.Windows.Forms.Button();
        	((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
        	this.panel1.SuspendLayout();
        	((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
        	this.SuspendLayout();
        	// 
        	// labelNom
        	// 
        	this.labelNom.AutoSize = true;
        	this.labelNom.Location = new System.Drawing.Point(20, 30);
        	this.labelNom.Name = "labelNom";
        	this.labelNom.Size = new System.Drawing.Size(35, 13);
        	this.labelNom.TabIndex = 0;
        	this.labelNom.Text = "Nom: ";
        	// 
        	// labelPrix
        	// 
        	this.labelPrix.AutoSize = true;
        	this.labelPrix.Location = new System.Drawing.Point(20, 60);
        	this.labelPrix.Name = "labelPrix";
        	this.labelPrix.Size = new System.Drawing.Size(33, 13);
        	this.labelPrix.TabIndex = 1;
        	this.labelPrix.Text = "Prix: ";
        	// 
        	// btnRafraichir
        	// 
        	this.btnRafraichir.BackColor = System.Drawing.Color.RosyBrown;
        	this.btnRafraichir.Location = new System.Drawing.Point(312, 25);
        	this.btnRafraichir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
        	this.btnRafraichir.Name = "btnRafraichir";
        	this.btnRafraichir.Size = new System.Drawing.Size(112, 35);
        	this.btnRafraichir.TabIndex = 18;
        	this.btnRafraichir.Text = "Rafraichir";
        	this.btnRafraichir.UseVisualStyleBackColor = false;
        	this.btnRafraichir.Click += new System.EventHandler(this.ButtonUpdate_Click);
        	// 
        	// pictureBox1
        	// 
        	this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
        	this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
        	this.pictureBox1.Location = new System.Drawing.Point(241, 20);
        	this.pictureBox1.Name = "pictureBox1";
        	this.pictureBox1.Size = new System.Drawing.Size(47, 40);
        	this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
        	this.pictureBox1.TabIndex = 16;
        	this.pictureBox1.TabStop = false;
        	// 
        	// TextBoxSearch
        	// 
        	this.TextBoxSearch.Location = new System.Drawing.Point(13, 20);
        	this.TextBoxSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
        	this.TextBoxSearch.Multiline = true;
        	this.TextBoxSearch.Name = "TextBoxSearch";
        	this.TextBoxSearch.Size = new System.Drawing.Size(275, 40);
        	this.TextBoxSearch.TabIndex = 12;
        	this.TextBoxSearch.TextChanged += new System.EventHandler(this.textboxSearch_TextChanged);
        	// 
        	// panel1
        	// 
        	this.panel1.BackColor = System.Drawing.Color.Orange;
        	this.panel1.Controls.Add(this.textBoxPrix);
        	this.panel1.Controls.Add(this.label4);
        	this.panel1.Controls.Add(this.textboxNomProd);
        	this.panel1.Controls.Add(this.label3);
        	this.panel1.Controls.Add(this.ButtonDelete);
        	this.panel1.Controls.Add(this.label1);
        	this.panel1.Location = new System.Drawing.Point(716, 0);
        	this.panel1.Name = "panel1";
        	this.panel1.Size = new System.Drawing.Size(433, 682);
        	this.panel1.TabIndex = 17;
        	// 
        	// textBoxPrix
        	// 
        	this.textBoxPrix.Location = new System.Drawing.Point(209, 355);
        	this.textBoxPrix.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
        	this.textBoxPrix.Multiline = true;
        	this.textBoxPrix.Name = "textBoxPrix";
        	this.textBoxPrix.Size = new System.Drawing.Size(206, 38);
        	this.textBoxPrix.TabIndex = 11;
        	// 
        	// label4
        	// 
        	this.label4.BackColor = System.Drawing.Color.Orange;
        	this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label4.Location = new System.Drawing.Point(19, 224);
        	this.label4.Name = "label4";
        	this.label4.Size = new System.Drawing.Size(173, 26);
        	this.label4.TabIndex = 10;
        	this.label4.Text = "Nom du Produit";
        	// 
        	// textboxNomProd
        	// 
        	this.textboxNomProd.Location = new System.Drawing.Point(209, 212);
        	this.textboxNomProd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
        	this.textboxNomProd.Multiline = true;
        	this.textboxNomProd.Name = "textboxNomProd";
        	this.textboxNomProd.Size = new System.Drawing.Size(206, 38);
        	this.textboxNomProd.TabIndex = 9;
        	// 
        	// label3
        	// 
        	this.label3.BackColor = System.Drawing.Color.Orange;
        	this.label3.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label3.Location = new System.Drawing.Point(47, 38);
        	this.label3.Name = "label3";
        	this.label3.Size = new System.Drawing.Size(368, 66);
        	this.label3.TabIndex = 8;
        	this.label3.Text = "Ajouter Produit";
        	this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        	// 
        	// ButtonDelete
        	// 
        	this.ButtonDelete.BackColor = System.Drawing.Color.RosyBrown;
        	this.ButtonDelete.Location = new System.Drawing.Point(167, 509);
        	this.ButtonDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
        	this.ButtonDelete.Name = "ButtonDelete";
        	this.ButtonDelete.Size = new System.Drawing.Size(112, 35);
        	this.ButtonDelete.TabIndex = 3;
        	this.ButtonDelete.Text = "Enregistrer";
        	this.ButtonDelete.UseVisualStyleBackColor = false;
        	this.ButtonDelete.Click += new System.EventHandler(this.ButtonAdd_Click);
        	// 
        	// label1
        	// 
        	this.label1.BackColor = System.Drawing.Color.Orange;
        	this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label1.Location = new System.Drawing.Point(19, 367);
        	this.label1.Name = "label1";
        	this.label1.Size = new System.Drawing.Size(191, 26);
        	this.label1.TabIndex = 7;
        	this.label1.Text = "Prix du Produit";
        	// 
        	// dgvProducts
        	// 
        	this.dgvProducts.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
        	this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        	this.dgvProducts.Location = new System.Drawing.Point(0, 102);
        	this.dgvProducts.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
        	this.dgvProducts.Name = "dgvProducts";
        	this.dgvProducts.Size = new System.Drawing.Size(723, 580);
        	this.dgvProducts.TabIndex = 15;
        	// 
        	// button1
        	// 
        	this.button1.BackColor = System.Drawing.Color.Aqua;
        	this.button1.Location = new System.Drawing.Point(597, 25);
        	this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
        	this.button1.Name = "button1";
        	this.button1.Size = new System.Drawing.Size(112, 35);
        	this.button1.TabIndex = 19;
        	this.button1.Text = "Supprimer";
        	this.button1.UseVisualStyleBackColor = false;
        	this.button1.Click += new System.EventHandler(this.ButtonDelete_Click);
        	// 
        	// Gestion_De_Produit_Explicite
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.ClientSize = new System.Drawing.Size(1144, 680);
        	this.Controls.Add(this.button1);
        	this.Controls.Add(this.btnRafraichir);
        	this.Controls.Add(this.pictureBox1);
        	this.Controls.Add(this.TextBoxSearch);
        	this.Controls.Add(this.panel1);
        	this.Controls.Add(this.dgvProducts);
        	this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
        	this.Name = "Gestion_De_Produit_Explicite";
        	this.Text = "Gestion De Produit Explicite";
        	((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
        	this.panel1.ResumeLayout(false);
        	this.panel1.PerformLayout();
        	((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
        	this.ResumeLayout(false);
        	this.PerformLayout();

        }

        private System.Windows.Forms.Label labelPrix;
        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.Button btnRafraichir;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox TextBoxSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textboxNomProd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ButtonDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxPrix;
    }
}
