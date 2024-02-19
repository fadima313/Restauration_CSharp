/*
 * Created by SharpDevelop.
 * User: bmd-tech
 * Date: 16/08/2023
 * Time: 09:06
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

using System.Linq;



namespace Projet_Resto
{
    public partial class Gestion_De_Produits : Form
    {
        private string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:/Users/bmd-tech/Documents/Commande.accdb;";
        private List<Produit> produits = new List<Produit>();
       public List<Label> nameLabelList { get; private set; }
    public List<Label> quantityLabelList { get; private set; }
    public List<Label> priceLabelList { get; private set; }

        private decimal totalCommande = 0;
        private int commandeID;
        private int selectedProductID;

        public Gestion_De_Produits (int commandeID)
        {
            InitializeComponent();
            LoadCommandeProducts(commandeID);
            InitializeLabelLists();
            this.commandeID = commandeID;
            selectedProductID = -1;
           
        }

        private void InitializeLabelLists()
        {
        	nameLabelList = new List<Label>();
        	
            nameLabelList.Add(nameLabel1);
            nameLabelList.Add(nameLabel2);
            nameLabelList.Add(nameLabel3);
            nameLabelList.Add(nameLabel4);
            nameLabelList.Add(nameLabel5);
            nameLabelList.Add(nameLabel6);
            nameLabelList.Add(nameLabel7);
            nameLabelList.Add(nameLabel8);
            nameLabelList.Add(nameLabel9);
            nameLabelList.Add(nameLabel10);
            nameLabelList.Add(nameLabel11);
          
            
            
			quantityLabelList = new List<Label>();
			
            quantityLabelList.Add(quantityLabel1);
            quantityLabelList.Add(quantityLabel2);
            quantityLabelList.Add(quantityLabel3);
            quantityLabelList.Add(quantityLabel4);
            quantityLabelList.Add(quantityLabel5);
            quantityLabelList.Add(quantityLabel6);
            quantityLabelList.Add(quantityLabel7);
            quantityLabelList.Add(quantityLabel8);
            quantityLabelList.Add(quantityLabel9);
            quantityLabelList.Add(quantityLabel10);
            quantityLabelList.Add(quantityLabel11);
           
            // Ajoutez d'autres labels ici...
            
			priceLabelList = new List<Label>();
			
            priceLabelList.Add(priceLabel1);
            priceLabelList.Add(priceLabel2);
            priceLabelList.Add(priceLabel3);
             priceLabelList.Add(priceLabel4);
            priceLabelList.Add(priceLabel5);
            priceLabelList.Add(priceLabel6);
             priceLabelList.Add(priceLabel7);
            priceLabelList.Add(priceLabel8);
            priceLabelList.Add(priceLabel9);
             priceLabelList.Add(priceLabel10);
            priceLabelList.Add(priceLabel11);
          
            
            // Ajoutez d'autres labels ici...
        }

    private void LoadCommandeProducts(int produitID)
{
    using (OleDbConnection connection = new OleDbConnection(connectionString))
    {
        connection.Open();
        
        // Requête SQL pour récupérer les produits associés à la commande
        string query = @"SELECT p.Nom, cp.Quantite, p.Prix
                        FROM Produit p
                        INNER JOIN CommandeProduit cp ON p.ID = cp.ProduitID
                        WHERE cp.ProduitID = @produitID";

        using (OleDbCommand command = new OleDbCommand(query, connection))
        {
            command.Parameters.AddWithValue("@produitID", produitID);
            using (OleDbDataReader reader = command.ExecuteReader())
            {
                int labelIndex = 0;

                while (reader.Read() && labelIndex < 11)
                {
                    string nomProduit = reader["Nom"].ToString();
                    int quantite = Convert.ToInt32(reader["Quantite"]);
                    decimal prix = Convert.ToDecimal(reader["Prix"]);

                    UpdateLabels(labelIndex, nomProduit, quantite, prix);

                    labelIndex++;
                }
            }
        }
    }
}



private void UpdateLabels(int labelIndex, string productName, int quantity, decimal productPrice)
{
    // Assurez-vous que les index sont valides pour éviter les erreurs
    if (labelIndex >= 0 && labelIndex < 11)
    {
        nameLabelList[labelIndex].Text = productName;
        quantityLabelList[labelIndex].Text = "Quantité : " + quantity;
        priceLabelList[labelIndex].Text = productPrice.ToString("C2");
    }
}


        
        private void btnPizza_Click(object sender, EventArgs e)
{
    AfficherProduit("Pizza");
     selectedProductID= GetProductIDByName("Pizza");
}

private void btnSummerSalade_Click(object sender, EventArgs e)
{
    AfficherProduit("Summer Salade");
     selectedProductID= GetProductIDByName("Summer Salade");
}

private void btnChickenFried_Click(object sender, EventArgs e)
{
    AfficherProduit("Chicken Fried");
     selectedProductID= GetProductIDByName("Chicken Fried");
}

private void btnChickenWings_Click(object sender, EventArgs e)
{
    AfficherProduit("Chicken Wings");
     selectedProductID= GetProductIDByName("Chicken Wings");
}

private void btnFrenchFried_Click(object sender, EventArgs e)
{
    AfficherProduit("French Fries");
     selectedProductID= GetProductIDByName("French Fries");
}

private void btnBuffaloWings_Click(object sender, EventArgs e)
{
    AfficherProduit("Buffalo Wings");
     selectedProductID= GetProductIDByName("Buffalo Wings");
     
}

private void btnFriedFish_Click(object sender, EventArgs e)
{
    AfficherProduit("Fried Fish");
     selectedProductID= GetProductIDByName("Fried Fish");
}

private void btnCrabeCake_Click(object sender, EventArgs e)
{
    AfficherProduit("Crabe Cake");
     selectedProductID= GetProductIDByName("Crabe Cake");
}

private void btnMeatNorvegian_Click(object sender, EventArgs e)
{
    AfficherProduit("Meat Norvegian");
     selectedProductID= GetProductIDByName("Meat Norvegian");
}


private void AfficherProduit(string nomProduit)
{
    Produit produit = produits.Find(p => p.Nom == nomProduit);

    if (produit != null)
    {
        int labelIndex = GetNextLabelIndex();
        int quantity = DemanderQuantite();

        EnregistrerCommande(commandeID, produit.ID, quantity);

        UpdateLabels(labelIndex, produit.Nom, quantity, produit.Prix);

        // Mise à jour des labels d'affichage
        Label nameLabelToUpdate = nameLabelList[labelIndex];
        Label quantityLabelToUpdate = quantityLabelList[labelIndex];
        Label priceLabelToUpdate = priceLabelList[labelIndex];

        nameLabelToUpdate.Text = produit.Nom;
        quantityLabelToUpdate.Text = quantity.ToString();
        priceLabelToUpdate.Text = produit.Prix.ToString();
    }
}

private void btnAddToCommand_Click(object sender, EventArgs e)
{
    if (selectedProductID != -1)
    {
        int quantity = DemanderQuantite();

        EnregistrerCommande(commandeID, selectedProductID, quantity);

        // Mise à jour des labels d'affichage
        LoadCommandeProducts(commandeID);
    }
}


        private int GetProductIDByName(string productName)
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT ID FROM Produit WHERE Nom = @productName";
                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@productName", productName);
                    object result = command.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        return Convert.ToInt32(result);
                    }
                }
            }
            return -1; // Produit non trouvé
        }

private void EnregistrerCommande(int commandeID, int produitID, int quantite)
{
    using (OleDbConnection connection = new OleDbConnection(connectionString))
    {
        connection.Open();
        string query = "INSERT INTO CommandeProduit (CommandeID, ProduitID, Quantite) VALUES (@commandeID, @produitID, @quantite)";
        using (OleDbCommand command = new OleDbCommand(query, connection))
        {
            command.Parameters.AddWithValue("@commandeID", commandeID);
            command.Parameters.AddWithValue("@produitID", produitID);
            command.Parameters.AddWithValue("@quantite", quantite);
            command.ExecuteNonQuery();
        }
    }
}





   
    
    public decimal GetProductPrice(string productName)
{
    Produit produit = produits.Find(p => p.Nom == productName);
    if (produit != null)
    {
        return produit.Prix;
    }
    return 0; // Ou une valeur par défaut si le produit n'est pas trouvé
}

   private int GetNextLabelIndex()
{
    int nextIndex = -1;


    // Trouver le prochain index disponible pour le label de nom, de quantité et de prix
    for (int i = 0; i < 12; i++) // Remplacez MAX_PRODUCTS par le nombre maximal de produits que vous pouvez afficher
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



        private void AfficherProduits(List<Produit> produitsList, List<Label> nameLabelList, List<Label> priceLabelList)
        {
            for (int i = 0; i < produitsList.Count; i++)
            {
                nameLabelList[i].Text = produitsList[i].Nom;
                priceLabelList[i].Text = produitsList[i].Prix.ToString("C2");
                nameLabelList[i].Tag = produitsList[i]; // Associez le produit au Tag du label
            }
        }

        public void AfficherTotal()
        {
            totalCommande = 0;
            foreach (Label priceLabel in priceLabelList)
            {
                if (!string.IsNullOrEmpty(priceLabel.Text))
                {
                    totalCommande += Convert.ToDecimal(priceLabel.Text.Substring(1)); // Supprimez le symbole de la monnaie
                }
            }
            LabelTotal.Text = "Total : " + totalCommande.ToString("C2");
        }

        private void ButtonSelection_Click(object sender, EventArgs e)
        {
            Button selectedButton = (Button)sender;
            Produit selectedProduct = (Produit)selectedButton.Tag; // Récupérez le produit associé au bouton
            int labelIndex = selectedButton.Name.EndsWith("1") ? 0 : selectedButton.Name.EndsWith("2") ? 1 : 2; // Correspond à l'index des labels
            int quantity = DemanderQuantite(); // Demandez la quantité à l'utilisateur
            quantityLabelList[labelIndex].Text = "Quantité : " + quantity;
            priceLabelList[labelIndex].Text = (selectedProduct.Prix * quantity).ToString("C2");
            AfficherTotal();
        }

       private int DemanderQuantite()
{
    int quantite = 0;
    string input = InputBox.Show("Entrez la quantité :", "Quantité", "1");
    int.TryParse(input, out quantite);
    return quantite;
}


        private void ButtonAutresElements_Click(object sender, EventArgs e)
        {
        	AutresProduits autreProds= new AutresProduits();
        	autreProds.Show();
        }

        private void ButtonGererProduits_Click(object sender, EventArgs e)
        {
            Gestion_De_Produit_Explicite gestionProduits = new Gestion_De_Produit_Explicite();
            gestionProduits.ShowDialog();
        }

        private class Produit
        {
            public int ID { get; set; }
            public string Nom { get; set; }
            public decimal Prix { get; set; }
        }
    }
}
