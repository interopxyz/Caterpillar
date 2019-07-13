
namespace Caterpillar.Areas
{
    class NauticalUnit : Area
    {
        public NauticalUnit(string name, string abbreviation, double factor) : base()
        {
            this.system = Systems.Nautical;

            this.name = name;
            this.abbreviation = abbreviation;
            this.factor = factor;
        }
    }
}

namespace Caterpillar.Areas
{
    public struct Nautical
    {
        public static readonly Nautical Empty;

        public static Unit League { get { return new NauticalUnit("Square League", "lea2", 30869136.0); } }
        public static Unit Fathom { get { return new NauticalUnit("Square Fathom", " ", 3.3445228); } }
        public static Unit NauticalMile { get { return new NauticalUnit("Square Nautical Mile", " ", 3429904.0); } }

    }
}