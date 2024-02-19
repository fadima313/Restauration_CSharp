using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Projet_Resto
{
    public partial class GestionTableForm : Form
    {
        private DataGridView dgvTables;
        private TextBox TextBoxGuest;
        private TextBox TextBoxTable;
        private TextBox ID;
        private TextBox Date;
        private TextBox Nom_table;
        
        private string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:/Users/bmd-tech/Documents/Commande.accdb;";

        public GestionTableForm(  TextBox guestTextBox, TextBox tableTextBox)
        {
            InitializeComponent();
            
            
            
            TextBoxGuest = guestTextBox;
            TextBoxTable = tableTextBox;
           // ID = idTextBox; 
       		//Date = dateTextBox; 

            

            LoadTableData();
        }

       private void LoadTableData()
{
    using (OleDbConnection connection = new OleDbConnection(connectionString))
    {
        string query = "SELECT * FROM Commande"; 

        using (OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection))
        {
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            //DataColumn dateColumn = new DataColumn("FormattedDate", typeof(string)); // Utiliser une colonne de type chaîne pour la date formatée
           // dataTable.Columns.Add(dateColumn);

            dgvTables.DataSource = dataTable;
        }
    }
}


        private bool DeleteTableData(string tableNumber)
        {
            try
            {
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();
                    string query = "DELETE FROM Commande WHERE TableNumber = @tableNumber";

                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@tableNumber", tableNumber);
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

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            if (dgvTables.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dgvTables.SelectedRows[0].Index;
                string tableNumber = dgvTables.SelectedRows[0].Cells["TableNumber"].Value.ToString();

                if (DeleteTableData(tableNumber))
                {
                    dgvTables.Rows.RemoveAt(selectedRowIndex);
                    MessageBox.Show("Suppression réussie.");
                }
                else
                {
                    MessageBox.Show("La suppression a échoué.");
                }
            }
            else
            {
                MessageBox.Show("Sélectionnez une ligne pour supprimer.");
            }
        }

        private void dgvTables_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvTables.Rows[e.RowIndex];
                string tableNumber = selectedRow.Cells["TableNumber"].Value.ToString();
                int guestCount = Convert.ToInt32(selectedRow.Cells["GuestCount"].Value);

                TextBoxTable.Text = tableNumber;
                TextBoxGuest.Text = guestCount.ToString();
            }
        }

        private bool UpdateTableData(int tableNumber, int guestCount)
        {
            try
            {
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();
                    string query = "UPDATE Commande SET GuestCount = @guestCount WHERE TableNumber = @tableNumber";

                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@guestCount", guestCount);
                        command.Parameters.AddWithValue("@tableNumber", tableNumber);
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

        private void ButtonUpdate_Click(object sender, EventArgs e)
        {
            int guestCount = int.Parse(TextBoxGuest.Text);
            int tableNumber = int.Parse(TextBoxTable.Text);

            if (UpdateTableData(tableNumber, guestCount))
            {
                LoadTableData();
                MessageBox.Show("Mise à jour réussie.");
            }
            else
            {
                MessageBox.Show("Échec de la mise à jour.");
            }
        }

        private void ButtonReturn_Click(object sender, EventArgs e)
        {
        	Prise_Commande priseC= new Prise_Commande();
            this.Close();
            priseC.Show();
        }
        
        
        private DataTable FilterTableData(string searchTerm)
{
    using (OleDbConnection connection = new OleDbConnection(connectionString))
    {
        string query = "SELECT * FROM Commande WHERE GuestCount = @searchTerm OR TableNumber = @searchTerm";

        using (OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection))
        {
            adapter.SelectCommand.Parameters.AddWithValue("@searchTerm", searchTerm);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }
    }
}
        
        
       private void ButtonDetail_Click(object sender, EventArgs e)
    {
        if (dgvTables.SelectedRows.Count > 0)
        {
            DataGridViewRow selectedRow = dgvTables.SelectedRows[0];
            string tableNumber = selectedRow.Cells["TableNumber"].Value.ToString();
            int guestCount = Convert.ToInt32(selectedRow.Cells["GuestCount"].Value);
            int id = Convert.ToInt32(selectedRow.Cells["ID"].Value);
            string tableName = selectedRow.Cells["Nom_table"].Value.ToString();
            string formattedDate = selectedRow.Cells["FormattedDate"].Value.ToString();

            // Afficher les informations dans les zones de texte
            TextBoxTable.Text = tableNumber;
            TextBoxGuest.Text = guestCount.ToString();
            ID.Text = id.ToString(); // Affichage de l'ID
            Nom_table.Text = tableName;
            Date.Text = formattedDate; // Affichage de la date
        }
        else
        {
            MessageBox.Show("Sélectionnez une ligne pour afficher les détails.");
        }
    }

     

		void TextBoxSearchTextChanged(object sender, EventArgs e)
		{
			string searchTerm = TextBoxSearch.Text;
    		DataTable filteredTable = FilterTableData(searchTerm);
   			 dgvTables.DataSource = filteredTable;

		}
		
    }
}
