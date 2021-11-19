using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trekkers
{
    class Trekker
    {

        private string _merk = "";
        private string _type = "";
        private int _vermogen = 0;
        private double _prijs = 0.0;


        public Trekker(string merk, string type, int vermogen, double prijs)
        {
            this._merk = merk;
            this._type = type;
            this._vermogen = vermogen;
            this._prijs = prijs;
        }


        public Trekker(Trekker trekker)
        {
            this._merk = trekker._merk;
            this._type = trekker._type;
            this._vermogen = trekker._vermogen;
            this._prijs = trekker._prijs;
        }

        public override string ToString()
        {
            return this._merk + " ; " + this._type + " ; " + this._vermogen + "PK" + " ; " + this._prijs;
        }
    }
}
