
namespace Caterpillar.Areas
{
    class AstronomicalUnit : Area
    {
        public AstronomicalUnit(string name, string abbreviation, double factor) : base()
        {
            this.system = Systems.Astronomical;

            this.name = name;
            this.abbreviation = abbreviation;
            this.factor = factor;
        }
    }
}

namespace Caterpillar.Areas
{
    public struct Astronomical
    {
        public static readonly Astronomical Empty;

        public static Unit Siriometer { get { return new AstronomicalUnit("Square Siriometer", " ", 22379522708536900000000000000000000.0); } }
        public static Unit Parsec { get { return new AstronomicalUnit("Square Parsec", " ", 9521408700000000000000000000000.0); } }
        public static Unit AstronomicalUnit { get { return new AstronomicalUnit("Square Astronomical Unit", " ", 22379523000000000000000.0); } }
        public static Unit LightYear { get { return new AstronomicalUnit("Square Light Year", " ", 89505412000000000000000000000000.0); } }
        public static Unit LightDay { get { return new AstronomicalUnit("Square Light Day", " ", 670882854531860000000000000.0); } }
        public static Unit LightHour { get { return new AstronomicalUnit("Square Light Hour", " ", 1165213327413080000000000.0); } }
        public static Unit LightMinute { get { return new AstronomicalUnit("Square Light Minute", " ", 323648142816010000000.0); } }
        public static Unit LightSecond { get { return new AstronomicalUnit("Square Light Second", " ", 8988448234984340.0); } }

    }
}