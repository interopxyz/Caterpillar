
namespace Caterpillar.Lengths
{
    class THUnit : Length
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

namespace Caterpillar.Lengths
{
    public struct TH
    {
        public static readonly TH Empty;

        public static Unit Yote { get { return new THUnit("Yote", " ", 16000.0); } }
        public static Unit Sen { get { return new THUnit("Sen", " ", 40000.0); } }
        public static Unit Wah { get { return new THUnit("Wah", " ", 2000); } }
        public static Unit Sawk { get { return new THUnit("Sawk", " ", 0.5); } }
        public static Unit Keub { get { return new THUnit("Keub", " ", 0.25); } }
        public static Unit Nieu { get { return new THUnit("Nieu", " ", 0.02083); } }
        public static Unit Kabiet { get { return new THUnit("Kabiet", " ", 0.005208); } }

    }
}