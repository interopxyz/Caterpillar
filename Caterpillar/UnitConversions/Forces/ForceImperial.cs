
namespace Caterpillar.Forces
{
    class ImperialUnit : Force
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

namespace Caterpillar.Forces
{
    public struct Imperial
    {
        public static readonly Imperial Empty;

        public static Unit Poundal { get { return new ImperialUnit("Poundal", " ", 0.13825495); } }
        public static Unit TonForceLong { get { return new ImperialUnit("Ton Force Long", " ", 9964.016384); } }

    }
}