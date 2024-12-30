using System;

public class ScooterElectricite : Scooter
{
  public ScooterElectricite(string modele, string couleur,
    int puissance) : base(modele, couleur, puissance){}

  public override void afficheCaracteristiques()
  {
    Console.WriteLine("Scooter �lectrique, de mod�le : " +
      modele + ", de couleur : " + couleur + 
      ", de puissance : " + puissance);
  }

}
