/*
 * Created by SharpDevelop.
 * User: bmd-tech
 * Date: 21/08/2023
 * Time: 00:43
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Projet_Resto
{
	partial class AutresProduits
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.DataGridView dgvNames;
		private System.Windows.Forms.Button btnAjoutProd;
		private System.Windows.Forms.TextBox textBoxSearch;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.dgvNames = new System.Windows.Forms.DataGridView();
			this.btnAjoutProd = new System.Windows.Forms.Button();
			this.textBoxSearch = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.dgvNames)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvNames
			// 
			this.dgvNames.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.dgvNames.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvNames.Location = new System.Drawing.Point(12, 85);
			this.dgvNames.Name = "dgvNames";
			this.dgvNames.RowTemplate.Height = 28;
			this.dgvNames.Size = new System.Drawing.Size(812, 545);
			this.dgvNames.TabIndex = 0;
			// 
			// btnAjoutProd
			// 
			this.btnAjoutProd.BackColor = System.Drawing.SystemColors.Desktop;
			this.btnAjoutProd.Location = new System.Drawing.Point(305, 645);
			this.btnAjoutProd.Name = "btnAjoutProd";
			this.btnAjoutProd.Size = new System.Drawing.Size(201, 45);
			this.btnAjoutProd.TabIndex = 1;
			this.btnAjoutProd.Text = "Ajouter";
			this.btnAjoutProd.UseVisualStyleBackColor = false;
			this.btnAjoutProd.Click += new System.EventHandler(this.ButtonAdd_Click);
			// 
			// textBoxSearch
			// 
			this.textBoxSearch.Location = new System.Drawing.Point(12, 22);
			this.textBoxSearch.Multiline = true;
			this.textBoxSearch.Name = "textBoxSearch";
			this.textBoxSearch.Size = new System.Drawing.Size(320, 43);
			this.textBoxSearch.TabIndex = 2;
			this.textBoxSearch.Click += new System.EventHandler(this.TextBoxSearch_TextChanged);
			// 
			// AutresProduits
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(836, 712);
			this.Controls.Add(this.textBoxSearch);
			this.Controls.Add(this.btnAjoutProd);
			this.Controls.Add(this.dgvNames);
			this.Name = "AutresProduits";
			this.Text = "AutresProduits";
			((System.ComponentModel.ISupportInitialize)(this.dgvNames)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
