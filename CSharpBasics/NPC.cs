public class NPC : GameObject, IInteractable
{
    private bool wasInteractedWith = false;
    public bool WasInteractedWith { get { return wasInteractedWith; } set { wasInteractedWith = value; } }
    public NPC(string name) : base(name) { }

    public void Interact()
    {
        if (!WasInteractedWith)
        {
            Console.WriteLine($"{Name} NPC Starts a conversation....");
            WasInteractedWith = true;
        }
        else
        {
            Console.WriteLine($"{Name} says: \"Welcome Back Player! How may i help you.... ?\"");
        }

    }
}