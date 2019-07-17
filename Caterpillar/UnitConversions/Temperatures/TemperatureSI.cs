
namespace Caterpillar.Temperatures
{
    class SIUnit : Temperature
    {
        public SIUnit(string name, string abbreviation, double factor) : base()
        {
            this.system = Systems.SI;

            this.name = name;
            this.abbreviation = abbreviation;
            this.factor = factor;
        }
    }
}

namespace Caterpillar.Temperatures
{
    public struct SI
    {
        public static readonly SI Empty;

        public static Unit Kelvin { get { return new SIUnit("Kelvin", "K", 1); } }
        public static Unit Celsius { get { return new SIUnit("Celsius", "C", 274.15); } }

    }

}