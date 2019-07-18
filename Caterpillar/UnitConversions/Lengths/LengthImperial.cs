
namespace Caterpillar.Lengths
{
    class ImperialUnit : Length
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

namespace Caterpillar.Lengths
{
    public struct Imperial
    {
        public static readonly Imperial Empty;

        public static Unit Microinch { get { return new ImperialUnit("Microinch", "mi", 0.0000000254); } }
        public static Unit Thou { get { return new ImperialUnit("Thou", "th", 0.0000254); } }
        public static Unit Inch { get { return new ImperialUnit("Inch", "in", 0.0254); } }
        public static Unit Mil { get { return new ImperialUnit("Mil", "--", 0.0000254); } }
        public static Unit Link { get { return new ImperialUnit("Link", "li", 0.20116840234); } }
        public static Unit Palm { get { return new ImperialUnit("Palm", "pa", 0.2286); } }
        public static Unit Foot { get { return new ImperialUnit("Foot", "ft", 0.3048); } }
        public static Unit Yard { get { return new ImperialUnit("Yard", "yd", 0.9144); } }
        public static Unit Rod { get { return new ImperialUnit("Rod", "rod", 5.0292); } }
        public static Unit Chain { get { return new ImperialUnit("Chain", "ch", 20.116840234); } }
        public static Unit Furlong { get { return new ImperialUnit("Furlong", "fu", 201.168); } }
        public static Unit Mile { get { return new ImperialUnit("Mile", "mi", 1609.344); } }
        public static Unit League { get { return new ImperialUnit("League", "lea", 4828.0417); } }

    }
}