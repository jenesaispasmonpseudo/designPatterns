# Exemple

Comment peut-on decorer un cafe avec du lait et du sucre ?

```c#

// Utilisation
ICafe monCafe = new CafeSimple();
monCafe = new Lait(monCafe);
monCafe = new Sucre(monCafe);

// Résultat : "Café simple + lait + sucre" - Prix : 2.7€

```
