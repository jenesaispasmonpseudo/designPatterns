# Introduction aux patterns de conception #

## 1.1 Pattern de conception ##

- Les patterns de conception sont des solutions a des problemes connus et frequents
- Emsemble de classes et de relation
- Dans le cadre la POO

## 1.2 Description des patterns de conception ##

- Le langage UML et le C# (java,...)
- Pour chaque pattern :
    Nom
    Description
    Exemple sous forme UML
    Structure générique du pattern
    Le cas d'utilisation
    Un exemple de code en C#
    (lien)
- Les patterns sont classés en 3 catégories :
- Creational (création)
- Structural (structuration)
- Behavioral (comportemental)

# Etude de cas : vente en ligne de véhicules #

- Vehicule destiné à la vente
- Catalogue
- Options
- Panier / gestion de commandes

# Introduction aux patterns de conception #

## Premier pattern AbstractFactoy ##

- Elle fournit une interface pour créer des familles d'objets liés ou inter-dépendants sans avoir à préciser au moment de leur création la classe concrète à utiliser

## Deuxieme pattern Builder ##

- Le pattern Builder (ou patron de conception Constructeur) est un design pattern de création qui permet de construire des objets complexes étape par étape. Il sépare la construction de l'objet de sa représentation afin que le même processus de construction puisse créer différentes représentations.

## Trosième pattern singleton ##

- Le singleton est un design pattern de création qui garantit qu’une classe n’a qu’une seule instance et fournit un point d’accès global à cette instance. Il est utile pour des ressources uniques comme un logger, une configuration globale ou une connexion à une base de données

## Quatrieme pattern prototype ##

- Le design pattern Prototype permet de créer des copies d'objet existant sans rendre le code dépendant de leurs classe concrètes. Au lieu de crée un objet à partir de zero on clone un objet existant (le prototype) et on le modifier si besoin.
- C'est comme faire une photocopie d'un document : on copie l'original et on peut modifier la copie 
- L'avantage principal est la création d'objet complexes simplifiée.
- Cas d'usage :
    Objets avec de nombreuse configuration (editeur graphique : formes géometriques)
    En jeux video, création d'enemies et leurs variation en grande quantité
    Création d'une configuration par défaut dans un jeu/logiciel
    Pour eviter la création d'objets systemes couteux : connexions réseau, ressources partagées...

## Cinquieme pattern Adapter ##

- Convertir l'interface d'une classe existante en une interface attendue par ses client (afin qu'il puisse travailler ensemble)
- Autrement dit c'est fournir une nouvelle interfaces pour repondre aux besoins de clients

## Sixieme pattern Bridge ##

- Separer l'aspect d'implementation d'un objet de son aspect representation et d'interface
- Il separe uen gross class en deux partie qui peuvent etre developpé independamment