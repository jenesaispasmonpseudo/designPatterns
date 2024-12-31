public abstract class CafeDecorator : ICafe
{
    protected ICafe cafe;

    public CafeDecorator(ICafe cafe)
    {
        this.cafe = cafe;
    }

    public virtual double GetCost() => cafe.GetCost();
    public virtual string GetDescription() => cafe.GetDescription();
}