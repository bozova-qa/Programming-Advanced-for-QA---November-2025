using System.Collections.Generic;
using System.Text;

namespace TestApp;

public class Orders
{
    public static string Order(params string[] input)
    {
        Dictionary<string, decimal[]> products = new();

        foreach (string s in input)
        {
            string[] data = s.Split();// "apple 2.50 2" -> "apple", "2.50", "2"

            string product = data[0];
            decimal price = decimal.Parse(data[1]);
            decimal quantity = decimal.Parse(data[2]);

            products.TryAdd(product, new[] { (decimal)0.0, (decimal)0.0 });
            products[product][1] += quantity;//update (add) quantity
            products[product][0] = price;//set new price
        }

        StringBuilder sb = new();
        foreach (KeyValuePair<string, decimal[]> pair in products)
        {
            decimal totalPrice = pair.Value[1] * pair.Value[0];
            sb.AppendLine($"{pair.Key} -> {totalPrice:f2}");
        }

        return sb.ToString().Trim();
    }
}
