public class Book
{
    public string? Title { set; get; }
    public string? Author { set; get; }
    private int pages;
    public int Pages
    {
        get { return pages; }
        set
        {
            if (value < 0)
            {
                Console.WriteLine("Pages must be greater than 0.");
            }
            else
            {
                pages = value;
            }
        }
    }
    private bool isAvailable = true;

    public bool IsAvailable
    {
        set
        {
            isAvailable = value;
        }
        get
        {
            return isAvailable;
        }
    }

    public void CheckOut()
    {
        if (IsAvailable)
        {
            Console.WriteLine($"{Title} checked out.");
            IsAvailable = false;
        }
        else
        {
            Console.WriteLine($"{Title} is not available.");
        }

    }

    public void ReturnBook()
    {
        if (IsAvailable == false)
        {
            Console.WriteLine($"{Title} returned.");
            IsAvailable = true;
        }
        else
        {
            Console.WriteLine($"{Title} is already available.");
        }
    }
}