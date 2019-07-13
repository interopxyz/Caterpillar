
namespace Caterpillar.Lengths
{
    class SUIUnit : Length
    {
        public SUIUnit(string name, string abbreviation, double factor) : base()
        {
            this.system = Systems.SUI;

            this.name = name;
            this.abbreviation = abbreviation;
            this.factor = factor;
        }
    }
}

namespace Caterpillar.Lengths
{
    public struct SUI
    {
        public static readonly SUI Empty;

        public static Unit Faden { get { return new SUIUnit("Faden", " ", 1.79999985600001); } }
        public static Unit Klafter { get { return new SUIUnit("Klafter", " ", 1.79999985600001); } }
        public static Unit Zoll { get { return new SUIUnit("Zoll", " ", 0.03000000003); } }
        public static Unit Ligne { get { return new SUIUnit("Ligne", " ", 0.00225600000024184); } }

    }
}