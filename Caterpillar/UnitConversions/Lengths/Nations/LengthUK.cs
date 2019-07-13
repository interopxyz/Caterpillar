
namespace Caterpillar.Lengths
{
    class UKUnit : Length
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

namespace Caterpillar.Lengths
{
    public struct UK
    {
        public static readonly UK Empty;

        public static Unit Microinch { get { return new UKUnit("Microinch", "uin", 0.0000000254); } }
        public static Unit Mil { get { return new UKUnit("Mil", " ", 0.0000254); } }
        public static Unit Line { get { return new UKUnit("Line", " ", 0.0021167); } }
        public static Unit Barleycorn { get { return new UKUnit("Barleycorn", " ", 0.0085); } }
        public static Unit Digit { get { return new UKUnit("Digit", " ", 0.019); } }
        public static Unit Nail { get { return new UKUnit("Nail", " ", 0.05715); } }
        public static Unit Hand { get { return new UKUnit("Hand", " ", 0.1016); } }
        public static Unit Finger { get { return new UKUnit("Finger", " ", 0.1143); } }
        public static Unit Link { get { return new UKUnit("Link", " ", 0.20116840234); } }
        public static Unit Span { get { return new UKUnit("Span", " ", 0.2286); } }
        public static Unit Palm { get { return new UKUnit("Palm", " ", 0.075); } }
        public static Unit Perch { get { return new UKUnit("Perch", " ", 5.0292); } }

    }
}