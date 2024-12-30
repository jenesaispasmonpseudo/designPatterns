public class ConstructeurLiasseVehiculeHtml : IConstructeurLiasseVehicule
{
    private LiasseHtml liasse = new LiasseHtml();

    public void ConstruitBonDeCommande(string client)
    {
        string document = $"Bon de commande HTML pour {client}";
        liasse.AjouteDocument(document);
    }

    public void ConstruitDemandeImmatriculation(string client)
    {
        string document = $"Demande d'immatriculation HTML pour {client}";
        liasse.AjouteDocument(document);
    }

    public Liasse GetResultat()
    {
        return liasse;
    }
}