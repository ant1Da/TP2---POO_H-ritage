class Guerrier: Personnage
{
    protected private int armure {get; set;}
    public Guerrier(string name, int pv, int armure):base(name,pv)
    {
        this.name = name;
        this.pointsDeVie = pv;
        this.armure = armure;
    }
    public int getArmure()
    {
        return this.armure;
    }
    public void Attaquer()
    {
        Console.WriteLine($"Le guerrier {this.getName} attaque.");
    }
    public override void Afficher()
    {
        Console.WriteLine($"Nom : {this.getName()} | Points de vie : {this.getPv()} | Armure : {this.getArmure()}");
    }
}