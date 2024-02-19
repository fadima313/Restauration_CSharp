using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Projet_Resto
{
    public partial class Prise_Commande : Form
    {
        private string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:/Users/bmd-tech/Documents/Commande.accdb;";

        private PictureBox currentlySelectedTable = null;  // Pour stocker la référence à l'image sélectionnée
		
       //private TextBox TextBoxID; 
   		//private TextBox TextBoxDate; 

    public Prise_Commande()
    {
        InitializeComponent();

        // Initialiser les TextBox ID et Date
        //TextBoxID = ID;     
        //TextBoxDate = Date; 
    }


        private void TableClick(object sender, EventArgs e)
        {
            PictureBox selectedTable = (PictureBox)sender;
            
            
             if (currentlySelectedTable != null)
  			  {
      		  currentlySelectedTable.BorderStyle = BorderStyle.None;
   				 }

   				// Mettre à jour la bordure de la nouvelle image sélectionnée
    			selectedTable.BorderStyle = BorderStyle.FixedSingle;
    			currentlySelectedTable = selectedTable;
            
            
            selectedTable.BorderStyle = BorderStyle.FixedSingle;
            
          
            
            // Collecter les informations de la table
            string selectedTableName = selectedTable.Name;
            int guestCount = int.Parse(guessI1.Text);
            int tableNumber = int.Parse(tableI1.Text);
			
            
             // Copier les informations de la première table vers la deuxième table (guessI2, tableI2)
       		 guessI2.Text = guessI1.Text;
       		 tableI2.Text = tableI1.Text;
        }

        private void UpdateTableInfoInDatabase(string tableName, int guestCount, int tableNumber)
        {
            try
            {
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO Commande (Nom_table, GuestCount, TableNumber) VALUES (@tableName, @guestCount, @tableNumber)";

                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@tableName", tableName);
                        command.Parameters.AddWithValue("@guestCount", guestCount);
                        command.Parameters.AddWithValue("@tableNumber", tableNumber);
                        //command.Parameters.AddWithValue("@date", DateTime.Now);
                        
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Informations de la table enregistrées avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("L'enregistrement des informations de la table a échoué.", "Échec", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur s'est produite : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

      private void ButtonGererTable_Click(object sender, EventArgs e)
{
    if (currentlySelectedTable != null)
    {
        string selectedTableName = currentlySelectedTable.Name;
        int guestCount = int.Parse(guessI1.Text);
        int tableNumber = int.Parse(tableI1.Text);

        // Mettre à jour la base de données
        UpdateTableInfoInDatabase(selectedTableName, guestCount, tableNumber);

        // Ouvrir le formulaire GestionTableForm avec les informations de texte
        GestionTableForm gestionTableForm = new GestionTableForm( guessI2, tableI2); // Passer les TextBox ID et Date
        gestionTableForm.ShowDialog();

        // Fermer le formulaire actuel
        this.Close();
    }
    else
    {
        MessageBox.Show("Veuillez sélectionner une table.", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
    }
}
      
    private void ButtonSaveAndGo_Click(object sender, EventArgs e)
{
    if (currentlySelectedTable != null)
    {
        string selectedTableName = currentlySelectedTable.Name;
        int guestCount = int.Parse(guessI1.Text);
        int tableNumber = int.Parse(tableI1.Text);

        // Enregistrement des informations de la table
        UpdateTableInfoInDatabase(selectedTableName, guestCount, tableNumber);

        // Récupérez l'identifiant de la commande nouvellement créée
        int newCommandeID = GetNewlyCreatedCommandeID();

        // Passage à l'interface Gestion_De_Produits avec l'identifiant de commande
        Gestion_De_Produits gestionProduitsForm = new Gestion_De_Produits(newCommandeID);
        gestionProduitsForm.ShowDialog();

        this.Close();
    }
    else
    {
        MessageBox.Show("Veuillez sélectionner une table.", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
    }
}


		private int GetNewlyCreatedCommandeID()
{
    try
    {
        using (OleDbConnection connection = new OleDbConnection(connectionString))
        {
            connection.Open();
            string query = "SELECT MAX(ID) FROM Commande"; // Supposant que l'ID est auto-incrémenté
            using (OleDbCommand command = new OleDbCommand(query, connection))
            {
                object result = command.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                {
                    return Convert.ToInt32(result);
                }
                return -1; // Valeur par défaut si l'ID n'a pas été trouvé
            }
        }
    }
    catch (Exception ex)
    {
        MessageBox.Show("Une erreur s'est produite : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
        return -1; // En cas d'erreur
    }
}


    }
}
