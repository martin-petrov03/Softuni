using System;
using System.Collections.Generic;
using System.Text;

public enum SeasonMultiplier
{
    Autumn = 1,
    Spring,
    Winter,
    Summer
}

public enum DiscountPercentage
{
    None,
    SecondVisit = 10,
    VIP = 20
}

public class PriceCalculator
{
    private decimal pricePerNight;
    private int nights;
    private SeasonMultiplier seasonMultiplier;
    private DiscountPercentage discountPercentage;

    public PriceCalculator(string[] commandArgs)
    {
        pricePerNight = decimal.Parse(commandArgs[0]);
        nights = int.Parse(commandArgs[1]);
        seasonMultiplier = Enum.Parse<SeasonMultiplier>(commandArgs[2]);
        discountPercentage = DiscountPercentage.None;

        if (commandArgs.Length == 4)
        {
            discountPercentage = Enum.Parse<DiscountPercentage>(commandArgs[3]);
        }
    }

    public decimal GetTotalPrice()
    {
        decimal basePrice = pricePerNight * nights * (int)seasonMultiplier;

        return basePrice - basePrice * (decimal)discountPercentage / 100;
    }
}