public class Vendeur
{
    private IConstructeurLiasseVehicule constructeur;

    public Vendeur(IConstructeurLiasseVehicule constructeur)
    {
        this.constructeur = constructeur;
    }

    public Liasse Construit(string client)
    {
        constructeur.ConstruitBonDeCommande(client);
        constructeur.ConstruitDemandeImmatriculation(client);
        return constructeur.GetResultat();
    }
}