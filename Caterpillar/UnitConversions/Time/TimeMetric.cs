
namespace Caterpillar.Times
{
    class SIUnit : Time
    {
        public SIUnit(string name, string abbreviation, double factor) : base()
        {
            this.system = Systems.SI;

            this.name = name;
            this.abbreviation = abbreviation;
            this.factor = factor;
        }

    }

}

namespace Caterpillar.Times
{
    public struct SI
    {
        public static readonly SI Empty;

        public static Unit Yoctosecond { get { return new SIUnit("Yoctosecond", "ys", 0.000000000000000000000001); } }
        public static Unit Zeptosecond { get { return new SIUnit("Zeptosecond", "zs", 0.000000000000000000001); } }
        public static Unit Attosecond { get { return new SIUnit("Attosecond", "as", 0.000000000000000001); } }
        public static Unit Femtosecond { get { return new SIUnit("Femtosecond", "fs", 0.000000000000001); } }
        public static Unit Picosecond { get { return new SIUnit("Picosecond", "ps", 0.000000000001); } }
        public static Unit Nanosecond { get { return new SIUnit("Nanosecond", "ns", 0.000000001); } }
        public static Unit Microsecond { get { return new SIUnit("Microsecond", "us", 0.000001); } }
        public static Unit Millisecond { get { return new SIUnit("Millisecond", "ms", 0.001); } }
        public static Unit Centisecond { get { return new SIUnit("Centisecond", "cs", 0.01); } }
        public static Unit Decisecond { get { return new SIUnit("Decisecond", "ds", 0.1); } }
        public static Unit Second { get { return new SIUnit("Second", "s", 1.0); } }
        public static Unit Decasecond { get { return new SIUnit("Decasecond", "das", 10.0); } }
        public static Unit Hectosecond { get { return new SIUnit("Hectosecond", "hs", 100.0); } }
        public static Unit Kilosecond { get { return new SIUnit("Kilosecond", "ks", 1000.0); } }
        public static Unit Megasecond { get { return new SIUnit("Megasecond", "Ms", 1000000.0); } }
        public static Unit Gigasecond { get { return new SIUnit("Gigasecond", "Gs", 1000000000.0); } }
        public static Unit Terasecond { get { return new SIUnit("Terasecond", "Ts", 1000000000000.0); } }
        public static Unit Petasecond { get { return new SIUnit("Petasecond", "Ps", 1000000000000000.0); } }
        public static Unit Exasecond { get { return new SIUnit("Exasecond", "Es", 1000000000000000000.0); } }
        public static Unit Zettasecond { get { return new SIUnit("Zettasecond", "Zs", 1000000000000000000000.0); } }
        public static Unit Yottasecond { get { return new SIUnit("Yottasecond", "Ys", 1000000000000000000000000.0); } }

    }

}