using System;

namespace zad3_GitHub.Calculation
{
    public sealed record CalculationResult(decimal TotalVolume, decimal PureSubstanceVolume)
    {
        public override string ToString() =>
            $"TotalVolume = {TotalVolume}, PureSubstanceVolume = {PureSubstanceVolume}";
    }
}