
namespace Caterpillar.Forces
{
    class UKUnit : Force
    {
        public UKUnit(string name, string abbreviation, double factor) : base()
        {
            this.system = Systems.UK;

            this.name = name;
            this.abbreviation = abbreviation;
            this.factor = factor;
        }
    }
}

namespace Caterpillar.Forces
{
    public struct UK
    {
        public static readonly UK Empty;

        public static Unit Dyne { get { return new UKUnit("Dyne", " ", 0.00001); } }

    }
}