
namespace Caterpillar.Volumes
{
    class CustomUnit : Volume
    {
        public CustomUnit(string name, string abbreviation, double factor) : base()
        {
            this.system = Systems.None;

            this.name = name;
            this.abbreviation = abbreviation;
            this.factor = factor;
        }
    }
}

namespace Caterpillar.Volumes
{
    public struct Custom
    {
        private static Unit CustomizableUnit = SI.Meters.Meter;
        public static readonly Custom Empty;

        public static Unit CustomUnit { get { return CustomizableUnit; } set { CustomizableUnit = value; } }

    }
}