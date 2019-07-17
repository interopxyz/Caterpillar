
namespace Caterpillar.Volumes
{
    class AstronomicalUnit : Volume
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

namespace Caterpillar.Volumes
{
    public struct Astronomical
    {
        public static readonly Astronomical Empty;

        public static Unit Siriometer { get { return new AstronomicalUnit("Cubic Siriometer", "--", 3348071026300240000000000000000000000000000000000000.0); } }
        public static Unit Parsec { get { return new AstronomicalUnit("Cubic Parsec", "--", 29380024238500000000000000000000000000000000000000.0); } }
        public static Unit Spat { get { return new AstronomicalUnit("Cubic Spat", "--", 1000000000000000000000000000000000000.0); } }
        public static Unit AstronomicalUnit { get { return new AstronomicalUnit("Cubic Astronomical Unit", "--", 3348071025695960000000000000000000.0); } }
        public static Unit LightYear { get { return new AstronomicalUnit("Cubic Light Year", "--", 846796423032120000000000000000000000000000000000.0); } }
        public static Unit LightDay { get { return new AstronomicalUnit("Cubic Light Day", "--", 17381858414019700000000000000000000000000.0); } }
        public static Unit LightHour { get { return new AstronomicalUnit("Cubic Light Hour", "--", 1256900631070980000000000000000000000.0); } }
        public static Unit LightMinute { get { return new AstronomicalUnit("Cubic Light Minute", "--", 5820095479413570000000000000000.0); } }
        public static Unit LightSecond { get { return new AstronomicalUnit("Cubic Light Second", "--", 0.000000000000000000000000037114); } }

    }

}