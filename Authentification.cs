/*
 * Created by SharpDevelop.
 * User: bmd-tech
 * Date: 12/08/2023
 * Time: 10:51
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Projet_Resto
{
    public partial class Authentification : Form
    {
    	
    	private string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:/Users/bmd-tech/Documents/auth.accdb;";

        public Authentification()
        {
            InitializeComponent();
        }

        private void Authentification_Load(object sender, EventArgs e)
        {
            // Additional initialization code can be added here if needed.
        }

       private void LoginButton_Click(object sender, EventArgs e)
{
    string login = Login.Text;
    string password = Password.Text;

    if (login == "admin" && password == "admin")
    {
        Gestion_Utilisateurs gestionUser = new Gestion_Utilisateurs();
        this.Hide();
        gestionUser.Show();
        gestionUser.MettreAJourDataGridView();

        // Allow the user to log in.
        MessageBox.Show("Login successful!");
    }
    else
    {
        string role = GetRoleFromDatabase(login, password);

        if (role == "Restaurateur")
        {
         
            Prise_Commande priseCommande = new Prise_Commande();
            this.Hide();
            priseCommande.Show();
        }
        else if (role == "Chef_Cuisinier") 
        {
      
            Gestion_De_Produit_Explicite gestionProds = new Gestion_De_Produit_Explicite();
            this.Hide();
            gestionProds.Show();
            
        }
        else
        {
           
            MessageBox.Show("Login ou Mot de passe invalid. Veuillez Reessayer!");

            Login.Text = "";
            Password.Text = "";
        }
    }
}

private string GetRoleFromDatabase(string login, string password)
{
    try
    {
        using (OleDbConnection connection = new OleDbConnection(connectionString))
        {
            connection.Open();
            string query = "SELECT Role FROM auth WHERE Login = @login AND Password = @password";

            using (OleDbCommand command = new OleDbCommand(query, connection))
            {
                command.Parameters.AddWithValue("@login", login);
                command.Parameters.AddWithValue("@password", password);
                
                object roleObj = command.ExecuteScalar();
                if (roleObj != null)
                {
                    return roleObj.ToString();                 }
                else
                {
                    return "inconnu"; 
                }
            }
        }
    }
    catch (Exception ex)
    {
        MessageBox.Show("Une erreur s'est produite : " + ex.Message);
        return "erreur";
    }
}


        
        
        private void BoutonOubli_Click(object sender, EventArgs e)
		{
   			 string message = "Veuillez contacter l'administrateur pour récupérer vos informations d'accès.";
    		 string caption = "Mot de passe oublié";
    
    		MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

        
        
         private void AnnulerButton_Click(object sender, EventArgs e)
        {
         	Lancement lancement=new Lancement();
         	this.Hide();
         	lancement.Show();
         
        }
		void Label1Click(object sender, EventArgs e)
		{
	
		}
    }
}
