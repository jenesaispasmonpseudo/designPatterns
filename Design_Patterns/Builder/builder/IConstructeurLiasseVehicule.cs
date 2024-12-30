public interface IConstructeurLiasseVehicule
{
    void ConstruitBonDeCommande(string client);
    void ConstruitDemandeImmatriculation(string client);
    Liasse GetResultat();
}