using WebAPIQuick.CalcParams;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebAPIQuick.Interfaces
{
    public interface IWolliesManager
    {
        Task<int> QuickMethod(CalcParams.CalcParams wolliesListFilter);
    }
}




