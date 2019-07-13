
namespace Caterpillar.Areas
{
    class MetricUnit : Area
    {
        public MetricUnit(string name, string abbreviation, double factor) : base()
        {
            this.system = Systems.Metric;

            this.name = name;
            this.abbreviation = abbreviation;
            this.factor = factor;
        }
    }
}

namespace Caterpillar.Areas
{
    public struct Metric
    {
        public static readonly Metric Empty;

        public static Unit Hectare { get { return new MetricUnit("Hectare", "ha", 10000.0); } }
        public static Unit Are { get { return new MetricUnit("Are", "a", 100.0); } }

    }
}