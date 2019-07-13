
namespace Caterpillar.Masses
{
    class JPUnit : Mass
    {
        public JPUnit(string name, string abbreviation, double factor) : base()
        {
            this.system = Systems.JP;

            this.name = name;
            this.abbreviation = abbreviation;
            this.factor = factor;
        }

    }

}

namespace Caterpillar.Masses
{
    public struct JP
    {
        public static readonly JP Empty;

        public static Unit Kan { get { return new JPUnit("Kan", "", 3750.0); } }
        public static Unit Kin { get { return new JPUnit("Kin", "", 600.0); } }
        public static Unit Hyakume { get { return new JPUnit("Hyakume", "", 375.00); } }
        public static Unit Momme { get { return new JPUnit("Momme", "", 3.75); } }
        public static Unit Fun { get { return new JPUnit("Fun", "", 0.375); } }

    }


}