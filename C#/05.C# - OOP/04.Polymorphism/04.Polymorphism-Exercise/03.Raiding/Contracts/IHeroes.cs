namespace Raiding.Contracts
{
    public interface IHeroes
    {
        string Name { get; }
        int Power { get; }
        string CastAbility();
    }
}
