
namespace Caterpillar.Areas
{
    class DEUnit : Area
    {
        public DEUnit(string name, string abbreviation, double factor) : base()
        {
            this.system = Systems.DE;

            this.name = name;
            this.abbreviation = abbreviation;
            this.factor = factor;
        }
    }
}

namespace Caterpillar.Areas
{
    public struct DE
    {
        public static readonly DE Empty;

        public static Unit Morgen { get { return new DEUnit("Morgen", "", 2500.0); } }

    }
}