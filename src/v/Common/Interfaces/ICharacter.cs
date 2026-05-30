namespace Common.Interfaces
{
    public interface ICharacter
    {
        string Name { get; }
        ICharacterClass CharacterClass { get; }
        ICharacterRace CharacterRace { get; }
    }
}
