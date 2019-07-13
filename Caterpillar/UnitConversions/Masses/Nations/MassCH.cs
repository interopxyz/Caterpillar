
namespace Caterpillar.Masses
{
    class CHUnit : Mass
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

namespace Caterpillar.Masses
{
    public struct CH
    {
        public static readonly CH Empty;

        public static Unit Dan { get { return new CHUnit("Dan", "", 50000.0); } }
        public static Unit Jin { get { return new CHUnit("Jin", "", 500.0); } }
        public static Unit Liang { get { return new CHUnit("Liang", "", 50.0); } }
        public static Unit Qian { get { return new CHUnit("Qian", "", 5.0); } }
        public static Unit Fen { get { return new CHUnit("Fen", "", 0.5); } }
        public static Unit Li { get { return new CHUnit("Li", "", 0.05); } }
        public static Unit PiculHk { get { return new CHUnit("Picul (Hk)", "", 60478.982); } }
        public static Unit CattyHk { get { return new CHUnit("Catty (Hk)", "", 604.78982); } }
        public static Unit TaelHk { get { return new CHUnit("Tael (Hk)", "", 37.79936375); } }
        public static Unit MaceHk { get { return new CHUnit("Mace (Hk)", "", 3.779936375); } }
        public static Unit CandareenHk { get { return new CHUnit("Candareen (Hk)", "", 0.3779936375); } }

    }


}