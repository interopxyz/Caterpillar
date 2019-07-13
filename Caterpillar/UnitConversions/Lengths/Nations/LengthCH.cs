
namespace Caterpillar.Lengths
{
    class CHUnit : Length
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

namespace Caterpillar.Lengths
{
    public struct CH
    {
        public static readonly CH Empty;

        public static Unit Pu { get { return new CHUnit("Pu", " ", 1.79070010643921); } }
        public static Unit Bu { get { return new CHUnit("Bu", " ", 1.66666694444449); } }
        public static Unit Chek { get { return new CHUnit("Chek", " ", 0.371475); } }
        public static Unit Chih { get { return new CHUnit("Ch'ih", " ", 0.35813999563499); } }
        public static Unit Tsun { get { return new CHUnit("Tsun", " ", 0.0371475); } }
        public static Unit Fan { get { return new CHUnit("Fan", " ", 0.00371475); } }
        public static Unit Yin { get { return new CHUnit("Yin", " ", 33.33333333333333333333333); } }
        public static Unit Zhang { get { return new CHUnit("Zhang", " ", 3.333333333333333333333333); } }
        public static Unit Chi { get { return new CHUnit("Chi", " ", 0.333333300000003); } }
        public static Unit Cun { get { return new CHUnit("Cun", " ", 0.0333333300000003); } }
        public static Unit Fen { get { return new CHUnit("Fen", " ", 0.00333333300000003); } }
        public static Unit Li { get { return new CHUnit("Li", " ", 0.000333333300000003); } }
        public static Unit Hao { get { return new CHUnit("Hao", " ", 0.0000333333300000003); } }

    }
}