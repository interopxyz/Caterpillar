
namespace Caterpillar.Masses
{
    class UKUnit : Mass
    {
        public UKUnit(string name, string abbreviation, double factor) : base()
        {
            this.system = Systems.UK;

            this.name = name;
            this.abbreviation = abbreviation;
            this.factor = factor;
        }

    }

}

namespace Caterpillar.Masses
{
    public struct UK
    {
        public static readonly UK Empty;

        public static Unit LongTon { get { return new UKUnit("Long Ton", "", 1016046.9088); } }
        public static Unit HundredweightLong { get { return new UKUnit("Hundredweight (Long)", "", 50802.34544); } }
        public static Unit Mark { get { return new UKUnit("Mark", "", 226.8); } }
        public static Unit Carat { get { return new UKUnit("Carat", "", 0.25919564); } }
        public static Unit Bale { get { return new UKUnit("Bale", "", 326586.5064); } }
        public static Unit Sack { get { return new UKUnit("Sack", "", 165107.62268); } }
        public static Unit Quarter { get { return new UKUnit("Quarter", "", 12700.58636); } }
        public static Unit Stone { get { return new UKUnit("Stone", "", 6350.29318); } }
        public static Unit Pound { get { return new UKUnit("Pound", "", 453.59237); } }
        public static Unit Ounce { get { return new UKUnit("Ounce", "", 28.349523125); } }
        public static Unit Dram { get { return new UKUnit("Dram", "", 1.7718451953); } }
        public static Unit Grain { get { return new UKUnit("Grain", "", 0.06479891); } }

    }


}