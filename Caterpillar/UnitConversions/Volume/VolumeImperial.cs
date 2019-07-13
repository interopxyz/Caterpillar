
namespace Caterpillar.Volumes
{
    class ImperialUnit : Volume
    {
        public ImperialUnit(string name, string abbreviation, double factor) : base()
        {
            this.system = Systems.Imperial;

            this.name = name;
            this.abbreviation = abbreviation;
            this.factor = factor;
        }

    }

}

namespace Caterpillar.Volumes
{
    public struct Imperial
    {
        public static readonly Imperial Empty;

        public static Unit Thou { get { return new ImperialUnit("Cubic Thou", "--", 0.000000000000016387064); } }
        public static Unit Inch { get { return new ImperialUnit("Cubic Inch", "in", 0.000016387064); } }
        public static Unit Foot { get { return new ImperialUnit("Cubic Foot", "ft", 0.0283168); } }
        public static Unit Yard { get { return new ImperialUnit("Cubic Yard", "--", 0.764555); } }
        public static Unit Rod { get { return new ImperialUnit("Cubic Rod", "--", 127.203); } }
        public static Unit Chain { get { return new ImperialUnit("Cubic Chain", "--", 8140.98); } }
        public static Unit Furlong { get { return new ImperialUnit("Cubic Furlong", "--", 8141000.0); } }
        public static Unit Mile { get { return new ImperialUnit("Cubic Mile", "--", 4168181825.4); } }
        public static Unit League { get { return new ImperialUnit("Cubic League", "--", 171500000000.0); } }

    }

}