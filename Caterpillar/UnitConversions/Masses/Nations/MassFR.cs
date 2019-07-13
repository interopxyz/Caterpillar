
namespace Caterpillar.Masses
{
    class FRUnit : Mass
    {
        public FRUnit(string name, string abbreviation, double factor) : base()
        {
            this.system = Systems.FR;

            this.name = name;
            this.abbreviation = abbreviation;
            this.factor = factor;
        }

    }

}

namespace Caterpillar.Masses
{
    public struct FR
    {
        public static readonly FR Empty;

        public static Unit Quintal { get { return new FRUnit("Quintal", "", 48950.0); } }
        public static Unit Tonneau { get { return new FRUnit("Tonneau", "", 979000.0); } }
        public static Unit Once { get { return new FRUnit("Once", "", 30.59); } }
        public static Unit Livre { get { return new FRUnit("Livre", "", 489.5); } }
        public static Unit Marc { get { return new FRUnit("Marc", "", 244.75); } }
        public static Unit Denier { get { return new FRUnit("Denier", "", 1.275); } }
        public static Unit Gros { get { return new FRUnit("Gros", "", 3.824); } }

    }


}