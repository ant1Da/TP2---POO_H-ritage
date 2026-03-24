namespace TP2_POO_Héritage;

class Program
{
    static void Main(string[] args)
    {
        Personnage p1 = new Personnage("Lucas", 25);
        p1.Afficher();
        p1.recevoirDegats(25);
        p1.Afficher();

        Personnage p2 = new Guerrier("Louis", 150, 50);
        Personnage p3 = new Magicien("Romain", 125, 50);
        List<Personnage> Personnages = new List<Personnage>();
        Personnages.Add(p2);
        Personnages.Add(p3);
        foreach (Personnage p in Personnages)
        {
            p.Afficher();
            if (p is Magicien magicien)
            {
                magicien.LancerSort();
            }
            if (p is Guerrier guerrier)
            {
                guerrier.Attaquer();
            }
        }
    }
}

// Surcharge ca tu modifies la signature(nom,paramètres) de la méthode. La redéfinition consiste à réimplémenter différemment la même méthode dans une classe héritant
// virtual et override permettent un ordre de priorité des méthodes selon la classe de l'objet utilisant la méthode.
// le polymorphisme permet de créer des méthodes similaires mais de les personalliser aux classes héritées afin d'être plus spécifique selon la classe
// car la classe de l'objet peut être pas la bonne
// cela permet de vérifier que les méthodes utilisées par les objets de la bonne classe