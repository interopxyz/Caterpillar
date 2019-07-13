
namespace Caterpillar.Masses
{
    class USUnit : Mass
    {
        public USUnit(string name, string abbreviation, double factor) : base()
        {
            this.system = Systems.US;

            this.name = name;
            this.abbreviation = abbreviation;
            this.factor = factor;
        }

    }

}

namespace Caterpillar.Masses
{
    public struct US
    {
        public static readonly US Empty;

        public static Unit Grain { get { return new USUnit("Grain", "--", 0.06479891); } }
        public static Unit Drachm { get { return new USUnit("Drachm", "--", 3.8); } }
        public static Unit Ounce { get { return new USUnit("Ounce", "--", 28.349523125); } }
        public static Unit Pound { get { return new USUnit("Pound", "--", 453.59237); } }
        public static Unit Stone { get { return new USUnit("Stone", "--", 6350.29318); } }
        public static Unit Quarter { get { return new USUnit("Quarter", "--", 11339.80925); } }
        public static Unit HundredWeight { get { return new USUnit("Hundred Weight", "--", 45359.237); } }
        public static Unit Ton { get { return new USUnit("Ton", " ", 907184.74); } }

    }

}