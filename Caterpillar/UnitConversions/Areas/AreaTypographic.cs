
namespace Caterpillar.Areas
{
    class TypographicUnit : Area
    {
        public TypographicUnit(string name, string abbreviation, double factor) : base()
        {
            this.system = Systems.Typography;

            this.name = name;
            this.abbreviation = abbreviation;
            this.factor = factor;
        }
    }
}

namespace Caterpillar.Areas
{
    public struct Typographic
    {
        public static readonly Typographic Empty;

        public static Unit SquarePoint { get { return new TypographicUnit("Square Point", "pt2", 0.000000124452); } }
        public static Unit SquarePica { get { return new TypographicUnit("Square Pica", "pc2", 0.0000179208); } }

    }
}