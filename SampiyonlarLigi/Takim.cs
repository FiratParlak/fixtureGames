using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampiyonlarLigi
{
    class Takim
    {
        private string TakimIsmi;
        private string TakimUlke;
        
        public Takim(string Tisim,string Tulke)
        {
             this.TakimIsmi = Tisim;
             this.TakimUlke = Tulke;
            
        }
        public string TeamName
        {
            get { return TakimIsmi; }
            set { TakimIsmi=value; }
        }

        public string TeamCountry
        {
            get { return TakimUlke; }
            set { TakimUlke=value;}
        }
        public override string ToString()
        {
            return TakimIsmi + "-" + TakimUlke;
        }
    }
}
