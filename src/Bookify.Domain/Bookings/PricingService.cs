namespace Bookify.Domain.Bookings;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bookify.Domain.Apartments;
using Bookify.Domain.Shared;

public class PricingService
{
    public PricingDetails CalculatePrice(Apartment apartment, DateRange period)
    {
        Currency? currency = apartment.Price.Currency;

        Money priceForPeriod = new(
            apartment.Price.Amount * period.LengthInDays,
            currency);

        decimal percentageUpCharge = 0;

        foreach(var amenity in apartment.Amenities)
        {
            percentageUpCharge += amenity switch
            {
                Amenity.GardenView or Amenity.MountainView => 0.05m,
                Amenity.AirConditioning => 0.01m,
                Amenity.Parking => 0.01m,
                _ => 0
            };
        }

        Money amenitiesUpCharge = Money.Zero(currency);
        if (percentageUpCharge > 0)
        {
            amenitiesUpCharge = new(
                priceForPeriod.Amount * percentageUpCharge,
                currency);
        }

        Money totalPrice = Money.Zero();
        totalPrice += priceForPeriod;

        if(!apartment.CleaningFee.IsZero())
        {
            totalPrice += apartment.CleaningFee;
        }

        totalPrice += amenitiesUpCharge;

        return new(priceForPeriod, apartment.CleaningFee, amenitiesUpCharge, totalPrice);
    }
}
