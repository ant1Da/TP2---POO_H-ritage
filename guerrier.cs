class Guerrier: Personnage
{
    protected int armure;
    public Guerrier(string name, int pv, int armure):base(name,pv)
    {
        this.name = name;
        this.pointsDeVie = pv;
        this.armure = armure;
    }
}