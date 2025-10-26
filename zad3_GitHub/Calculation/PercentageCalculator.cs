using System;
using System.Globalization;

namespace zad3_GitHub.Calculation
{
    public static class PercentageCalculator
    {
        public static CalculationResult Calculate(decimal capacityPerContainer, decimal percent, int containerCount)
        {
            if (capacityPerContainer < 0)
                throw new ArgumentOutOfRangeException(nameof(capacityPerContainer), "Capacity can't be below zero -.- .");
            if (percent < 0 || percent > 100)
                throw new ArgumentOutOfRangeException(nameof(percent), "% needs to be between 0-100 -.- .");
            if (containerCount < 0)
                throw new ArgumentOutOfRangeException(nameof(containerCount), "Amount of containers can't be below 0 -.- .");

            decimal totalVolume = capacityPerContainer * containerCount;
            decimal pureVolume = decimal.Multiply(totalVolume, percent) / 100m;

            return new CalculationResult(totalVolume, pureVolume);
        }

        public static bool TryParseAndCalculate(
            string capacityText,
            string percentText,
            string countText,
            out CalculationResult? result,
            out string? errorMessage)
        {
            result = null;
            errorMessage = null;

            var culture = CultureInfo.CurrentCulture;
            if (!decimal.TryParse(capacityText, NumberStyles.Number, culture, out var capacity))
            {
                errorMessage = "Wrong capacity -.-";
                return false;
            }

            if (!decimal.TryParse(percentText, NumberStyles.Number, culture, out var percent))
            {
                errorMessage = "Wrong % -.- ";
                return false;
            }

            if (!int.TryParse(countText, NumberStyles.Integer, culture, out var count))
            {
                errorMessage = "Wrong amount of containers -.-";
                return false;
            }
            if (capacity < 0)
            {
                errorMessage = "Capacity can't be below 0 -.-";
                return false;
            }

            if (percent < 0 || percent > 100)
            {
                errorMessage = "% needs to be between 0-100 -.- ";
                return false;
            }

            if (count < 0)
            {
                errorMessage = "Amount of containers can't be below 0 -.-.";
                return false;
            }

            result = Calculate(capacity, percent, count);
            return true;
        }
    }
}