/*
 * Created by SharpDevelop.
 * User: bmd-tech
 * Date: 12/08/2023
 * Time: 10:51
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Projet_Resto
{
	partial class Authentification
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox Login;
		private System.Windows.Forms.TextBox Password;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button Confirmer;
		private System.Windows.Forms.Button Annuler;
		private System.Windows.Forms.Button oublier;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Authentification));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.Login = new System.Windows.Forms.TextBox();
			this.Password = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.Confirmer = new System.Windows.Forms.Button();
			this.Annuler = new System.Windows.Forms.Button();
			this.oublier = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(0, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(463, 732);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.DarkSeaGreen;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(85, 103);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(355, 73);
			this.label1.TabIndex = 1;
			this.label1.Text = "Connectez-Vous";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label1.Click += new System.EventHandler(this.Label1Click);
			// 
			// Login
			// 
			this.Login.Location = new System.Drawing.Point(530, 292);
			this.Login.Multiline = true;
			this.Login.Name = "Login";
			this.Login.Size = new System.Drawing.Size(408, 37);
			this.Login.TabIndex = 2;
			// 
			// Password
			// 
			this.Password.Location = new System.Drawing.Point(530, 454);
			this.Password.Multiline = true;
			this.Password.Name = "Password";
			this.Password.PasswordChar = '*';
			this.Password.Size = new System.Drawing.Size(408, 36);
			this.Password.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.DarkSeaGreen;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(530, 254);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(132, 35);
			this.label2.TabIndex = 4;
			this.label2.Text = "Login";
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.DarkSeaGreen;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(530, 416);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(132, 35);
			this.label3.TabIndex = 5;
			this.label3.Text = "Password";
			// 
			// Confirmer
			// 
			this.Confirmer.BackColor = System.Drawing.Color.LightGray;
			this.Confirmer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Confirmer.Location = new System.Drawing.Point(72, 622);
			this.Confirmer.Name = "Confirmer";
			this.Confirmer.Size = new System.Drawing.Size(132, 37);
			this.Confirmer.TabIndex = 6;
			this.Confirmer.Text = "Confirmer";
			this.Confirmer.UseVisualStyleBackColor = false;
			this.Confirmer.Click += new System.EventHandler(this.LoginButton_Click);
			// 
			// Annuler
			// 
			this.Annuler.BackColor = System.Drawing.Color.LightGray;
			this.Annuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
			this.Annuler.Location = new System.Drawing.Point(355, 622);
			this.Annuler.Name = "Annuler";
			this.Annuler.Size = new System.Drawing.Size(125, 37);
			this.Annuler.TabIndex = 7;
			this.Annuler.Text = "Annuler";
			this.Annuler.UseVisualStyleBackColor = false;
			this.Annuler.Click += new System.EventHandler(this.AnnulerButton_Click);
			// 
			// oublier
			// 
			this.oublier.BackColor = System.Drawing.Color.DarkSeaGreen;
			this.oublier.FlatAppearance.BorderSize = 0;
			this.oublier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.oublier.Location = new System.Drawing.Point(299, 525);
			this.oublier.Name = "oublier";
			this.oublier.Size = new System.Drawing.Size(181, 32);
			this.oublier.TabIndex = 8;
			this.oublier.Text = "Mot de passe oublié ?";
			this.oublier.UseVisualStyleBackColor = false;
			this.oublier.Click += new System.EventHandler(this.BoutonOubli_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.DarkSeaGreen;
			this.groupBox1.Controls.Add(this.oublier);
			this.groupBox1.Controls.Add(this.Annuler);
			this.groupBox1.Controls.Add(this.Confirmer);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(458, 0);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(574, 786);
			this.groupBox1.TabIndex = 9;
			this.groupBox1.TabStop = false;
			// 
			// Authentification
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.ClientSize = new System.Drawing.Size(1029, 728);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.Password);
			this.Controls.Add(this.Login);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.pictureBox1);
			this.Name = "Authentification";
			this.Text = "Authentification";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		}
	}

