public abstract class GameObject
{

    public string Name { get; set; }

    public GameObject(string name)
    {
        Name = name;
    }
}