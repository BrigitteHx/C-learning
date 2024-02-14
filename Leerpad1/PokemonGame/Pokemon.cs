using System;

public class Pokemon
{
    private string nickname;
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
}

public enum PokemonType
{
    Fire,
    Grass,
    Water
}
