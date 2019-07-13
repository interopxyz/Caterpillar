
namespace Caterpillar.Masses
{
    class ESUnit : Mass
    {
        public ESUnit(string name, string abbreviation, double factor) : base()
        {
            this.system = Systems.ES;

            this.name = name;
            this.abbreviation = abbreviation;
            this.factor = factor;
        }

    }

}

namespace Caterpillar.Masses
{
    public struct ES
    {
        public static readonly ES Empty;

        public static Unit Arroba { get { return new ESUnit("Arroba", "", 11502.0); } }
        public static Unit Marco { get { return new ESUnit("Marco", "", 230.0); } }
        public static Unit Onza { get { return new ESUnit("Onza", "", 28.69); } }
        public static Unit Libra { get { return new ESUnit("Libra", "", 459.0); } }
        public static Unit Tonelada { get { return new ESUnit("Tonelada", "", 919900.0); } }
        public static Unit Quintal { get { return new ESUnit("Quintal", "", 45900.0); } }

    }


}