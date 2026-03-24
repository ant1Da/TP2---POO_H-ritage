namespace TP2_POO_Héritage;

class Program
{
    static void Main(string[] args)
    {
        Personnage p1 = new Personnage("Lucas", 25);
        p1.Afficher();
        p1.recevoirDegats(25);
        p1.Afficher();
    }
}
