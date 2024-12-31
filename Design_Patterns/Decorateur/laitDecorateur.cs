public class Lait : CafeDecorator
{
    public Lait(ICafe cafe) : base(cafe) { }

    public override double GetCost() => base.GetCost() + 0.5;
    public override string GetDescription() => base.GetDescription() + " + lait";
}