
namespace Caterpillar.Volumes
{
    class TypographicUnit : Volume
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

namespace Caterpillar.Volumes
{
    public struct Typographic
    {
        public static readonly Typographic Empty;

        public static Unit CubicPoint { get { return new TypographicUnit("Cubic Point", "pt3", 0.000000000043904); } }
        public static Unit CubicPica { get { return new TypographicUnit("Cubic Pica", "pc3", 0.0000000758642); } }

    }
}