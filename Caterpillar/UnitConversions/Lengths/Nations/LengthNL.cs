
namespace Caterpillar.Lengths
{
    class NLUnit : Length
    {
        public NLUnit(string name, string abbreviation, double factor) : base()
        {
            this.system = Systems.NL;

            this.name = name;
            this.abbreviation = abbreviation;
            this.factor = factor;
        }
    }
}

namespace Caterpillar.Lengths
{
    public struct NL
    {
        public static readonly NL Empty;

        public static Unit Ell { get { return new NLUnit("Ell", " ", 0.68999998206); } }
        public static Unit Foot { get { return new NLUnit("Foot", " ", 0.283129996448134); } }
        public static Unit Palm { get { return new NLUnit("Palm", " ", 0.1); } }

    }
}