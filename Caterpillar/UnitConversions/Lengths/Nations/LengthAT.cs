
namespace Caterpillar.Lengths
{
    class ATUnit : Length
    {
        public ATUnit(string name, string abbreviation, double factor) : base()
        {
            this.system = Systems.AT;

            this.name = name;
            this.abbreviation = abbreviation;
            this.factor = factor;
        }
    }
}

namespace Caterpillar.Lengths
{
    public struct AT
    {
        public static readonly AT Empty;

        public static Unit Meile { get { return new ATUnit("Meile", " ", 7587.25341426404); } }
        public static Unit Klafter { get { return new ATUnit("Klafter", " ", 1.89650002816303); } }
        public static Unit Faden { get { return new ATUnit("Faden", " ", 1.89650002816303); } }
        public static Unit Elle { get { return new ATUnit("Elle", " ", 0.779299984437379); } }

    }
}