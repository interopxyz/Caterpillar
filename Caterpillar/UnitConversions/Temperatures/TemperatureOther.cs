
namespace Caterpillar.Temperatures
{
    class OtherUnit : Temperature
    {
        public OtherUnit(string name, string abbreviation, double factor) : base()
        {
            this.system = Systems.None;

            this.name = name;
            this.abbreviation = abbreviation;
            this.factor = factor;
        }

    }

}

namespace Caterpillar.Temperatures
{
    public struct Other
    {
        public static readonly Other Empty;

        public static Unit Rankine { get { return new OtherUnit("Rankine", "Ra", 0.55555555555556); } }
        public static Unit Delisle { get { return new OtherUnit("Delisle", "D", 372.48333333333); } }
        public static Unit Newton { get { return new OtherUnit("Newton", "N", 276.1803030303); } }
        public static Unit Reaumur { get { return new OtherUnit("Reaumur", "R", 274.4); } }
        public static Unit Romer { get { return new OtherUnit("Romer", "Ro", 260.76904761905); } }

    }

}