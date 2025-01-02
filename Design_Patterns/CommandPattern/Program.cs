using System;
using System.Collections.Generic;

// Classe Véhicule
public class Vehicule
{
    public DateTime DateEntreeStock { get; private set; }
    public double PrixVente { get; private set; }
    private Stack<double> historiquePrix = new Stack<double>();

    public Vehicule(DateTime dateEntreeStock, double prixVente)
    {
        DateEntreeStock = dateEntreeStock;
        PrixVente = prixVente;
    }

    public int GetDureeStockage()
    {
        return (DateTime.Now - DateEntreeStock).Days;
    }

    public void AppliquerRemise(double tauxRemise)
    {
        historiquePrix.Push(PrixVente);
        PrixVente *= 1 - tauxRemise;
    }

    public void AnnulerDerniereRemise()
    {
        if (historiquePrix.Count > 0)
        {
            PrixVente = historiquePrix.Pop();
        }
    }

    public override string ToString()
    {
        return $"Véhicule - Date Entrée Stock: {DateEntreeStock}, Prix Vente: {PrixVente:F2}";
    }
}

// Interface Commande
public interface ICommande
{
    void Execute();
    void Annule();
    void Retablit();
}

// Classe CommandeSolder
public class CommandeSolder : ICommande
{
    private double tauxRemise;
    private int dureeStock;
    private List<Vehicule> vehiculesCibles = new List<Vehicule>();

    public CommandeSolder(int dureeStock, double tauxRemise)
    {
        this.dureeStock = dureeStock;
        this.tauxRemise = tauxRemise;
    }

    public void Execute(List<Vehicule> vehiculesStock)
    {
        vehiculesCibles.Clear();
        foreach (var vehicule in vehiculesStock)
        {
            if (vehicule.GetDureeStockage() >= dureeStock)
            {
                vehicule.AppliquerRemise(tauxRemise);
                vehiculesCibles.Add(vehicule);
            }
        }
        Console.WriteLine("Commande exécutée : véhicules soldés.");
    }

    public void Execute()
    {
        throw new InvalidOperationException("Utilisez Execute(List<Vehicule>) pour passer les véhicules.");
    }

    public void Annule()
    {
        foreach (var vehicule in vehiculesCibles)
        {
            vehicule.AnnulerDerniereRemise();
        }
        Console.WriteLine("Commande annulée.");
    }

    public void Retablit()
    {
        foreach (var vehicule in vehiculesCibles)
        {
            vehicule.AppliquerRemise(tauxRemise);
        }
        Console.WriteLine("Commande rétablie.");
    }
}

// Classe Catalogue
public class Catalogue
{
    private List<Vehicule> vehiculesStock = new List<Vehicule>();
    private Queue<ICommande> fileCommandes = new Queue<ICommande>();

    public void AjouterVehicule(Vehicule vehicule)
    {
        vehiculesStock.Add(vehicule);
    }

    public List<Vehicule> GetVehiculesStock()
    {
        return vehiculesStock;
    }

    public void AjouterCommande(ICommande commande)
    {
        fileCommandes.Enqueue(commande);
        Console.WriteLine("Commande ajoutée à la file.");
    }

    public void ExecuterProchaineCommande()
    {
        if (fileCommandes.Count > 0)
        {
            var commande = fileCommandes.Dequeue();
            commande.Execute(vehiculesStock);
        }
        else
        {
            Console.WriteLine("Aucune commande en attente.");
        }
    }
}

// Programme Principal
class Program
{
    static void Main(string[] args)
    {
        Catalogue catalogue = new Catalogue();

        // Ajouter des véhicules
        catalogue.AjouterVehicule(new Vehicule(DateTime.Now.AddDays(-100), 20000));
        catalogue.AjouterVehicule(new Vehicule(DateTime.Now.AddDays(-50), 15000));
        catalogue.AjouterVehicule(new Vehicule(DateTime.Now.AddDays(-10), 18000));

        // Créer une commande solder
        ICommande commande = new CommandeSolder(30, 0.1);

        // Ajouter et exécuter une commande
        catalogue.AjouterCommande(commande);
        catalogue.ExecuterProchaineCommande();

        // Annuler la commande
        commande.Annule();

        // Rétablir la commande
        commande.Retablit();
    }
}
