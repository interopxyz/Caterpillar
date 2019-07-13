
namespace Caterpillar.Pressures
{
    class CommonUnit : Pressure
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

namespace Caterpillar.Pressures
{
    public struct Common
    {
        public static readonly Common Empty;
        public static Unit AtmosphereTechnical { get { return new CommonUnit("Atmosphere Technical", "--", 98066.5); } }
        public static Unit AtmosphereStandard { get { return new CommonUnit("Atmosphere Standard", "--", 101325.01); } }

    }
}