
namespace Caterpillar.Forces
{
    class MetricUnit : Force
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

namespace Caterpillar.Forces
{
    public struct Metric
    {
        public static readonly Metric Empty;

        public static Unit Sthene { get { return new MetricUnit("Sthene", " ", 1000.0); } }
        public static Unit TonForceMetric { get { return new MetricUnit("Ton Force Metric", " ", 9806.65); } }

    }
}