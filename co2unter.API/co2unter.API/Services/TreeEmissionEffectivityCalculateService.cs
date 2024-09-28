using co2unter.API.Interfaces;
using co2unter.API.Models.Enums;

namespace co2unter.API.Services
{
    public class TreeEmissionEffectivityCalculateService : ITreeEmissionEffectivityCalculateService
    {
        public TreeEmissionEffectivityCalculateService()
        {

        }

        public async Task<int> CalculateCo2EmissionByParoid(TreeAgeEnum age, DateTimeOffset dateFrom, DateTimeOffset dateTo)
        {
            (int, int) treeEfectivity = GetTreeEfectivityPerYear(age);
            int treeYearEfectivityAverage = GetAverage(treeEfectivity);
            int calculatePeroidInHour = GetPeroidInHour(dateFrom, dateTo);

            return CalculateTreeEfectivityByPeroid(treeYearEfectivityAverage, calculatePeroidInHour);
        }

        public async Task<TimeSpan> CalculateTimeByWeight(TreeAgeEnum age, int co2Emission)
        {
            (int, int) treeEfectivity = GetTreeEfectivityPerYear(age);
            int treeYearEfectivityAverage = GetAverage(treeEfectivity);

            return await CalculateTimeEmissionByWeight(treeYearEfectivityAverage, co2Emission);
        }

        //in grams
        private (int, int) GetTreeEfectivityPerYear(TreeAgeEnum age)
        {
            switch (age)
            {
                case TreeAgeEnum.Short:
                    return (500, 5_000);
                case TreeAgeEnum.Medium:
                    return (20_000, 30_000);
                case TreeAgeEnum.Old:
                    return (22_000, 25_000);
                default:
                    throw new NotImplementedException("chuj Ci w dupe, nie dla psa ");
            }
        }

        private int GetAverage((int, int) treeEfectivity)
        {
            return (treeEfectivity.Item1 + treeEfectivity.Item2) / 2;
        }

        private int GetPeroidInHour(DateTimeOffset dateFrom, DateTimeOffset dateTo)
        {
            if (dateTo < dateFrom)
            {
                throw new ArgumentException($"{nameof(dateTo)} is less than {nameof(dateFrom)}");
            }

            var peroid = dateTo - dateFrom;
            return peroid.Hours;
        }

        private int CalculateTreeEfectivityByPeroid(int treeYearEfectivityAverage, int peroidInHour)
        {
            return (int)(GetEctivityPerHour(treeYearEfectivityAverage) * peroidInHour);
        }

        private async Task<TimeSpan> CalculateTimeEmissionByWeight(int treeYearEfectivityAverage, int co2Emission)
        {
            var timeInHours = co2Emission / GetEctivityPerHour(treeYearEfectivityAverage);
            return new TimeSpan(0, (int)timeInHours, 0, 0, 0, 0);
        }

        private static float GetEctivityPerHour(int treeYearEfectivityAverage)
        {
            return (float)treeYearEfectivityAverage / 365 / 24;
        }
    }
}