using System;

public class Pokeball
{
    private bool isOpen;
    private Charmander charmander;

    public Pokeball(Charmander charmander)
    {
        this.charmander = charmander;
        this.isOpen = false;
    }

    public void ThrowPokeball()
    {
        Console.WriteLine("The pokeball releases Charmander!");
        charmander.BattleCryShout();
        isOpen = true;
    }

    public void ReturnCharmander()
    {
        Console.WriteLine("Charmander returns to the pokeball.");
        isOpen = false;
    }

    public bool IsOpen()
    {
        return isOpen;
    }
}
