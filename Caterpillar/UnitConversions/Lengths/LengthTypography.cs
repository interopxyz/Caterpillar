
namespace Caterpillar.Lengths
{
    class TypographicUnit : Length
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

namespace Caterpillar.Lengths
{
    public struct Typographic
    {
        public static readonly Typographic Empty;

        public static Unit Point { get { return new TypographicUnit("Point", "pt", 0.00035277777778); } }
        public static Unit Pica { get { return new TypographicUnit("Pica", "pc", 0.0042175176); } }
        public static Unit Didot { get { return new TypographicUnit("Didot", "dd", 0.000377); } }
        public static Unit Cicero { get { return new TypographicUnit("Cicero", "cp", 0.00451167); } }
        public static Unit Twip { get { return new TypographicUnit("Twip", "twp", 0.000017639); } }
        public static Unit Agate { get { return new TypographicUnit("Agate", "--", 0.00035277777778); } }
    }
}