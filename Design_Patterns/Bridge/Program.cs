// Interface représentant l'implémentation des formulaires
public interface IFormulaireImplementation
{
    void AfficheMessage(string message);
    void ValideFormulaire();
}

// Implémentation HTML
public class FormulaireImplementationHTML : IFormulaireImplementation
{
    public void AfficheMessage(string message)
    {
        Console.WriteLine($"HTML: {message}");
    }

    public void ValideFormulaire()
    {
        Console.WriteLine("Validation du formulaire HTML.");
    }
}

// Implémentation Applet
public class FormulaireImplementationApplet : IFormulaireImplementation
{
    public void AfficheMessage(string message)
    {
        Console.WriteLine($"Applet: {message}");
    }

    public void ValideFormulaire()
    {
        Console.WriteLine("Validation du formulaire Applet.");
    }
}

// Classe abstraite représentant les formulaires
public abstract class FormulaireImmatriculation
{
    protected IFormulaireImplementation _implementation;

    protected FormulaireImmatriculation(IFormulaireImplementation implementation)
    {
        _implementation = implementation;
    }

    public abstract void Affiche();
    public abstract void Valide();
}

// Formulaire pour la France
public class FormulaireImmatriculationFrance : FormulaireImmatriculation
{
    public FormulaireImmatriculationFrance(IFormulaireImplementation implementation) 
        : base(implementation) { }

    public override void Affiche()
    {
        _implementation.AfficheMessage("Formulaire d'immatriculation pour la France.");
    }

    public override void Valide()
    {
        _implementation.ValideFormulaire();
    }
}

// Formulaire pour le Luxembourg
public class FormulaireImmatriculationLux : FormulaireImmatriculation
{
    public FormulaireImmatriculationLux(IFormulaireImplementation implementation) 
        : base(implementation) { }

    public override void Affiche()
    {
        _implementation.AfficheMessage("Formulaire d'immatriculation pour le Luxembourg.");
    }

    public override void Valide()
    {
        _implementation.ValideFormulaire();
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Utilisation du formulaire HTML pour la France
        IFormulaireImplementation htmlImpl = new FormulaireImplementationHTML();
        FormulaireImmatriculation formulaireFrance = new FormulaireImmatriculationFrance(htmlImpl);

        formulaireFrance.Affiche();
        formulaireFrance.Valide();

        Console.WriteLine();

        // Utilisation du formulaire Applet pour le Luxembourg
        IFormulaireImplementation appletImpl = new FormulaireImplementationApplet();
        FormulaireImmatriculation formulaireLux = new FormulaireImmatriculationLux(appletImpl);

        formulaireLux.Affiche();
        formulaireLux.Valide();
    }
}
