
namespace Caterpillar.Volumes
{
    class OtherUnit : Volume
    {
        public OtherUnit(string name, string abbreviation, double factor) : base()
        {
            this.system = Systems.None;

            this.name = name;
            this.abbreviation = abbreviation;
            this.factor = factor;
        }

    }

}

namespace Caterpillar.Volumes
{
    public struct Other
    {
        public static readonly Other Empty;

        public static Unit Dram { get { return new OtherUnit("Dram", "--", 0.0000036966911953); } }

    }

}