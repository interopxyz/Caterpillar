
namespace Caterpillar.Lengths
{
    class DEUnit : Length
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

namespace Caterpillar.Lengths
{
    public struct DE
    {
        public static readonly DE Empty;

        public static Unit Meile { get { return new DEUnit("Meile", " ", 7530.12048192771); } }
        public static Unit Rute { get { return new DEUnit("Rute", " ", 3.74999953125006); } }
        public static Unit Elle { get { return new DEUnit("Elle", " ", 0.599999988); } }
        public static Unit Fuss { get { return new DEUnit("Fuss", " ", 0.316080001112602); } }
        public static Unit Zoll { get { return new DEUnit("Zoll", " ", 0.0263400000233372); } }

    }
}