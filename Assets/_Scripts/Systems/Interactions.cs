public class Interactions : Singleton<Interactions>
{
    public bool PlayerIsDragging { get; set; } = false;

    public bool PlayerCanInteract()
    {
        if (!ActionSystem.Instance.IsPerforming) return true;
        else return false;
    }

    public bool PlayerCanHover()
    {
        if (PlayerCanInteract()) return false;
        return true;
    }

}
