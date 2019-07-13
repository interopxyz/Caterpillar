
namespace Caterpillar.Lengths
{
    class RUUnit : Length
    {
        public RUUnit(string name, string abbreviation, double factor) : base()
        {
            this.system = Systems.RU;

            this.name = name;
            this.abbreviation = abbreviation;
            this.factor = factor;
        }
    }
}

namespace Caterpillar.Lengths
{
    public struct RU
    {
        public static readonly RU Empty;

        public static Unit Mile { get { return new RUUnit("Mile", " ", 7467.6); } }
        public static Unit Versta { get { return new RUUnit("Versta", " ", 1066.8); } }
        public static Unit Sazhen { get { return new RUUnit("Sazhen", " ", 2.1336); } }
        public static Unit Arshin { get { return new RUUnit("Arshin", " ", 0.7112); } }
        public static Unit Dra { get { return new RUUnit("Dra", " ", 1); } }
        public static Unit Ell { get { return new RUUnit("Ell", " ", 1); } }
        public static Unit Foot { get { return new RUUnit("Foot", " ", 0.3048); } }
        public static Unit Pyad { get { return new RUUnit("Pyad", " ", 0.1778); } }
        public static Unit Vershok { get { return new RUUnit("Vershok", " ", 1); } }
        public static Unit Inch { get { return new RUUnit("Inch", " ", 0.00254); } }
        public static Unit Line { get { return new RUUnit("Line", " ", 0.00254); } }

    }
}