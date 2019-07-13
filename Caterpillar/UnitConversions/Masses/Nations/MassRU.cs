
namespace Caterpillar.Masses
{
    class RUUnit : Mass
    {
        public RUUnit(string name, string abbreviation, double factor) : base()
        {
            this.system = Systems.RU;

            this.name = name;
            this.abbreviation = abbreviation;
            this.factor = factor;
        }

    }

}

namespace Caterpillar.Masses
{
    public struct RU
    {
        public static readonly RU Empty;

        public static Unit Packen { get { return new RUUnit("Packen", "", 490790.0); } }
        public static Unit Pud { get { return new RUUnit("Pud", "", 16300.0); } }
        public static Unit Funt { get { return new RUUnit("Funt", "", 409.5); } }
        public static Unit Centner { get { return new RUUnit("Centner", "", 100000.0); } }

    }


}