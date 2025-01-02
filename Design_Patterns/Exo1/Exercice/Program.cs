using System;

// Interface des fabriques
public interface IFactory
{
    IRIB CreerRIB();
    IAttestation CreerAttestation();
}

// Fabrique concrète pour les particuliers
public class FabriqueParticulier : IFactory
{
    public IRIB CreerRIB()
    {
        return new RIBSimplifie();
    }

    public IAttestation CreerAttestation()
    {
        return new AttestationStandardisee();
    }
}

// Fabrique concrète pour les professionnels
public class FabriqueProfessionnel : IFactory
{
    public IRIB CreerRIB()
    {
        return new RIBDetaille();
    }

    public IAttestation CreerAttestation()
    {
        return new AttestationAvecMentions();
    }
}

// Interface pour le Relevé d'Identité Bancaire
public interface IRIB
{
    void Generer();
}

// Relevé d'Identité Bancaire simplifié
public class RIBSimplifie : IRIB
{
    public void Generer()
    {
        Console.WriteLine("Génération du RIB simplifié pour un particulier.");
    }
}

// Relevé d'Identité Bancaire détaillé
public class RIBDetaille : IRIB
{
    public void Generer()
    {
        Console.WriteLine("Génération du RIB détaillé pour un professionnel avec SIRET.");
    }
}

// Interface pour l'Attestation de compte
public interface IAttestation
{
    void Generer();
}

// Attestation standardisée pour particuliers
public class AttestationStandardisee : IAttestation
{
    public void Generer()
    {
        Console.WriteLine("Génération de l'attestation de compte standardisée.");
    }
}

// Attestation avec mentions légales pour professionnels
public class AttestationAvecMentions : IAttestation
{
    public void Generer()
    {
        Console.WriteLine("Génération de l'attestation avec mentions légales spécifiques.");
    }
}

// Exemple d'utilisation
public class Program
{
    public static void Main()
    {
        // Exemple avec un client particulier
        IFactory fabriqueParticulier = new FabriqueParticulier();
        IRIB ribParticulier = fabriqueParticulier.CreerRIB();
        IAttestation attParticulier = fabriqueParticulier.CreerAttestation();

        ribParticulier.Generer();
        attParticulier.Generer();

        // Exemple avec un client professionnel
        IFactory fabriqueProfessionnel = new FabriqueProfessionnel();
        IRIB ribProfessionnel = fabriqueProfessionnel.CreerRIB();
        IAttestation attProfessionnel = fabriqueProfessionnel.CreerAttestation();

        ribProfessionnel.Generer();
        attProfessionnel.Generer();
    }
}
