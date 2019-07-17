
namespace Caterpillar.Temperatures
{
    class ImperialUnit : Temperature
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

namespace Caterpillar.Temperatures
{
    public struct Imperial
    {
        public static readonly Imperial Empty;

        public static Unit Fahrenheit { get { return new ImperialUnit("Fahrenheit", "F", 255.92777777778); } }
    }


}