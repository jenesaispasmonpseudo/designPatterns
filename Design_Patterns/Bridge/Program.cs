using System;

namespace FormulaireApplication
{
    // Interface représentant l'implémentation des formulaires
    public interface IFormulaireImplementation
    {
        void AfficherMessage(string message);
        void ValiderFormulaire();
    }

    // Implémentation HTML
    public class FormulaireImplementationHTML : IFormulaireImplementation
    {
        public void AfficherMessage(string message)
        {
            Console.WriteLine($"HTML: {message}");
        }

        public void ValiderFormulaire()
        {
            Console.WriteLine("Validation du formulaire HTML.");
        }
    }

    // Implémentation Applet
    public class FormulaireImplementationApplet : IFormulaireImplementation
    {
        public void AfficherMessage(string message)
        {
            Console.WriteLine($"Applet: {message}");
        }

        public void ValiderFormulaire()
        {
            Console.WriteLine("Validation du formulaire Applet.");
        }
    }

    // Classe abstraite représentant les formulaires
    public abstract class FormulaireImmatriculation
    {
        protected readonly IFormulaireImplementation _implementation;

        protected FormulaireImmatriculation(IFormulaireImplementation implementation)
        {
            _implementation = implementation ?? throw new ArgumentNullException(nameof(implementation));
        }

        public abstract void Afficher();
        public abstract void Valider();
        public abstract bool ControleSaisie(string saisie); // Méthode abstraite pour le contrôle de saisie
    }

    // Formulaire pour la France
    public class FormulaireImmatriculationFrance : FormulaireImmatriculation
    {
        public FormulaireImmatriculationFrance(IFormulaireImplementation implementation) 
            : base(implementation) { }

        public override void Afficher()
        {
            _implementation.AfficherMessage("Formulaire d'immatriculation pour la France.");
        }

        public override void Valider()
        {
            if (ControleSaisie("Exemple"))
            {
                _implementation.ValiderFormulaire();
            }
            else
            {
                _implementation.AfficherMessage("Erreur : Saisie invalide pour la France.");
            }
        }

        public override bool ControleSaisie(string saisie)
        {
            // Exemple de contrôle simple : au moins 6 caractères
            return !string.IsNullOrEmpty(saisie) && saisie.Length > 5;
        }
    }

    // Formulaire pour le Luxembourg
    public class FormulaireImmatriculationLux : FormulaireImmatriculation
    {
        public FormulaireImmatriculationLux(IFormulaireImplementation implementation) 
            : base(implementation) { }

        public override void Afficher()
        {
            _implementation.AfficherMessage("Formulaire d'immatriculation pour le Luxembourg.");
        }

        public override void Valider()
        {
            if (ControleSaisie("LU-123"))
            {
                _implementation.ValiderFormulaire();
            }
            else
            {
                _implementation.AfficherMessage("Erreur : Saisie invalide pour le Luxembourg.");
            }
        }

        public override bool ControleSaisie(string saisie)
        {
            // Exemple de contrôle simple : doit commencer par "LU"
            return !string.IsNullOrEmpty(saisie) && saisie.StartsWith("LU");
        }
    }

    // Programme principal
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Utilisation du formulaire HTML pour la France
                IFormulaireImplementation htmlImpl = new FormulaireImplementationHTML();
                FormulaireImmatriculation formulaireFrance = new FormulaireImmatriculationFrance(htmlImpl);

                formulaireFrance.Afficher();
                formulaireFrance.Valider();

                Console.WriteLine();

                // Utilisation du formulaire Applet pour le Luxembourg
                IFormulaireImplementation appletImpl = new FormulaireImplementationApplet();
                FormulaireImmatriculation formulaireLux = new FormulaireImmatriculationLux(appletImpl);

                formulaireLux.Afficher();
                formulaireLux.Valider();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erreur : {ex.Message}");
            }
        }
    }
}
