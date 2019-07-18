
namespace Caterpillar.Volumes
{
    class NauticalUnit : Volume
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

namespace Caterpillar.Volumes
{
    public struct Nautical
    {
        public static readonly Nautical Empty;

        public static Unit NauticalMile { get { return new NauticalUnit("Cubic NauticalMile", "--", 6352000000.0); } }

    }

}