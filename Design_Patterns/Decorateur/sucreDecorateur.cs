public class Sucre : CafeDecorator
{
    public Sucre(ICafe cafe) : base(cafe) { }

    public override double GetCost() => base.GetCost() + 0.2;
    public override string GetDescription() => base.GetDescription() + " + sucre";
}