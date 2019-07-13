
namespace Caterpillar.Areas
{
    class ESUnit : Area
    {
        public ESUnit(string name, string abbreviation, double factor) : base()
        {
            this.system = Systems.ES;

            this.name = name;
            this.abbreviation = abbreviation;
            this.factor = factor;
        }
    }
}

namespace Caterpillar.Areas
{
    public struct ES
    {
        public static readonly ES Empty;

        public static Unit SquareLeague { get { return new ESUnit("Square League", "", 17921100.0630715); } }
        public static Unit SquareVara { get { return new ESUnit("Square Vara", "", 0.716847316969525); } }
        public static Unit Caballeria { get { return new ESUnit("Caballeria", "", 400000.0); } }
        public static Unit Labor { get { return new ESUnit("Labor", "", 716849.98910388); } }

    }
}