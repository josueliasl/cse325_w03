using System.Globalization;

namespace BlazingPizza;

public class Order
{
    public int OrderId { get; set; }

    public string UserId { get; set; }

    public DateTime CreatedTime { get; set; }

    public List<Pizza> Pizzas { get; set; } = new List<Pizza>();

    public decimal GetTotalPrice()
    {
        decimal total = 0;
        foreach (var pizza in Pizzas)
        {
            total += pizza.GetTotalPrice();
        }
        return total;
    }

    public string GetFormattedTotalPrice() => PizzaSpecial.FormatMxn(GetTotalPrice());
}