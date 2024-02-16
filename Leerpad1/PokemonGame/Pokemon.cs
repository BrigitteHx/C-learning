using System; 

public enum PokemonType
{
    Fire,
    Grass,
    Water
}

public class Pokemon
{
    private string nickname = null!;
    private PokemonType strength;
    private PokemonType weakness;

    public string Nickname
    {
        get { return nickname; }
        private set { nickname = value; }
    }

    public PokemonType Strength
    {
        get { return strength; }
        private set { strength = value; }
    }

    public PokemonType Weakness
    {
        get { return weakness; }
        private set { weakness = value; }
    }

    public Pokemon(string nickname, PokemonType strength, PokemonType weakness)
    {
        this.Nickname = nickname;
        this.Strength = strength;
        this.Weakness = weakness;
    }

    public override string ToString()
    {
        return $"{Nickname} (Strength: {Strength}, Weakness: {Weakness})";
    }

    public virtual void BattleCryShout()
    {
        // empty so no overriden
    }
}
