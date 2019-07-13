
namespace Caterpillar.Masses
{
    class TroyUnit : Mass
    {
        public TroyUnit(string name, string abbreviation, double factor) : base()
        {
            this.system = Systems.Troy;

            this.name = name;
            this.abbreviation = abbreviation;
            this.factor = factor;
        }

    }

}

namespace Caterpillar.Masses
{
    public struct Troy
    {
        public static readonly Troy Empty;

        public static Unit Pound { get { return new TroyUnit("Pound", "", 373.2417216); } }
        public static Unit Ounce { get { return new TroyUnit("Ounce", "", 31.1034768); } }
        public static Unit Pennyweight { get { return new TroyUnit("Pennyweight", "", 1.55517384); } }
        public static Unit Scruple { get { return new TroyUnit("Scruple", "", 1.2959782); } }

    }


}