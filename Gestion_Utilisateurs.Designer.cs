/*
 * Created by SharpDevelop.
 * User: bmd-tech
 * Date: 12/08/2023
 * Time: 13:06
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Projet_Resto
{
	partial class Gestion_Utilisateurs
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		//private System.Windows.Forms.Button SupprimerUser;
		private System.Windows.Forms.Button AnnulerUser;
		private System.Windows.Forms.Button ConfirmerUser;
		private System.Windows.Forms.TextBox PasswordUser;
		private System.Windows.Forms.TextBox NomUser;
		private System.Windows.Forms.TextBox PrenomUser;
		private System.Windows.Forms.TextBox LoginUSer;
		private System.Windows.Forms.ComboBox RoleUser;
		private System.Windows.Forms.Button Rechercher;
		//private System.Windows.Forms.Button Supprimer_User;
		private System.Windows.Forms.TextBox Matricule;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.DataGridView dataGridViewUser;
		private System.Windows.Forms.TextBox txtRecherche;
		private System.Windows.Forms.Button SupprimerUser;
		private System.Windows.Forms.Button button1;
		
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.SupprimerUser = new System.Windows.Forms.Button();
			this.Matricule = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.AnnulerUser = new System.Windows.Forms.Button();
			this.ConfirmerUser = new System.Windows.Forms.Button();
			this.PasswordUser = new System.Windows.Forms.TextBox();
			this.NomUser = new System.Windows.Forms.TextBox();
			this.PrenomUser = new System.Windows.Forms.TextBox();
			this.LoginUSer = new System.Windows.Forms.TextBox();
			this.RoleUser = new System.Windows.Forms.ComboBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.dataGridViewUser = new System.Windows.Forms.DataGridView();
			this.txtRecherche = new System.Windows.Forms.TextBox();
			this.Rechercher = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewUser)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.SupprimerUser);
			this.groupBox1.Controls.Add(this.Matricule);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.AnnulerUser);
			this.groupBox1.Controls.Add(this.ConfirmerUser);
			this.groupBox1.Controls.Add(this.PasswordUser);
			this.groupBox1.Controls.Add(this.NomUser);
			this.groupBox1.Controls.Add(this.PrenomUser);
			this.groupBox1.Controls.Add(this.LoginUSer);
			this.groupBox1.Controls.Add(this.RoleUser);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(984, 13);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(733, 769);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Ajouter/Modifier";
			this.groupBox1.Enter += new System.EventHandler(this.GroupBox1Enter);
			// 
			// SupprimerUser
			// 
			this.SupprimerUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SupprimerUser.Location = new System.Drawing.Point(534, 652);
			this.SupprimerUser.Name = "SupprimerUser";
			this.SupprimerUser.Size = new System.Drawing.Size(142, 42);
			this.SupprimerUser.TabIndex = 17;
			this.SupprimerUser.Text = "Supprimer";
			this.SupprimerUser.UseVisualStyleBackColor = true;
			this.SupprimerUser.Click += new System.EventHandler(this.Supprimer_Click);
			// 
			// Matricule
			// 
			this.Matricule.Location = new System.Drawing.Point(289, 183);
			this.Matricule.Name = "Matricule";
			this.Matricule.Size = new System.Drawing.Size(306, 26);
			this.Matricule.TabIndex = 16;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(59, 186);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 15;
			this.label3.Text = "Matricule";
			// 
			// AnnulerUser
			// 
			this.AnnulerUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.AnnulerUser.Location = new System.Drawing.Point(305, 652);
			this.AnnulerUser.Name = "AnnulerUser";
			this.AnnulerUser.Size = new System.Drawing.Size(134, 42);
			this.AnnulerUser.TabIndex = 14;
			this.AnnulerUser.Text = "Annuler";
			this.AnnulerUser.UseVisualStyleBackColor = true;
			this.AnnulerUser.Click += new System.EventHandler(this.Annuler_Click);
			// 
			// ConfirmerUser
			// 
			this.ConfirmerUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ConfirmerUser.Location = new System.Drawing.Point(59, 652);
			this.ConfirmerUser.Name = "ConfirmerUser";
			this.ConfirmerUser.Size = new System.Drawing.Size(129, 42);
			this.ConfirmerUser.TabIndex = 13;
			this.ConfirmerUser.Text = "Confirmer";
			this.ConfirmerUser.UseVisualStyleBackColor = true;
			this.ConfirmerUser.Click += new System.EventHandler(this.Confirmer_Click);
			// 
			// PasswordUser
			// 
			this.PasswordUser.Location = new System.Drawing.Point(289, 466);
			this.PasswordUser.Name = "PasswordUser";
			this.PasswordUser.PasswordChar = '*';
			this.PasswordUser.Size = new System.Drawing.Size(306, 26);
			this.PasswordUser.TabIndex = 12;
			// 
			// NomUser
			// 
			this.NomUser.Location = new System.Drawing.Point(289, 254);
			this.NomUser.Name = "NomUser";
			this.NomUser.Size = new System.Drawing.Size(306, 26);
			this.NomUser.TabIndex = 11;
			// 
			// PrenomUser
			// 
			this.PrenomUser.Location = new System.Drawing.Point(289, 331);
			this.PrenomUser.Name = "PrenomUser";
			this.PrenomUser.Size = new System.Drawing.Size(306, 26);
			this.PrenomUser.TabIndex = 10;
			// 
			// LoginUSer
			// 
			this.LoginUSer.Location = new System.Drawing.Point(289, 397);
			this.LoginUSer.Name = "LoginUSer";
			this.LoginUSer.Size = new System.Drawing.Size(306, 26);
			this.LoginUSer.TabIndex = 9;
			// 
			// RoleUser
			// 
			this.RoleUser.FormattingEnabled = true;
			this.RoleUser.Items.AddRange(new object[] {
			"Restaurateur",
			"Chef_Cuisinier"});
			this.RoleUser.Location = new System.Drawing.Point(366, 525);
			this.RoleUser.Name = "RoleUser";
			this.RoleUser.Size = new System.Drawing.Size(229, 28);
			this.RoleUser.TabIndex = 7;
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(59, 334);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(100, 23);
			this.label7.TabIndex = 6;
			this.label7.Text = "Prenom";
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(59, 400);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 35);
			this.label6.TabIndex = 5;
			this.label6.Text = "Login";
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(59, 469);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(120, 33);
			this.label5.TabIndex = 4;
			this.label5.Text = "Password";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(59, 530);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 3;
			this.label4.Text = "Role";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(59, 257);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Nom";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(255, 42);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(340, 74);
			this.label1.TabIndex = 0;
			this.label1.Text = "User Account";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// dataGridViewUser
			// 
			this.dataGridViewUser.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
			this.dataGridViewUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewUser.Location = new System.Drawing.Point(12, 98);
			this.dataGridViewUser.Name = "dataGridViewUser";
			this.dataGridViewUser.RowTemplate.Height = 28;
			this.dataGridViewUser.Size = new System.Drawing.Size(966, 609);
			this.dataGridViewUser.TabIndex = 1;
			// 
			// txtRecherche
			// 
			this.txtRecherche.Location = new System.Drawing.Point(12, 32);
			this.txtRecherche.Multiline = true;
			this.txtRecherche.Name = "txtRecherche";
			this.txtRecherche.Size = new System.Drawing.Size(600, 34);
			this.txtRecherche.TabIndex = 2;
			// 
			// Rechercher
			// 
			this.Rechercher.Location = new System.Drawing.Point(673, 32);
			this.Rechercher.Name = "Rechercher";
			this.Rechercher.Size = new System.Drawing.Size(200, 34);
			this.Rechercher.TabIndex = 3;
			this.Rechercher.Text = "Rechercher";
			this.Rechercher.UseVisualStyleBackColor = true;
			this.Rechercher.Click += new System.EventHandler(this.btnExecuterRecherche_Click);
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(430, 729);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(129, 42);
			this.button1.TabIndex = 14;
			this.button1.Text = "Modifier";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Modifier_Click);
			// 
			// Gestion_Utilisateurs
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
			this.ClientSize = new System.Drawing.Size(1729, 794);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.Rechercher);
			this.Controls.Add(this.txtRecherche);
			this.Controls.Add(this.dataGridViewUser);
			this.Name = "Gestion_Utilisateurs";
			this.Text = "Gestion_Utilisateurs";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewUser)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
