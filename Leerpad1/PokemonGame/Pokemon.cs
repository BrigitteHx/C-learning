using System;

public abstract class Pokemon
{
    protected string nickname;
    protected string strength;
    protected string weakness;

    public string Nickname { get { return nickname; } }
    public string Strength { get { return strength; } }
    public string Weakness { get { return weakness; } }

    public Pokemon(string nickname, string strength, string weakness)
    {
        this.nickname = nickname;
        this.strength = strength;
        this.weakness = weakness;
    }

    public abstract void BattleCryShout();
}