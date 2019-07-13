
namespace Caterpillar.Masses
{
    class ImperialUnit : Mass
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

namespace Caterpillar.Masses
{
    public struct Imperial
    {
        public static readonly Imperial Empty;

        public static Unit Slug { get { return new ImperialUnit("Slug", "--", 14593.903); } }

    }


}