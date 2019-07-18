
namespace Caterpillar.Volumes
{
    class MetricUnit : Volume
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

namespace Caterpillar.Volumes
{
    public struct Metric
    {
        public static readonly Metric Empty;

        public static Unit Micron { get { return new SIUnit("Cubic Micron", "--3", 0.000000000000001); } }
        public static Unit Cup { get { return new MetricUnit("Cup", "--", 0.25); } }
        public static Unit Tablespoon { get { return new MetricUnit("Tablespoon", "--", 0.015); } }
        public static Unit Teaspoon { get { return new MetricUnit("Teaspoon", "--", 0.005); } }
        public static Unit Stere { get { return new MetricUnit("Stere", "--", 1.0); } }
        public static Unit CubicAngstrom { get { return new MetricUnit("CubicAngstrom", "A3", 0.000000000000000000000000000001); } }

    }

}