/*
 * Created by SharpDevelop.
 * User: bmd-tech
 * Date: 12/08/2023
 * Time: 13:06
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Projet_Resto
{
	/// <summary>
	/// Description of Gestion_Utilisateurs.
	/// </summary>
	public partial class Gestion_Utilisateurs : Form
	{
		
		private string connectionString;
		public Gestion_Utilisateurs()
        {
            InitializeComponent();
            connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:/Users/bmd-tech/Documents/auth.accdb;";
        	
        
        }
		
		
		private bool estEnModeModification = true;

        private void ChargerUser_Load(object sender, EventArgs e)
        {
            MettreAJourDataGridView();
        }

    	private string matriculeAModifier = "";
    	
    	
    	public Gestion_Utilisateurs(string matricule, string nom, string prenom, string login, string password, string role) : this()
    {
        estEnModeModification = true;
        matriculeAModifier = matricule;

        Matricule.Text = matricule;
        NomUser.Text = nom;
        PrenomUser.Text = prenom;
        LoginUSer.Text = login;
        PasswordUser.Text = password;
        RoleUser.Text = role;
    }
        public void MettreAJourDataGridView()
        {
            // Code pour charger les données des étudiants dans dataGridViewUser
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                string query = "SELECT Matricule, Nom, Prenom, Login, Password, Role FROM auth";

                using (OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection))
                {
                    connection.Open();
                    System.Data.DataTable dataTable = new System.Data.DataTable();
                    adapter.Fill(dataTable);

                    dataGridViewUser.DataSource = dataTable;
                }
            }
        }

        





        private void Annuler_Click(object sender, EventArgs e)
		{
   		 // Fermez le formulaire actuel (Gestion_User)
   		 
   		 Authentification auth = new Authentification();
   		 this.Close();
   		 auth.Show();
   		 
		}
		

	

        private void Supprimer_Click(object sender, EventArgs e)
        {
            if (dataGridViewUser.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Êtes-vous sûr de vouloir supprimer cet Utilisateur ?", "Confirmation de suppression", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    
                    
                     int selectedRowIndex = dataGridViewUser.SelectedRows[0].Index;
            			 DataGridViewRow selectedRow = dataGridViewUser.SelectedRows[0];
            		string matricule = selectedRow.Cells["Matricule"].Value.ToString();


                    bool suppressionReussie = this.Supprimer_User(matricule);

                    if (suppressionReussie)
                    {
                        MessageBox.Show("Utilisateur supprimé avec succès !");
                         dataGridViewUser.Rows.RemoveAt(selectedRowIndex); // Supprimer la ligne visuellement de la DataGridView
          
                    }
                    else
                    {
                        MessageBox.Show("Erreur lors de la suppression de l'utilisateur.");
                    }}
                
            else
            {
                MessageBox.Show("Sélectionnez une ligne pour supprimer.");
            }
            }}

        
        
        private void btnExecuterRecherche_Click(object sender, EventArgs e)
        {
            string searchTerm = txtRecherche.Text.Trim();
            if (!string.IsNullOrEmpty(searchTerm))
            {
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    string query = "SELECT Matricule, Nom, Prenom, Login, Password, Role FROM auth " +
                           "WHERE Matricule LIKE @searchTerm OR Nom LIKE @searchTerm OR Prenom LIKE @searchTerm OR " +
                           "Login LIKE @searchTerm OR Password LIKE @searchTerm OR Role LIKE @searchTerm";

                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection))
                    {
                        adapter.SelectCommand.Parameters.AddWithValue("@searchTerm", "%" + searchTerm + "%");
                        connection.Open();
                        System.Data.DataTable dataTable = new System.Data.DataTable();
                        adapter.Fill(dataTable);

                        dataGridViewUser.DataSource = dataTable;
                    }
                }
            }
            else
            {
                MettreAJourDataGridView();
            }
        }
        
        private bool Supprimer_User(string matricule)
        {
            try
            {
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();

                    string query = "DELETE FROM auth WHERE Matricule = @matricule";

                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@matricule", matricule);

                        int rowsAffected = command.ExecuteNonQuery();

                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur s'est produite : " + ex.Message);
                return false;
            }
        }

        public bool AjouterUser(string matricule, string nom, string prenom, string login, string password, string role)
        {
            try
            {
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();

                    string query = "INSERT INTO auth (Matricule,[Nom],[Prenom],[Login],[Password],[Role]) " + 
               "VALUES (@matricule, @nom, @prenom, @login, @password, @role)";


                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@matricule", matricule);
                        command.Parameters.AddWithValue("@nom", nom);
                        command.Parameters.AddWithValue("@prenom", prenom);
                        command.Parameters.AddWithValue("@login", login);
                        command.Parameters.AddWithValue("@password", password);
                        command.Parameters.AddWithValue("@role", role);

                        int rowsAffected = command.ExecuteNonQuery();

                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur s'est produite : " + ex.Message);
                return false;
            }
        }
        
      
 private void Confirmer_Click(object sender, EventArgs e)
{
    string matricule = Matricule.Text;
    string nom = NomUser.Text;
    string prenom = PrenomUser.Text;
    string login = LoginUSer.Text;
    string password = PasswordUser.Text;
    string role = RoleUser.Text;

    if (estEnModeModification)
    {
        bool modificationReussie = ModifierUser(matriculeAModifier, matricule, nom, prenom, login, password, role);

        if (modificationReussie)
        {
            MessageBox.Show("L'utilisateur a été modifié avec succès.", "Modification réussie", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MettreAJourDataGridView();
          
        }
        else
        {
            MessageBox.Show("La modification de l'utilisateur a échoué.", "Modification échouée", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
    else
    {
        bool ajoutReussi = AjouterUser(matricule, nom, prenom, login, password, role);

        if (ajoutReussi)
        {
            MessageBox.Show("L'utilisateur a été ajouté avec succès.", "Ajout réussi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MettreAJourDataGridView();
            
        }
        else
        {
            MessageBox.Show("L'ajout de l'utilisateur a échoué.", "Ajout échoué", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
 public bool ModifierUser(string ancienMatricule, string nouveauMatricule, string nom, string prenom, string login, string password, string role)
{
    try
    {
        using (OleDbConnection connection = new OleDbConnection(connectionString))
        {
            connection.Open();

            string query = "UPDATE auth SET [Matricule] = @nouveauMatricule, [Nom] = @nom, [Prenom] = @prenom, [Login] = @login, [Password] = @password, [Role] = @role " +
                           "WHERE [Matricule] = @ancienMatricule";

            using (OleDbCommand command = new OleDbCommand(query, connection))
            {
                command.Parameters.AddWithValue("@nouveauMatricule", nouveauMatricule);
                command.Parameters.AddWithValue("@nom", nom);
                command.Parameters.AddWithValue("@prenom", prenom);
                command.Parameters.AddWithValue("@login", login);
                command.Parameters.AddWithValue("@password", password);
                command.Parameters.AddWithValue("@role", role);
                command.Parameters.AddWithValue("@ancienMatricule", ancienMatricule);

                int rowsAffected = command.ExecuteNonQuery();

                return rowsAffected > 0;
            }
        }
    }
    catch (Exception ex)
    {
        MessageBox.Show("Une erreur s'est produite : " + ex.Message);
        return false;
    }
}
        
        private void Modifier_Click(object sender, EventArgs e)
{
    if (dataGridViewUser.SelectedRows.Count > 0)
    {
        // Obtenez l'index de la ligne sélectionnée et la ligne de données correspondante
        int selectedRowIndex = dataGridViewUser.SelectedRows[0].Index;
        DataGridViewRow selectedRow = dataGridViewUser.SelectedRows[0];

        // Récupérer les données de l'utilisateur sélectionné
        string matricule = selectedRow.Cells["Matricule"].Value.ToString();
        string nom = selectedRow.Cells["Nom"].Value.ToString();
        string prenom = selectedRow.Cells["Prenom"].Value.ToString();
        string login = selectedRow.Cells["Login"].Value.ToString();
        string password = selectedRow.Cells["Password"].Value.ToString();
        string role = selectedRow.Cells["Role"].Value.ToString();

        // Afficher les données de l'utilisateur dans les zones de texte
        Matricule.Text = matricule;
        NomUser.Text = nom;
        PrenomUser.Text = prenom;
        LoginUSer.Text = login;
        PasswordUser.Text = password;
        RoleUser.Text = role;
        
        this.MettreAJourDataGridView();
    }
    else
    {
        MessageBox.Show("Sélectionnez une ligne pour modifier.");
    }
}
        
       

		void GroupBox1Enter(object sender, EventArgs e)
		{
	
		}


        
    }
}
