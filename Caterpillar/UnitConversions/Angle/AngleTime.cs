
namespace Caterpillar.Angles
{
    class ChronologicalUnit : Angle
    {
        public ChronologicalUnit(string name, string abbreviation, double factor) : base()
        {
            this.system = Systems.Chronological;

            this.name = name;
            this.abbreviation = abbreviation;
            this.factor = factor;
        }
    }
}

namespace Caterpillar.Angles
{
    public struct Chronological
    {
        public static readonly Chronological Empty;

        public static Unit Second { get { return new ChronologicalUnit("Second", "--", 0.0000048481368110954); } }
        public static Unit Minute { get { return new ChronologicalUnit("Minute", "--", 0.00029088820866572); } }
        public static Unit Hour { get { return new ChronologicalUnit("Hour", "--", 0.523598775598299); } }

    }
}