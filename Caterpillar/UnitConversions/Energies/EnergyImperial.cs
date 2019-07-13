
namespace Caterpillar.Energies
{
    class ImperialUnit : Energy
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

namespace Caterpillar.Energies
{
    public struct Imperial
    {
        public static readonly Imperial Empty;

        public static Unit Btu { get { return new ImperialUnit("Btu", "", 1055.05585262); } }
        public static Unit Quad { get { return new ImperialUnit("Quad", "", 1055055852620000000); } }

    }
}