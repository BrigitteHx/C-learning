using System;

public class Charmander
{
    private string nickname;
    private string strength;
    private string weakness;

    public Charmander(string? nickname, string strength, string weakness)
    {
        this.nickname = nickname ?? throw new ArgumentNullException(nameof(nickname));
        this.strength = strength;
        this.weakness = weakness;
    }

    public void BattleCryShout()
    {
        Console.WriteLine($"{nickname} powerrr!");
    }

    public void ChangeTheNickname(string? newNickname)
    {
        if (newNickname != null)
        {
            this.nickname = newNickname;
        }
        else
        {
            Console.WriteLine("Nieuwe nickname kan niet null zijn.");
        }
    }
}
