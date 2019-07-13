
namespace Caterpillar.Volumes
{
    class CHUnit : Volume
    {
        public CHUnit(string name, string abbreviation, double factor) : base()
        {
            this.system = Systems.CH;

            this.name = name;
            this.abbreviation = abbreviation;
            this.factor = factor;
        }

    }

}

namespace Caterpillar.Volumes
{
    public struct CH
    {
        public static readonly CH Empty;

        public static Unit Dan { get { return new CHUnit("Dan", "--", 0.1); } }
        public static Unit Dou { get { return new CHUnit("Dou", "--", 0.01); } }
        public static Unit Sheng { get { return new CHUnit("Sheng", "--", 0.0001); } }
        public static Unit Ge { get { return new CHUnit("Ge", "--", 0.001); } }
        public static Unit Shao { get { return new CHUnit("Shao", "--", 0.00001); } }
        public static Unit Cuo { get { return new CHUnit("Cuo", "--", 0.000001); } }

    }

}