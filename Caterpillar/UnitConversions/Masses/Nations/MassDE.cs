
namespace Caterpillar.Masses
{
    class DEUnit : Mass
    {
        public DEUnit(string name, string abbreviation, double factor) : base()
        {
            this.system = Systems.DE;

            this.name = name;
            this.abbreviation = abbreviation;
            this.factor = factor;
        }

    }

}

namespace Caterpillar.Masses
{
    public struct DE
    {
        public static readonly DE Empty;

        public static Unit Unze { get { return new DEUnit("Unze", "", 31.25); } }
        public static Unit Centner { get { return new DEUnit("Centner", "", 50000.0); } }
        public static Unit Gran { get { return new DEUnit("Gran", "", 0.82); } }
        public static Unit Pfund { get { return new DEUnit("Pfund", "", 500.0); } }
        public static Unit Mark { get { return new DEUnit("Mark", "", 280.5); } }
        public static Unit Lot { get { return new DEUnit("Lot", "", 15.0); } }
        public static Unit Last { get { return new DEUnit("Last", "", 453592.37); } }

    }


}