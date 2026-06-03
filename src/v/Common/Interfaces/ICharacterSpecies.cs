namespace Common.Interfaces
{
    public interface ICharacterSpecies
    {
        string Name { get; }

        enum CommonCharacterSpecies
        {
            Human,
            Elf,
            Dwarf
        }
    }
}
