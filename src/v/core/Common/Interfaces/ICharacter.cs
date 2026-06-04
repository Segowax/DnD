namespace Common.Interfaces
{
    public interface ICharacter
    {
        string Name { get; }
        ICharacterSpecies Species { get; }
        ICharacterClass Class { get; }
    }
}
