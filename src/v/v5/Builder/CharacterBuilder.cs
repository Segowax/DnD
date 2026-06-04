namespace v5.Builder
{
    public class CharacterBuilder : ICharacterBuilder
    {
        private readonly Character _character;

        public CharacterBuilder(Character character)
        {
            _character = character;
        }

        public void RandomizeClass()
        {
            throw new NotImplementedException();
        }

        public void RandomizeSpecies()
        {
            throw new NotImplementedException();
        }
    }
}
