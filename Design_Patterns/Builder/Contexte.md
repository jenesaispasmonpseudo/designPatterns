Au moment de l'achat de vehicule, un commercial va creer une liasse de documents (bon de commande, demande d'immatriculation, certificat de cession, etc...). Ces documents sont disponibles au format PDF ou HTML selon le choix du client. Dans le premier , le client fournit une instance de la classe ConstructeurLiasseVehiculeHtml et dans le second cas, il fournit une instance de la classe ConstructeurLiasseVehiculePdf.
Dans un second temps le commercial effectue la demande de creation de chaque document de la liasse liee a l'instance.

Le vendeur cree alors les documents de la liasse a l'aide des methodes construitBonDeCommande et construitDemandeImmatriculation.
