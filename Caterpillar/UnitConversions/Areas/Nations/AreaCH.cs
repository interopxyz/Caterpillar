
namespace Caterpillar.Areas
{
    class CHUnit : Area
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

namespace Caterpillar.Areas
{
    public struct CH
    {
        public static readonly CH Empty;

        public static Unit Qing { get { return new CHUnit("Qing", "", 66666.666666666666666667); } }
        public static Unit Mu { get { return new CHUnit("Mu", "", 666.666666666666666667); } }
        public static Unit Fen { get { return new CHUnit("Fen", "", 66.666666666666666667); } }
        public static Unit FangZhang { get { return new CHUnit("Fang Zhang", "", 11.111111111111111111); } }
        public static Unit Li { get { return new CHUnit("Li", "", 6.666666666666666667); } }
        public static Unit Hao { get { return new CHUnit("Hao", "", 0.666666666666666667); } }
        public static Unit FangCun { get { return new CHUnit("Fang Cun", "", 0.001111111111111111); } }
        public static Unit FangChi { get { return new CHUnit("Fang Chi", "", 0.111111111111111111); } }

    }
}