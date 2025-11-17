//ресурс-общо количество
Dictionary<string, int> resourceQuantity = new Dictionary<string, int>();
string resource = Console.ReadLine();

while(resource != "stop")
{
    int quantity = int.Parse(Console.ReadLine());
    if (!resourceQuantity.ContainsKey(resource))//ако не сме го срещали
    {
        resourceQuantity.Add(resource, quantity);
    }
    else
    {
        resourceQuantity[resource] += quantity;
    }

        resource = Console.ReadLine();
}

foreach(KeyValuePair<string, int> pair in resourceQuantity)
{
    //pair
    //pair.Key - ресурс
    //pair.Value - количество
    Console.WriteLine(pair.Key + " -> " + pair.Value);

}