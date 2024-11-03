internal class Program
{
    private static void Main(string[] args)
    {
        Car car1 = new Car();
        car1.Model = "Toyota";
        car1.Year = 2020;
        car1.Color = "red";

        Car car2 = new()
        {
            Model = "Honda",
            Year = 2018
        };

        Car car3 = new()
        {
            Model = "Mercedes",
            Year = 2024,
            Color = "Black"
        };

        Car car4 = new()
        {
            Model = "Volks Wagon",
            Year = 1884,
        };

        // Print details and call the Drive method
        Console.WriteLine($"{car1.Color} {car1.Model}, {car1.Year}");
        car1.Drive();

        Console.WriteLine($"{car2.Color} {car2.Model}, {car2.Year}");
        car2.Drive();

        Console.WriteLine($"{car3.Color} {car3.Model}, {car3.Year}");
        car3.Drive();
        car3.Honk();

        Console.WriteLine($"{car4.Color} {car4.Model}, {car4.Year}");
        car4.Drive();

        Book book1 = new() { Title = "The Great Gatsby", Author = "F. Scott Fitzgerald", Pages = 180 };
        book1.CheckOut();
        book1.CheckOut();
        book1.ReturnBook();

        BankAccount account = new BankAccount("John Doe", "123456789");

        Console.WriteLine($"Account Holder: {account.AccountHolder}");
        Console.WriteLine($"Account Number: {account.AccountNumber}");

        // Deposit money
        account.Deposit(1000m);
        Console.WriteLine($"Balance after deposit: {account.GetBalance()}");

        // Attempt to withdraw within balance
        account.Withdraw(500m);
        Console.WriteLine($"Balance after withdrawal: {account.GetBalance()}");

        // Attempt to withdraw more than balance
        account.Withdraw(700m);
        Console.WriteLine($"Balance after overdraw attempt: {account.GetBalance()}");

        // Create a list of IInteractable objects
        List<IInteractable> interactables = new List<IInteractable>
        {
            new Door("Ancient Door"),
            new TreasureChest("Old Treasure Chest"),
            new NPC("Friendly Villager")
        };

        // Loop through each interactable object and call Interact
        foreach (IInteractable item in interactables)
        {
            item.Interact();
        }
        Console.WriteLine("After a While...");
        foreach (IInteractable item in interactables)
        {
            item.Interact();
        }
    }
}