
namespace Caterpillar.Areas
{
    class FRUnit : Area
    {
        public FRUnit(string name, string abbreviation, double factor) : base()
        {
            this.system = Systems.FR;

            this.name = name;
            this.abbreviation = abbreviation;
            this.factor = factor;
        }
    }
}

namespace Caterpillar.Areas
{
    public struct FR
    {
        public static readonly FR Empty;

        public static Unit Arpent { get { return new FRUnit("Arpent", "", 3418.89385923086); } }
        public static Unit RoyalSquarePerche { get { return new FRUnit("Royal Square Perche", "", 34.1900213003833); } }
        public static Unit SquareToise { get { return new FRUnit("Square Toise", "", 3.798699325351); } }
        public static Unit SquarePied { get { return new FRUnit("Square Pied", "", 0.105519400095198); } }
        public static Unit SquarePouce { get { return new FRUnit("Square Pouce", "", 0.000732773900010925); } }

    }
}