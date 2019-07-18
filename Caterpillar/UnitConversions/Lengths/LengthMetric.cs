
namespace Caterpillar.Lengths
{
    class MetricUnit : Length
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

namespace Caterpillar.Lengths
{
    public struct Metric
    {
        public static readonly Metric Empty;

        public static Unit Micron { get { return new SIUnit("Micron", "--", 0.000001); } }
        public static Unit Angstrom { get { return new MetricUnit("Angstrom", "A", 0.0000000001); } }

    }
}