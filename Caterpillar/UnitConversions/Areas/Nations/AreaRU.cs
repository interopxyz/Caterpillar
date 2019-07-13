
namespace Caterpillar.Areas
{
    class RUUnit : Area
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

namespace Caterpillar.Areas
{
    public struct RU
    {
        public static readonly RU Empty;

        public static Unit DesyatinaState { get { return new RUUnit("Desyatina (State)", "", 10925.3999488473); } }
        public static Unit DesyatinaFarmery { get { return new RUUnit("Desyatina (Farmery)", "", 14567.200037898); } }
        public static Unit SquareVerst { get { return new RUUnit("Square Verst", "", 1138061.99991066); } }
        public static Unit SquareArshin { get { return new RUUnit("Square Arshin", "", 0.505805406847361); } }
        public static Unit SquareFoot { get { return new RUUnit("Square Foot", "", 0.092902999578657); } }

    }
}