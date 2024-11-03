public class TreasureChest : GameObject, IInteractable
{
    private bool isOpened = false;
    public bool IsOpened { get { return isOpened; } set { isOpened = value; } }

    public TreasureChest(string name) : base(name) { }

    public void Interact()
    {
        if (IsOpened)
        {
            Console.WriteLine($"{Name} has already been opened, it is Empty!!");
        }
        else
        {
            Console.WriteLine($"{Name} is opening.... !!");
            IsOpened = true;
        }

    }
}