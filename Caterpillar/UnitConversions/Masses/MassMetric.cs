
namespace Caterpillar.Masses
{
    class MetricUnit : Mass
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

namespace Caterpillar.Masses
{
    public struct Metric
    {
        public static readonly Metric Empty;

        public static Unit Tonne { get { return new MetricUnit("Tonne", "--", 1000000.0); } }

    }


}