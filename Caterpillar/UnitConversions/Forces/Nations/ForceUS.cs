
namespace Caterpillar.Forces
{
    class USUnit : Force
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

namespace Caterpillar.Forces
{
    public struct US
    {
        public static readonly US Empty;

        public static Unit Kip { get { return new USUnit("Kip", " ", 4448.2216); } }
        public static Unit TonForceShort { get { return new USUnit("Ton Force Short", " ", 8896.4432); } }

    }
}