
namespace Caterpillar.Areas
{
    class ImperialUnit : Area
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

namespace Caterpillar.Areas
{
    public struct Imperial
    {
        public static readonly Imperial Empty;

        public static Unit Microinch { get { return new ImperialUnit("Square Microinch", "mi2", 0.00000000000000064516); } }
        public static Unit Thou { get { return new ImperialUnit("Square Thou", "th2", 0.00000000064516); } }
        public static Unit Inch { get { return new ImperialUnit("Square Inch", "in2", 0.00064516); } }
        public static Unit Mil { get { return new ImperialUnit("Square Mil", "--2", 0.00000000064516); } }
        public static Unit Link { get { return new ImperialUnit("Square Link", "li2", 0.040468726); } }
        public static Unit Foot { get { return new ImperialUnit("Square Foot", "ft2", 0.09290304); } }
        public static Unit Yard { get { return new ImperialUnit("Square Yard", "yd2", 0.83612736); } }
        public static Unit Rod { get { return new ImperialUnit("Square Rod", "rod2", 25.292953917); } }
        public static Unit Chain { get { return new ImperialUnit("Square Chain", "ch2", 404.68726); } }
        public static Unit Furlong { get { return new ImperialUnit("Square Furlong", "fu2", 40468.726); } }
        public static Unit Mile { get { return new ImperialUnit("Square Mile", "mi2", 2589988.1103); } }
        public static Unit League { get { return new ImperialUnit("Square League", "lea2", 23309986.0); } }
        public static Unit Acre { get { return new ImperialUnit("Acre", "ac", 4046.8564224); } }

    }
}