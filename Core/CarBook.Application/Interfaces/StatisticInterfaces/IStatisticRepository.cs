using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Interfaces.StatisticInterfaces
{
    public interface IStatisticRepository
    {
        int GetCarCount();
        int GetLocationCount();
        int GetAuthorCount();
        int GetBlogCount();
        int GetBrandCount(); 
        int GetGasolineCarCount();
        int GetDieselCarCount();
        int GetHybridCarCount();
        int GetLowKilometterCarCount();
        int GetAutoTransmissionCarCount();
        decimal GetAvgRentPriceDaily();
        decimal GetAvgRentPriceWeekly();
        decimal GetAvgRentPriceMonthly();
        string GetBrandMostCars();
        string GetMostCommentedBlogTitle();
        string GetCheapestCarModel();
        string GetMostExpensiveCarModel();
    }
}
