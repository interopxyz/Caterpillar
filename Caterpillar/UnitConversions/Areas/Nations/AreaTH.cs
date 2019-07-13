
namespace Caterpillar.Areas
{
    class THUnit : Area
    {
        public THUnit(string name, string abbreviation, double factor) : base()
        {
            this.system = Systems.TH;

            this.name = name;
            this.abbreviation = abbreviation;
            this.factor = factor;
        }
    }
}

namespace Caterpillar.Areas
{
    public struct TH
    {
        public static readonly TH Empty;

        public static Unit Ngarn { get { return new THUnit("Ngarn", "", 400.0); } }
        public static Unit Rai { get { return new THUnit("Rai", "", 1600.0); } }
        public static Unit TalangWah { get { return new THUnit("Talang Wah", "", 4.0); } }

    }
}