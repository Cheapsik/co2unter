using co2unter.API.Models.Enums;

namespace co2unter.API.Interfaces
{
    public interface ITreeEmissionEffectivityCalculateService
    {
        public int CalculateCo2EmissionByParoid(TreeAgeEnum age, DateTimeOffset dateFrom, DateTimeOffset dateTo);
        public TimeSpan CalculateTimeByWeight(TreeAgeEnum age, int co2Emission);
    }
}
