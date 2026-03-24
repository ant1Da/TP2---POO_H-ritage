class Archer: Personnage
{
    protected private int Précision {get; set;}
    public Archer(string name, int pv, int Précision):base(name,pv)
    {
        this.name = name;
        this.pointsDeVie = pv;
        this.Précision = Précision;
    }
    public int getPrécision()
    {
        return this.Précision;
    }
    public void Tirer()
    {
        Console.WriteLine($"L'archer {this.getName} lance un sort.");
    }
    public override void Afficher()
    {
        Console.WriteLine($"Nom : {this.getName()} | Points de vie : {this.getPv()} | Puissance Magique : {this.getPrécision()}");
    }
}