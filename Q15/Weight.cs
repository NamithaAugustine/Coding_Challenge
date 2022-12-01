using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q15
{
    internal class Weight
    {
        public int ExtraWeight { get; set; }
        private int _payment;
        public int Payment { 
            get { return _payment;}
            set { 
                _payment = value;
                if(ExtraWeight>23)
                    _payment += ((ExtraWeight - 23) * 15);
            }
        }
    }
}
