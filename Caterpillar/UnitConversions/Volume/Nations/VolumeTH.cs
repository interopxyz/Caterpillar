
namespace Caterpillar.Volumes
{
    class THUnit : Volume
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

namespace Caterpillar.Volumes
{
    public struct TH
    {
        public static readonly TH Empty;

        public static Unit Kwien { get { return new THUnit("Kwien", "--", 2.0); } }
        public static Unit Ban { get { return new THUnit("Ban", "--", 1.0); } }
        public static Unit Sat { get { return new THUnit("Sat", "--", 0.025); } }
        public static Unit Tanan { get { return new THUnit("Tanan", "--", 0.001); } }

    }

}