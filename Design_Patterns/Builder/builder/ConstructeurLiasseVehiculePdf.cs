public class ConstructeurLiasseVehiculePdf : IConstructeurLiasseVehicule
{
    private LiassePdf liasse = new LiassePdf();

    public void ConstruitBonDeCommande(string client)
    {
        string document = $"Bon de commande PDF pour {client}";
        liasse.AjouteDocument(document);
    }

    public void ConstruitDemandeImmatriculation(string client)
    {
        string document = $"Demande d'immatriculation PDF pour {client}";
        liasse.AjouteDocument(document);
    }

    public Liasse GetResultat()
    {
        return liasse;
    }
}