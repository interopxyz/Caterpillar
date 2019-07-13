
namespace Caterpillar.Pressures
{
    class MetricUnit : Pressure
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

namespace Caterpillar.Pressures
{
    public struct Metric
    {
        public static readonly Metric Empty;

        public static Unit Barad { get { return new MetricUnit("Barad", "ba", 0.1); } }
        public static Unit Pieze { get { return new MetricUnit("Pieze", "pz", 1000.0); } }

    }
}