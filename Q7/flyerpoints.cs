using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q7
{
    internal class flyerpoints
    {
        public string Name { get; set; }
        public int Miles { get; set; }

        private int _frequentFlyerPoints;

        public int FrequentFlyerPoints
        {
            get { return _frequentFlyerPoints; }
            set {
                _frequentFlyerPoints = value;
                    
                if(Miles<10000)
                    _frequentFlyerPoints = 0;
                else if (Miles >= 10000 && Miles <20000)
                    _frequentFlyerPoints = 10;
                else if (Miles >= 20000 && Miles < 50000)
                    _frequentFlyerPoints = 20;
                else if (Miles >= 50000 && Miles<100000)
                    _frequentFlyerPoints = 30;
                else
                    _frequentFlyerPoints = 50;
                
                
            }
        }
    }
}
