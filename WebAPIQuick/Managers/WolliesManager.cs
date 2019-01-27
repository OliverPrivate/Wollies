using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPIQuick.Interfaces;
using WebAPIQuick.CalcParams;

namespace WebAPIQuick.Managers
{
    public class WolliesManager : IWolliesManager
    {

       
        
        public WolliesManager()
        {
           
        }

       

        public async Task<int> QuickMethod(CalcParams.CalcParams wolliesListFilter)
        {
            int cal = (int)wolliesListFilter.firstNum + (int)wolliesListFilter.secondNum;

            return cal;
        }

    }
}
