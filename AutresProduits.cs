/*
 * Created by SharpDevelop.
 * User: bmd-tech
 * Date: 21/08/2023
 * Time: 00:43
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
/*
 * Created by SharpDevelop.
 * User: bmd-tech
 * Date: 21/08/2023
 * Time: 00:15
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Linq;

namespace Projet_Resto
{
    public partial class AutresProduits : Form
    {
        private string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:/Users/bmd-tech/Documents/Commande.accdb;";

        public AutresProduits()
        {
            InitializeComponent();
            LoadProductNames();
        }

        private void LoadProductNames()
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                string query = "SELECT Nom FROM Produit";
                using (OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dgvNames.DataSource = dataTable;
                }
            }
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            if (dgvNames.SelectedRows.Count > 0)
            {
                string selectedProductName = dgvNames.SelectedRows[0].Cells["Nom"].Value.ToString();
                int labelIndex = GetNextLabelIndex(); // Obtenez l'index du prochain label disponible
                int quantity = DemanderQuantite(); // Demandez la quantité à l'utilisateur

                // Mettez à jour les labels dans Gestion_De_Produits
                Gestion_De_Produits gestionProduitsForm = Application.OpenForms["Gestion_De_Produits"] as Gestion_De_Produits;
                if (gestionProduitsForm != null)
                {
                    UpdateLabels(labelIndex, selectedProductName, quantity);
                }
            }
            else
            {
                MessageBox.Show("Sélectionnez un produit à ajouter.", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void UpdateLabels(int labelIndex, string productName, int quantity)
        {
            Gestion_De_Produits gestionProduitsForm = Application.OpenForms["Gestion_De_Produits"] as Gestion_De_Produits;
            if (gestionProduitsForm != null)
            {
                Label nameLabel = gestionProduitsForm.nameLabelList[labelIndex];
                Label quantityLabel = gestionProduitsForm.quantityLabelList[labelIndex];
                Label priceLabel = gestionProduitsForm.priceLabelList[labelIndex];

                if (nameLabel != null && quantityLabel != null && priceLabel != null)
                {
                    nameLabel.Text = productName;
                    quantityLabel.Text = "Quantité : " + quantity;
                    priceLabel.Text = gestionProduitsForm.GetProductPrice(productName).ToString("C2");
                    gestionProduitsForm.AfficherTotal();
                }
            }
        }

      

        private int GetNextLabelIndex()
        {
            int nextIndex = -1;

            // Trouver le prochain index disponible pour le label de nom, de quantité et de prix
            for (int i = 0; i < 11; i++) // Remplacez MAX_PRODUCTS par le nombre maximal de produits que vous pouvez afficher
            {
                Label nameLabel = Controls.Find("nameLabel" + (i + 1), true).FirstOrDefault() as Label;
                Label quantityLabel = Controls.Find("quantityLabel" + (i + 1), true).FirstOrDefault() as Label;
                Label priceLabel = Controls.Find("priceLabel" + (i + 1), true).FirstOrDefault() as Label;

                if (nameLabel != null && quantityLabel != null && priceLabel != null)
                {
                    if (nameLabel.Text == "" && quantityLabel.Text == "" && priceLabel.Text == "")
                    {
                        nextIndex = i;
                        break;
                    }
                }
            }

            return nextIndex;
        }

        private int DemanderQuantite()
        {
            int quantite = 0;
            string input = InputBox.Show("Entrez la quantité :", "Quantité", "1");
            int.TryParse(input, out quantite);
            return quantite;
        }

        private void TextBoxSearch_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = textBoxSearch.Text;
            FilterProductNames(searchTerm);
        }

        private void FilterProductNames(string searchTerm)
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                string query = "SELECT Nom FROM Produit WHERE Nom LIKE @searchTerm";
                using (OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection))
                {
                    adapter.SelectCommand.Parameters.AddWithValue("@searchTerm", "%" + searchTerm + "%");
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dgvNames.DataSource = dataTable;
                }
            }
        }

       
    }
}
