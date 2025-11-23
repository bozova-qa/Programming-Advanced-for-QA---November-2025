string input = Console.ReadLine();

List<Box> boxes = new List<Box>();

while (input != "end")
{
    string[] inputData = input.Split(" ");
    int serialNumber = int.Parse(inputData[0]);
    string itemName = inputData[1];
    int itemQuantity = int.Parse(inputData[2]);
    double itemPrice = double.Parse(inputData[3]);

    Item item = new Item(itemName, itemPrice);

    Box currentBox = new Box(serialNumber, item, itemQuantity);
    boxes.Add(currentBox);

    input = Console.ReadLine();
}

List<Box> orderedBoxes = boxes.OrderByDescending(b => b.PriceForABox).ToList();

foreach (Box box in orderedBoxes)
{
    Console.WriteLine($"{box.SerialNumber}");
    Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:F2}: {box.ItemQuantity}");
    Console.WriteLine($"-- ${box.PriceForABox:F2}");
}
class Item
{
    public Item(string name, double price)
    {
        Name = name;
        Price = price;
    }

    public string Name { get; set; }

    public double Price { get; set; }
}

class Box
{
    public Box(int serialNumber, Item item, int itemQuantity)
    {
        SerialNumber = serialNumber;
        Item = item;
        ItemQuantity = itemQuantity;
        
    }

    public int SerialNumber { get; set; }
    public Item Item { get; set; }
    public int ItemQuantity { get; set; }

    public double PriceForABox => ItemQuantity * Item.Price;

}