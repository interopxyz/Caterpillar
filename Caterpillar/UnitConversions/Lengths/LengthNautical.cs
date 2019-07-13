
namespace Caterpillar.Lengths
{
    class NauticalUnit : Length
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

namespace Caterpillar.Lengths
{
    public struct Nautical
    {
        public static readonly Nautical Empty;

        public static Unit League { get { return new NauticalUnit("League", "lea", 5556.0); } }
        public static Unit Fathom { get { return new NauticalUnit("Fathom", "ftm", 1.8288); } }
        public static Unit Cable { get { return new NauticalUnit("Cable", "ca", 185.2); } }
        public static Unit NauticalMile { get { return new NauticalUnit("Nautical Mile", "M", 1852.0); } }

    }
}