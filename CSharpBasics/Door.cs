public class Door : GameObject, IInteractable
{
    private bool isOpened = false;
    public bool IsOpened { get { return isOpened; } set { isOpened = value; } }
    public Door(string name) : base(name) { }

    public void Interact()
    {
        if (IsOpened)
        {
            Console.WriteLine($"{Name} was opened, now closing.....!!");
        }
        else
        {
            Console.WriteLine($"{Name} opening ...");
            IsOpened = true;
        }
    }
}