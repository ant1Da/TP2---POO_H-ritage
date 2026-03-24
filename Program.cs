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
        }
    }
}
