using System.Globalization;

namespace BlazingPizza;

/// <summary>
/// Represents a pre-configured template for a pizza a user can order
/// </summary>
public class PizzaSpecial
{
    public int Id { get; set; }

    public string Name { get; set; }

    public decimal BasePrice { get; set; }

    public string Description { get; set; }

    public string ImageUrl { get; set; }

    public string GetFormattedBasePrice() => FormatMxn(BasePrice);

    internal static string FormatMxn(decimal value)
    {
        var culture = (CultureInfo)CultureInfo.GetCultureInfo("es-MX").Clone();
        culture.NumberFormat.CurrencySymbol = "MX$";
        return value.ToString("C", culture);
    }
}