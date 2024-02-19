/*
 * Created by SharpDevelop.
 * User: bmd-tech
 * Date: 20/08/2023
 * Time: 14:57
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Projet_Resto
{
    public partial class Gestion_De_Produit_Explicite : Form
    {
        private string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:/Users/bmd-tech/Documents/Commande.accdb;";
        private List<Produit> produits = new List<Produit>();
          private class Produit
{
    public int ID { get; set; }
    public string Nom { get; set; }
    public decimal Prix { get; set; }
    
    public Produit(){}

    public Produit(int id, string nom, decimal prix)
    {
        ID = id;
        Nom = nom;
        Prix = prix;
    }
}

        public Gestion_De_Produit_Explicite()
        {
            InitializeComponent();
            LoadProducts();
        }

        private void LoadProducts()
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                string query = "SELECT * FROM Produit";
                using (OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    foreach (DataRow row in dataTable.Rows)
					{
    					produits.Add(new Produit
    						{
        						ID = Convert.ToInt32(row["ID"]),
        						Nom = row["Nom"].ToString(),
        						Prix = Convert.ToDecimal(row["Prix"]), // Convertir en décimal ici
    						});
					}


                    dgvProducts.DataSource = produits;
                }
            }
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            if (dgvProducts.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dgvProducts.SelectedRows[0].Index;
                int selectedProductID = produits[selectedRowIndex].ID;

                if (DeleteProduct(selectedProductID))
                {
                    produits.RemoveAt(selectedRowIndex);
                    dgvProducts.DataSource = null;
                    dgvProducts.DataSource = produits;
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

        private bool DeleteProduct(int productID)
        {
            try
            {
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();
                    string query = "DELETE FROM Produit WHERE ID = @productID";

                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@productID", productID);
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
 private void dgvProducts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
{
    if (e.RowIndex >= 0)
    {
        dgvProducts.BeginEdit(true);
    }
}


      private void ButtonUpdate_Click(object sender, EventArgs e)
{
    if (dgvProducts.SelectedRows.Count > 0)
    {
        int selectedRowIndex = dgvProducts.SelectedRows[0].Index;
        int selectedProductID = produits[selectedRowIndex].ID;

        string updatedProductName = textboxNomProd.Text;
        string updatedProductPriceText = textBoxPrix.Text;  // Utilisation de la propriété Text

        if (UpdateProduct(selectedProductID, updatedProductName, updatedProductPriceText))
        {
            produits[selectedRowIndex].Nom = updatedProductName;

            // Convertir la valeur de prix mise à jour en décimal
            decimal updatedProductPriceDecimal;

            if (decimal.TryParse(updatedProductPriceText, out updatedProductPriceDecimal))
            {
                produits[selectedRowIndex].Prix = updatedProductPriceDecimal;
                dgvProducts.DataSource = null;
                dgvProducts.DataSource = produits;
                MessageBox.Show("Mise à jour réussie.");
            }
            else
            {
                MessageBox.Show("Le prix mis à jour n'est pas un nombre décimal valide.");
            }
        }
        else
        {
            MessageBox.Show("La mise à jour a échoué.");
        }
    }
    else
    {
        MessageBox.Show("Sélectionnez une ligne pour mettre à jour.");
    }
}

private void ButtonAdd_Click(object sender, EventArgs e)
{
    string newProductName = textboxNomProd.Text;
    string newProductPriceText = textBoxPrix.Text;  // Utilisation de la propriété Text
    decimal newProductPrice;

    if (decimal.TryParse(newProductPriceText, out newProductPrice))
    {
        if (InsertProduct(newProductName, newProductPrice))
        {
            int newProductID = GetLastInsertedProductID();  // Obtenez le nouvel ID du produit inséré
            produits.Add(new Produit(newProductID, newProductName, newProductPrice));
            dgvProducts.DataSource = null;
            dgvProducts.DataSource = produits;
            MessageBox.Show("Produit ajouté avec succès.");
        }
        else
        {
            MessageBox.Show("L'ajout du produit a échoué.");
        }
    }
    else
    {
        MessageBox.Show("Le prix entré n'est pas un nombre décimal valide.");
    }
}

private int GetLastInsertedProductID()
{
    using (OleDbConnection connection = new OleDbConnection(connectionString))
    {
        connection.Open();
        string query = "SELECT MAX(ID) FROM Produit";
        using (OleDbCommand command = new OleDbCommand(query, connection))
        {
            object result = command.ExecuteScalar();
            if (result != null && result != DBNull.Value)
            {
                return Convert.ToInt32(result);
            }
            return 0;
        }
    }
}



private bool UpdateProduct(int productID, string productName, string productPrice)
{
    try
    {
        using (OleDbConnection connection = new OleDbConnection(connectionString))
        {
            connection.Open();
            string query = "UPDATE Produit SET Nom = @productName, Prix = @productPrice WHERE ID = @productID";

            using (OleDbCommand command = new OleDbCommand(query, connection))
            {
                command.Parameters.AddWithValue("@productName", productName);
                command.Parameters.AddWithValue("@productPrice", productPrice);
                command.Parameters.AddWithValue("@productID", productID);
                int rowsAffected = command.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }
    }
    catch (OleDbException ex)
    {
        MessageBox.Show("Erreur lors de la mise à jour : " + ex.Message);
        return false;
    }
}

private bool InsertProduct(string productName, decimal productPrice)
{
    try
    {
        using (OleDbConnection connection = new OleDbConnection(connectionString))
        {
            connection.Open();
            string query = "INSERT INTO Produit (Nom, Prix) VALUES (@productName, @productPrice)";

            using (OleDbCommand command = new OleDbCommand(query, connection))
            {
                command.Parameters.AddWithValue("@productName", productName);
                command.Parameters.AddWithValue("@productPrice", productPrice);
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


private void SearchProducts(string searchText)
    {
        using (OleDbConnection connection = new OleDbConnection(connectionString))
        {
            string query = "SELECT * FROM Produit WHERE Nom LIKE @searchText OR Prix LIKE @searchText" ;
            using (OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection))
            {
                adapter.SelectCommand.Parameters.AddWithValue("@searchText", "%" + searchText + "%");
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                produits.Clear();  // Efface la liste de produits actuelle

                foreach (DataRow row in dataTable.Rows)
                {
                    produits.Add(new Produit
                    {
                        ID = Convert.ToInt32(row["ID"]),
                        Nom = row["Nom"].ToString(),
                        Prix = Convert.ToDecimal(row["Prix"]),
                    });
                }

                dgvProducts.DataSource = null;
                dgvProducts.DataSource = produits;
            }
        }
    }

    private void textboxSearch_TextChanged(object sender, EventArgs e)
    {
        string searchText = TextBoxSearch.Text;
        SearchProducts(searchText);
    }

     

    }
}