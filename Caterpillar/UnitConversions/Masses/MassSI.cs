
namespace Caterpillar.Masses
{
    class SIUnit : Mass
    {
        public SIUnit(string name, string abbreviation, double factor) : base()
        {
            this.system = Systems.SI;

            this.name = name;
            this.abbreviation = abbreviation;
            this.factor = factor;
        }

    }

}

namespace Caterpillar.Masses
{
    public struct SI
    {
        public static readonly SI Empty;

        public static Unit Yoctogram { get { return new SIUnit("Yoctogram", "--", 0.000000000000000000000001); } }
        public static Unit Zeptogram { get { return new SIUnit("Zeptogram", "--", 0.000000000000000000001); } }
        public static Unit Attogram { get { return new SIUnit("Attogram", "--", 0.000000000000000001); } }
        public static Unit Femtogram { get { return new SIUnit("Femtogram", "--", 0.000000000000001); } }
        public static Unit Picogram { get { return new SIUnit("Picogram", "--", 0.000000000001); } }
        public static Unit Nanogram { get { return new SIUnit("Nanogram", "--", 0.000000001); } }
        public static Unit Microgram { get { return new SIUnit("Microgram", "--", 0.000001); } }
        public static Unit Milligram { get { return new SIUnit("Milligram", "mg", 0.001); } }
        public static Unit Centigram { get { return new SIUnit("Centigram", "cg", 0.01); } }
        public static Unit Decigram { get { return new SIUnit("Decigram", "dg", 0.1); } }
        public static Unit Gram { get { return new SIUnit("Gram", "g", 1.0); } }
        public static Unit Decagram { get { return new SIUnit("Decagram", "dag", 10.0); } }
        public static Unit Hectogram { get { return new SIUnit("Hectogram", "hg", 100.0); } }
        public static Unit Kilogram { get { return new SIUnit("Kilogram", "kg", 1000.0); } }
        public static Unit Megagram { get { return new SIUnit("Megagram", "--", 1000000.0); } }
        public static Unit Gigagram { get { return new SIUnit("Gigagram", "--", 1000000000.0); } }
        public static Unit Teragram { get { return new SIUnit("Teragram", "--", 1000000000000.0); } }
        public static Unit Petagram { get { return new SIUnit("Petagram", "--", 1000000000000000.0); } }
        public static Unit Exagram { get { return new SIUnit("Exagram", "--", 1000000000000000000.0); } }
        public static Unit Zettagram { get { return new SIUnit("Zettagram", "--", 1000000000000000000000.0); } }
        public static Unit Yottagram { get { return new SIUnit("Yottagram", "--", 1000000000000000000000000.0); } }

    }


}