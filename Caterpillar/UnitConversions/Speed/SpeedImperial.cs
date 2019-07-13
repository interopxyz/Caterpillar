
namespace Caterpillar.Speeds
{
    class ImperialUnit : Speed
    {
        public ImperialUnit(string name, string abbreviation, double factor) : base()
        {
            this.system = Systems.Imperial;

            this.name = name;
            this.abbreviation = abbreviation;
            this.factor = factor;
        }
    }
}

namespace Caterpillar.Speeds.Imperial.PerSecond
{
    public struct Imperial
    {
        public static readonly Imperial Empty;

        public static Unit InchSecond { get { return new ImperialUnit("Inch per Second", "in/s", 0.0254); } }
        public static Unit FootSecond { get { return new ImperialUnit("Foot per Second", "ft/s", 0.3048); } }
        public static Unit YardSecond { get { return new ImperialUnit("Yard per Second", "yd/s", 0.9144); } }
        public static Unit MileSecond { get { return new ImperialUnit("Mile per Second", "mi/s", 1609.344); } }

    }
}

namespace Caterpillar.Speeds.Imperial.PerMinute
{
    public struct Imperial
    {
        public static readonly Imperial Empty;

        public static Unit InchMinute { get { return new ImperialUnit("Inch per Minute", "in/min", 0.00042333333333); } }
        public static Unit FootMinute { get { return new ImperialUnit("Inch per Minute", "ft/min", 0.00508); } }
        public static Unit YardMinute { get { return new ImperialUnit("Foot per Minute", "yd/min", 0.01524); } }
        public static Unit MileMinute { get { return new ImperialUnit("Yard per Minute", "mi/min", 26.8224); } }

    }
}

namespace Caterpillar.Speeds.Imperial.PerHour
{
    public struct Imperial
    {
        public static readonly Imperial Empty;

        public static Unit InchHour { get { return new ImperialUnit("Inch per Hour", "in/h", 0.0000070555555556); } }
        public static Unit FootHour { get { return new ImperialUnit("Foot per Hour", "ft/h", 0.000084666666667); } }
        public static Unit YardHour { get { return new ImperialUnit("Yard per Hour", "yd/h", 0.000254); } }
        public static Unit MileHour { get { return new ImperialUnit("Mile per Hour", "mi/h", 0.44704); } }

    }
}