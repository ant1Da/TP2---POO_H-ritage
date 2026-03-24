class Personnage
{
    protected private string name {get; set;}
    protected private int pointsDeVie{get; set;}
    public string getName()
    {
        return this.name;
    }
    public int getPv()
    {
        return this.pointsDeVie;
    }
    public Personnage(string Name, int PointsDeVie)
    {
        this.name = Name;
        this.pointsDeVie = PointsDeVie;
    }
    public void recevoirDegats(int d)
    {
        this.pointsDeVie -= d;
    }
    public void Afficher()
    {
        Console.WriteLine($"Nom : {this.getName()} | Points de vie : {this.getPv()}.");
    }
}