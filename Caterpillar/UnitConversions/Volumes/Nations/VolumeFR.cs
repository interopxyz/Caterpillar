
namespace Caterpillar.Volumes
{
    class FRUnit : Volume
    {
        public FRUnit(string name, string abbreviation, double factor) : base()
        {
            this.system = Systems.FR;

            this.name = name;
            this.abbreviation = abbreviation;
            this.factor = factor;
        }

    }

}

namespace Caterpillar.Volumes
{
    public struct FR
    {
        public static readonly FR Empty;

        public static Unit Stere { get { return new FRUnit("Stere", "--", 1.0); } }
        public static Unit Minot { get { return new FRUnit("Minot", "--", 0.03808584); } }
        public static Unit Litron { get { return new FRUnit("Litron", "--", 0.000793455); } }

    }

}