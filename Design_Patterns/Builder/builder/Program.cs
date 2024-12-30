using System;

public class Programme
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Choisissez le type de documents (1 : HTML, 2 : PDF) :");
        string choix = Console.ReadLine();

        IConstructeurLiasseVehicule constructeur;

        if (choix == "1")
        {
            constructeur = new ConstructeurLiasseVehiculeHtml();
        }
        else
        {
            constructeur = new ConstructeurLiasseVehiculePdf();
        }

        Vendeur vendeur = new Vendeur(constructeur);

        Console.WriteLine("Entrez le nom du client :");
        string client = Console.ReadLine();

        Liasse liasse = vendeur.Construit(client);
        liasse.Imprime();
    }
}