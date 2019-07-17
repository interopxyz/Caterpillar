
namespace Caterpillar.Times
{
    class CommonUnit : Time
    {
        public CommonUnit(string name, string abbreviation, double factor) : base()
        {
            this.system = Systems.None;

            this.name = name;
            this.abbreviation = abbreviation;
            this.factor = factor;
        }

    }

}

namespace Caterpillar.Times
{
    public struct Common
    {
        public static readonly Common Empty;

        public static Unit Shake { get { return new CommonUnit("Shake", "--", 0.00000001); } }
        public static Unit Minute { get { return new CommonUnit("Minute", "min", 60.0); } }
        public static Unit Hour { get { return new CommonUnit("Hour", "h", 3600.0); } }
        public static Unit Day { get { return new CommonUnit("Day", "d", 86400.0); } }
        public static Unit Week { get { return new CommonUnit("Week", "wk", 604800.0); } }

    }

}