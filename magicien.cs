class Magicien: Personnage
{
    protected private int puissanceMagique {get; set;}
    public Magicien(string name, int pv, int puissanceMagique):base(name,pv)
    {
        this.name = name;
        this.pointsDeVie = pv;
        this.puissanceMagique = puissanceMagique;
    }
    public int getPuissanceMagique()
    {
        return this.puissanceMagique;
    }
    public override void Afficher()
    {
        Console.WriteLine($"Nom : {this.getName()} | Points de vie : {this.getPv()} | Puissance Magique : {this.getPuissanceMagique()}");
    }
}