/*
 * Created by SharpDevelop.
 * User: bmd-tech
 * Date: 12/08/2023
 * Time: 10:37
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Projet_Resto
{
	/// <summary>
	/// Description of Lancement.
	/// </summary>
	public partial class Lancement : Form
	{
		public Lancement()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		private void BoutonLancement_Click(object sender, EventArgs e)
{
    // Instancie la fenêtre d'authentification
    Authentification authentificationForm = new Authentification();

    // Affiche la fenêtre d'authentification
    authentificationForm.Show();

    // Cache la fenêtre de lancement si nécessaire
    this.Hide();
}

	}
}
