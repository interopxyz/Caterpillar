
namespace Caterpillar.Areas
{
    class USUnit : Area
    {
        public USUnit(string name, string abbreviation, double factor) : base()
        {
            this.system = Systems.US;

            this.name = name;
            this.abbreviation = abbreviation;
            this.factor = factor;
        }
    }
}

namespace Caterpillar.Areas
{
    public struct US
    {
        public static readonly US Empty;

        public static Unit Homestead { get { return new USUnit("Homestead", "", 647500); } }
        public static Unit Square { get { return new USUnit("Square", "", 9.290304); } }
        public static Unit SquareCubit { get { return new USUnit("Square Cubit", "", 0.20903184); } }
        public static Unit SquareMil { get { return new USUnit("Square Mil", "", 0.00000000064516); } }

    }
}